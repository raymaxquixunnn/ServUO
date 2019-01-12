using System;
using Server.Engines.Craft;
using Server.Mobiles;
using Server.Targeting;

namespace Server.Items
{
    public abstract class BaseOre : Item
    {
        protected virtual CraftResource DefaultResource { get { return CraftResource.Iron; } }

        private CraftResource m_Resource;

        [CommandProperty(AccessLevel.GameMaster)]
        public CraftResource Resource
        {
            get
            {
                return this.m_Resource;
            }
            set
            {
                this.m_Resource = value;
                this.InvalidateProperties();
            }
        }

        public abstract BaseIngot GetIngot();

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)1); // version

            writer.Write((int)this.m_Resource);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch ( version )
            {
                case 2: // Reset from Resource System
                    this.m_Resource = this.DefaultResource;
                    reader.ReadString();
                    break;
                case 1:
                    {
                        this.m_Resource = (CraftResource)reader.ReadInt();
                        break;
                    }
                case 0:
                    {
                        OreInfo info;

                        switch ( reader.ReadInt() )
                        {
						case 0:
							info = OreInfo.Iron;
							break;
						case 1:
							info = OreInfo.DullCopper;
							break;
						case 2:
							info = OreInfo.ShadowIron;
							break;
						case 3:
							info = OreInfo.Copper;
							break;
						case 4:
							info = OreInfo.Bronze;
							break;
						case 5:
							info = OreInfo.Gold;
							break;
						case 6:
							info = OreInfo.Silver;
							break;
						case 7:
							info = OreInfo.Agapite;
							break;
						case 8:
							info = OreInfo.Verite;
							break;
						case 9:
							info = OreInfo.Valorite;
							break;
						case 10:
							info = OreInfo.Uridium;
							break;
						case 11:
							info = OreInfo.Trillium;
							break;
						case 12:
							info = OreInfo.Titanium;
							break;
						case 13:
							info = OreInfo.Platinum;
							break;
						case 14:
							info = OreInfo.Zenite;
							break;
						case 15:
							info = OreInfo.Naquinite;
							break;
						case 16:
							info = OreInfo.Galvinite;
							break;
						case 17:
							info = OreInfo.Trilamide;
							break;
						case 18:
							info = OreInfo.Veramide;
							break;
						case 19:
							info = OreInfo.Zenlamide;
							break;
						case 20:
							info = OreInfo.Guardians;
							break;
						default:
							info = null;
							break;
                        }

                        this.m_Resource = CraftResources.GetFromOreInfo(info);
                        break;
                    }
            }
        }

        private static int RandomSize()
        {
            double rand = Utility.RandomDouble();

            if (rand < 0.12)
                return 0x19B7;
            else if (rand < 0.18)
                return 0x19B8;
            else if (rand < 0.25)
                return 0x19BA;
            else
                return 0x19B9;
        }

        public BaseOre(CraftResource resource)
            : this(resource, 1)
        {
        }

        public BaseOre(CraftResource resource, int amount)
            : base(RandomSize())
        {
            this.Stackable = true;
            this.Amount = amount;
            this.Hue = CraftResources.GetHue(resource);

            this.m_Resource = resource;
        }

        public BaseOre(Serial serial)
            : base(serial)
        {
        }

        public override void AddNameProperty(ObjectPropertyList list)
        {
            if (this.Amount > 1)
                list.Add(1050039, "{0}\t#{1}", this.Amount, 1026583); // ~1_NUMBER~ ~2_ITEMNAME~
            else
                list.Add(1026583); // ore
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            if (!CraftResources.IsStandard(this.m_Resource))
            {
                int num = CraftResources.GetLocalizationNumber(this.m_Resource);

                if (num > 0)
                    list.Add(num);
                else
                    list.Add(CraftResources.GetName(this.m_Resource));
            }
        }

        public override int LabelNumber
        {
            get
            {
                if (this.m_Resource >= CraftResource.DullCopper && this.m_Resource <= CraftResource.Guardians)
                    return 1042845 + (int)(this.m_Resource - CraftResource.DullCopper);

                return 1042853; // iron ore;
            }
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (!this.Movable)
                return;

            if (this.RootParent is BaseCreature)
            {
                from.SendLocalizedMessage(500447); // That is not accessible
            }
            else if (from.InRange(this.GetWorldLocation(), 2))
            {
                from.SendLocalizedMessage(501971); // Select the forge on which to smelt the ore, or another pile of ore with which to combine it.
                from.Target = new InternalTarget(this);
            }
            else
            {
                from.SendLocalizedMessage(501976); // The ore is too far away.
            }
        }

        private class InternalTarget : Target
        {
            private readonly BaseOre m_Ore;

            public InternalTarget(BaseOre ore)
                : base(2, false, TargetFlags.None)
            {
                this.m_Ore = ore;
            }

            private bool IsForge(object obj)
            {
                if (Core.ML && obj is Mobile && ((Mobile)obj).IsDeadBondedPet)
                    return false;

                if (obj.GetType().IsDefined(typeof(ForgeAttribute), false))
                    return true;

                int itemID = 0;

                if (obj is Item)
                    itemID = ((Item)obj).ItemID;
                else if (obj is StaticTarget)
                    itemID = ((StaticTarget)obj).ItemID;

                return (itemID == 4017 || (itemID >= 6522 && itemID <= 6569));
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                if (this.m_Ore.Deleted)
                    return;

                if (!from.InRange(this.m_Ore.GetWorldLocation(), 2))
                {
                    from.SendLocalizedMessage(501976); // The ore is too far away.
                    return;
                }

                #region Combine Ore
                if (targeted is BaseOre)
                {
                    BaseOre ore = (BaseOre)targeted;

                    if (!ore.Movable)
                    {
                        return;
                    }
                    else if (this.m_Ore == ore)
                    {
                        from.SendLocalizedMessage(501972); // Select another pile or ore with which to combine this.
                        from.Target = new InternalTarget(ore);
                        return;
                    }
                    else if (ore.Resource != this.m_Ore.Resource)
                    {
                        from.SendLocalizedMessage(501979); // You cannot combine ores of different metals.
                        return;
                    }

                    int worth = ore.Amount;

                    if (ore.ItemID == 0x19B9)
                        worth *= 8;
                    else if (ore.ItemID == 0x19B7)
                        worth *= 2;
                    else
                        worth *= 4;

                    int sourceWorth = this.m_Ore.Amount;

                    if (this.m_Ore.ItemID == 0x19B9)
                        sourceWorth *= 8;
                    else if (this.m_Ore.ItemID == 0x19B7)
                        sourceWorth *= 2;
                    else
                        sourceWorth *= 4;

                    worth += sourceWorth;

                    int plusWeight = 0;
                    int newID = ore.ItemID;

                    if (ore.DefaultWeight != this.m_Ore.DefaultWeight)
                    {
                        if (ore.ItemID == 0x19B7 || this.m_Ore.ItemID == 0x19B7)
                        {
                            newID = 0x19B7;
                        }
                        else if (ore.ItemID == 0x19B9)
                        {
                            newID = this.m_Ore.ItemID;
                            plusWeight = ore.Amount * 2;
                        }
                        else
                        {
                            plusWeight = this.m_Ore.Amount * 2;
                        }
                    }

                    if ((ore.ItemID == 0x19B9 && worth > 120000) || ((ore.ItemID == 0x19B8 || ore.ItemID == 0x19BA) && worth > 60000) || (ore.ItemID == 0x19B7 && worth > 30000))
                    {
                        from.SendLocalizedMessage(1062844); // There is too much ore to combine.
                        return;
                    }
                    else if (ore.RootParent is Mobile && (plusWeight + ((Mobile)ore.RootParent).Backpack.TotalWeight) > ((Mobile)ore.RootParent).Backpack.MaxWeight)
                    {
                        from.SendLocalizedMessage(501978); // The weight is too great to combine in a container.
                        return;
                    }

                    ore.ItemID = newID;

                    if (ore.ItemID == 0x19B9)
                        ore.Amount = worth / 8;
                    else if (ore.ItemID == 0x19B7)
                        ore.Amount = worth / 2;
                    else
                        ore.Amount = worth / 4;

                    this.m_Ore.Delete();
                    return;
                }
                #endregion

                if (this.IsForge(targeted))
                {
                    double difficulty;

                    #region Void Pool Rewards
                    bool talisman = false;
                    SmeltersTalisman t = from.FindItemOnLayer(Layer.Talisman) as SmeltersTalisman;
                    if (t != null && t.Resource == m_Ore.Resource)
                        talisman = true;
                    #endregion

                    switch ( this.m_Ore.Resource )
                    {
                        default:
                            difficulty = 50.0;
                            break;
						case CraftResource.DullCopper:
							difficulty = 65.0;
							break;
						case CraftResource.ShadowIron:
							difficulty = 80.0;
							break;
						case CraftResource.Copper:
							difficulty = 95.0;
							break;
						case CraftResource.Bronze:
							difficulty = 100.0;
							break;
						case CraftResource.Gold:
							difficulty = 105.0;
							break;
						case CraftResource.Silver:
							difficulty = 110.0;
							break;
						case CraftResource.Agapite:
							difficulty = 115.0;
							break;
						case CraftResource.Verite:
							difficulty = 120.0;
							break;
						case CraftResource.Valorite:
							difficulty = 125.0;
							break;
						case CraftResource.Uridium:
							difficulty = 125.0;
							break;
						case CraftResource.Trillium:
							difficulty = 130.0;
							break;
						case CraftResource.Titanium:
							difficulty = 130.0;
							break;
						case CraftResource.Platinum:
							difficulty = 135.0;
							break;
						case CraftResource.Zenite:
							difficulty = 135.0;
							break;
						case CraftResource.Naquinite:
							difficulty = 140.0;
							break;
						case CraftResource.Galvinite:
							difficulty = 140.0;
							break;
						case CraftResource.Trilamide:
							difficulty = 145.0;
							break;
						case CraftResource.Veramide:
							difficulty = 145.0;
							break;
						case CraftResource.Zenlamide:
							difficulty = 150.0;
							break;
						case CraftResource.Guardians:
							difficulty = 150.0;
							break;
                    }

                    double minSkill = difficulty - 25.0;
                    double maxSkill = difficulty + 25.0;

                    if (difficulty > 50.0 && difficulty > from.Skills[SkillName.Mining].Value && !talisman)
                    {
                        from.SendLocalizedMessage(501986); // You have no idea how to smelt this strange ore!
                        return;
                    }

                    if (this.m_Ore.ItemID == 0x19B7 && this.m_Ore.Amount < 2)
                    {
                        from.SendLocalizedMessage(501987); // There is not enough metal-bearing ore in this pile to make an ingot.
                        return;
                    }

                    if (talisman || from.CheckTargetSkill(SkillName.Mining, targeted, minSkill, maxSkill))
                    {
                        int toConsume = this.m_Ore.Amount;

                        if (toConsume <= 0)
                        {
                            from.SendLocalizedMessage(501987); // There is not enough metal-bearing ore in this pile to make an ingot.
                        }
                        else
                        {
                            if (toConsume > 30000)
                                toConsume = 30000;

                            int ingotAmount;

                            if (this.m_Ore.ItemID == 0x19B7)
                            {
                                ingotAmount = toConsume / 2;

                                if (toConsume % 2 != 0)
                                    --toConsume;
                            }
                            else if (this.m_Ore.ItemID == 0x19B9)
                            {
                                ingotAmount = toConsume * 2;
                            }
                            else
                            {
                                ingotAmount = toConsume;
                            }

                            BaseIngot ingot = this.m_Ore.GetIngot();
                            ingot.Amount = ingotAmount;

                            this.m_Ore.Consume(toConsume);
                            from.AddToBackpack(ingot);
                            //from.PlaySound( 0x57 );

                            if (talisman && t != null)
                            {
                                t.UsesRemaining--;
                                from.SendLocalizedMessage(1152620); // The magic of your talisman guides your hands as you purify the metal. Success is ensured!
                            }
                            else
                                from.SendLocalizedMessage(501988); // You smelt the ore removing the impurities and put the metal in your backpack.
                        }
                    }
                    else
                    {
                        if (this.m_Ore.Amount < 2)
                        {
                            if (this.m_Ore.ItemID == 0x19B9)
                                this.m_Ore.ItemID = 0x19B8;
                            else
                                this.m_Ore.ItemID = 0x19B7;
                        }
                        else
                        {
                            this.m_Ore.Amount /= 2;
                        }

                        from.SendLocalizedMessage(501990); // You burn away the impurities but are left with less useable metal.
                    }
                }
            }
        }
    }

    public class IronOre : BaseOre
    {
        [Constructable]
        public IronOre()
            : this(1)
        {
        }

        [Constructable]
        public IronOre(int amount)
            : base(CraftResource.Iron, amount)
        {
        }

        public IronOre(bool fixedSize)
            : this(1)
        {
            if (fixedSize)
                this.ItemID = 0x19B8;
        }

        public IronOre(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new IronIngot();
        }
    }

    public class DullCopperOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.DullCopper; } }

        [Constructable]
        public DullCopperOre()
            : this(1)
        {
        }

        [Constructable]
        public DullCopperOre(int amount)
            : base(CraftResource.DullCopper, amount)
        {
        }

        public DullCopperOre(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new DullCopperIngot();
        }
    }

    public class ShadowIronOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.ShadowIron; } }

        [Constructable]
        public ShadowIronOre()
            : this(1)
        {
        }

        [Constructable]
        public ShadowIronOre(int amount)
            : base(CraftResource.ShadowIron, amount)
        {
        }

        public ShadowIronOre(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new ShadowIronIngot();
        }
    }

    public class CopperOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Copper; } }

        [Constructable]
        public CopperOre()
            : this(1)
        {
        }

        [Constructable]
        public CopperOre(int amount)
            : base(CraftResource.Copper, amount)
        {
        }

        public CopperOre(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new CopperIngot();
        }
    }

    public class BronzeOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Bronze; } }

        [Constructable]
        public BronzeOre()
            : this(1)
        {
        }

        [Constructable]
        public BronzeOre(int amount)
            : base(CraftResource.Bronze, amount)
        {
        }

        public BronzeOre(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new BronzeIngot();
        }
    }

    public class GoldOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Gold; } }

        [Constructable]
        public GoldOre()
            : this(1)
        {
        }

        [Constructable]
        public GoldOre(int amount)
            : base(CraftResource.Gold, amount)
        {
        }

        public GoldOre(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new GoldIngot();
        }
    }

    public class SilverOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Silver; } }

        [Constructable]
        public SilverOre()
            : this(1)
        {
        }

        [Constructable]
        public SilverOre(int amount)
            : base(CraftResource.Silver, amount)
        {
        }

        public SilverOre(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new SilverIngot();
        }
    }

    public class AgapiteOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Agapite; } }

        [Constructable]
        public AgapiteOre()
            : this(1)
        {
        }

        [Constructable]
        public AgapiteOre(int amount)
            : base(CraftResource.Agapite, amount)
        {
        }

        public AgapiteOre(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new AgapiteIngot();
        }
    }

    public class VeriteOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Verite; } }

        [Constructable]
        public VeriteOre()
            : this(1)
        {
        }

        [Constructable]
        public VeriteOre(int amount)
            : base(CraftResource.Verite, amount)
        {
        }

        public VeriteOre(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new VeriteIngot();
        }
    }

    public class ValoriteOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Valorite; } }

        [Constructable]
        public ValoriteOre()
            : this(1)
        {
        }

        [Constructable]
        public ValoriteOre(int amount)
            : base(CraftResource.Valorite, amount)
        {
        }

        public ValoriteOre(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new ValoriteIngot();
        }
    }



    public class UridiumOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Uridium; } }

        [Constructable]
        public UridiumOre()
            : this(1)
        {
        }

        [Constructable]
        public UridiumOre(int amount)
            : base(CraftResource.Uridium, amount)
        {
        }

        public UridiumOre(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "UridiumOre"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new UridiumIngot();
        }
    }

    public class TrilliumOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Trillium; } }

        [Constructable]
        public TrilliumOre()
            : this(1)
        {
        }

        [Constructable]
        public TrilliumOre(int amount)
            : base(CraftResource.Trillium, amount)
        {
        }

        public TrilliumOre(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "TrilliumOre"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new TrilliumIngot();
        }
    }

    public class TitaniumOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Titanium; } }

        [Constructable]
        public TitaniumOre()
            : this(1)
        {
        }

        [Constructable]
        public TitaniumOre(int amount)
            : base(CraftResource.Titanium, amount)
        {
        }

        public TitaniumOre(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "TitaniumOre"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new TitaniumIngot();
        }
    }

    public class PlatinumOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Platinum; } }

        [Constructable]
        public PlatinumOre()
            : this(1)
        {
        }

        [Constructable]
        public PlatinumOre(int amount)
            : base(CraftResource.Platinum, amount)
        {
        }

        public PlatinumOre(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "PlatinumOre"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new PlatinumIngot();
        }
    }

    public class ZeniteOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Zenite; } }

        [Constructable]
        public ZeniteOre()
            : this(1)
        {
        }

        [Constructable]
        public ZeniteOre(int amount)
            : base(CraftResource.Zenite, amount)
        {
        }

        public ZeniteOre(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "ZeniteOre"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new ZeniteIngot();
        }
    }

    public class NaquiniteOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Naquinite; } }

        [Constructable]
        public NaquiniteOre()
            : this(1)
        {
        }

        [Constructable]
        public NaquiniteOre(int amount)
            : base(CraftResource.Naquinite, amount)
        {
        }

        public NaquiniteOre(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "NaquiniteOre"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new NaquiniteIngot();
        }
    }

    public class GalviniteOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Galvinite; } }

        [Constructable]
        public GalviniteOre()
            : this(1)
        {
        }

        [Constructable]
        public GalviniteOre(int amount)
            : base(CraftResource.Galvinite, amount)
        {
        }

        public GalviniteOre(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "GalviniteOre"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new GalviniteIngot();
        }
    }

    public class TrilamideOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Trilamide; } }

        [Constructable]
        public TrilamideOre()
            : this(1)
        {
        }

        [Constructable]
        public TrilamideOre(int amount)
            : base(CraftResource.Trilamide, amount)
        {
        }

        public TrilamideOre(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "TrilamideOre"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new TrilamideIngot();
        }
    }

    public class VeramideOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Veramide; } }

        [Constructable]
        public VeramideOre()
            : this(1)
        {
        }

        [Constructable]
        public VeramideOre(int amount)
            : base(CraftResource.Veramide, amount)
        {
        }

        public VeramideOre(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "VeramideOre"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new VeramideIngot();
        }
    }

    public class ZenlamideOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Zenlamide; } }

        [Constructable]
        public ZenlamideOre()
            : this(1)
        {
        }

        [Constructable]
        public ZenlamideOre(int amount)
            : base(CraftResource.Zenlamide, amount)
        {
        }

        public ZenlamideOre(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "ZenlamideOre"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new ZenlamideIngot();
        }
    }

    public class GuardiansOre : BaseOre
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Guardians; } }

        [Constructable]
        public GuardiansOre()
            : this(1)
        {
        }

        [Constructable]
        public GuardiansOre(int amount)
            : base(CraftResource.Guardians, amount)
        {
        }

        public GuardiansOre(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "GuardiansOre"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override BaseIngot GetIngot()
        {
            return new GuardiansIngot();
        }
    }

}