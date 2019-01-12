using System;

namespace Server.Items
{
    public abstract class BaseIngot : Item, ICommodity
    {
        protected virtual CraftResource DefaultResource { get { return CraftResource.Iron; } }

        private CraftResource m_Resource;
        public BaseIngot(CraftResource resource)
            : this(resource, 1)
        {
        }

        public BaseIngot(CraftResource resource, int amount)
            : base(0x1BF2)
        {
            this.Stackable = true;
            this.Amount = amount;
            this.Hue = CraftResources.GetHue(resource);

            this.m_Resource = resource;
        }

        public BaseIngot(Serial serial)
            : base(serial)
        {
        }

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
        public override double DefaultWeight
        {
            get
            {
                return 0.1;
            }
        }
        public override int LabelNumber
        {
            get
            {
                if (this.m_Resource >= CraftResource.DullCopper && this.m_Resource <= CraftResource.Valorite)
                    return 1042684 + (int)(this.m_Resource - CraftResource.DullCopper);

                return 1042692;
            }
        }
        TextDefinition ICommodity.Description
        {
            get
            {
                return this.LabelNumber;
            }
        }
        bool ICommodity.IsDeedable
        {
            get
            {
                return true;
            }
        }
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

        public override void AddNameProperty(ObjectPropertyList list)
        {
            if (this.Amount > 1)
                list.Add(1050039, "{0}\t#{1}", this.Amount, 1027154); // ~1_NUMBER~ ~2_ITEMNAME~
            else
                list.Add(1027154); // ingots
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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class IronIngot : BaseIngot
    {
        [Constructable]
        public IronIngot()
            : this(1)
        {
        }

        [Constructable]
        public IronIngot(int amount)
            : base(CraftResource.Iron, amount)
        {
        }

        public IronIngot(Serial serial)
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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class DullCopperIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.DullCopper; } }

        [Constructable]
        public DullCopperIngot()
            : this(1)
        {
        }

        [Constructable]
        public DullCopperIngot(int amount)
            : base(CraftResource.DullCopper, amount)
        {
        }

        public DullCopperIngot(Serial serial)
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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class ShadowIronIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.ShadowIron; } }

        [Constructable]
        public ShadowIronIngot()
            : this(1)
        {
        }

        [Constructable]
        public ShadowIronIngot(int amount)
            : base(CraftResource.ShadowIron, amount)
        {
        }

        public ShadowIronIngot(Serial serial)
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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class CopperIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Copper; } }

        [Constructable]
        public CopperIngot()
            : this(1)
        {
        }

        [Constructable]
        public CopperIngot(int amount)
            : base(CraftResource.Copper, amount)
        {
        }

        public CopperIngot(Serial serial)
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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class BronzeIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Bronze; } }

        [Constructable]
        public BronzeIngot()
            : this(1)
        {
        }

        [Constructable]
        public BronzeIngot(int amount)
            : base(CraftResource.Bronze, amount)
        {
        }

        public BronzeIngot(Serial serial)
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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class GoldIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Gold; } }

        [Constructable]
        public GoldIngot()
            : this(1)
        {
        }

        [Constructable]
        public GoldIngot(int amount)
            : base(CraftResource.Gold, amount)
        {
        }

        public GoldIngot(Serial serial)
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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class AgapiteIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Agapite; } }

        [Constructable]
        public AgapiteIngot()
            : this(1)
        {
        }

        [Constructable]
        public AgapiteIngot(int amount)
            : base(CraftResource.Agapite, amount)
        {
        }

        public AgapiteIngot(Serial serial)
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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class VeriteIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Verite; } }

        [Constructable]
        public VeriteIngot()
            : this(1)
        {
        }

        [Constructable]
        public VeriteIngot(int amount)
            : base(CraftResource.Verite, amount)
        {
        }

        public VeriteIngot(Serial serial)
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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class ValoriteIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Valorite; } }

        [Constructable]
        public ValoriteIngot()
            : this(1)
        {
        }

        [Constructable]
        public ValoriteIngot(int amount)
            : base(CraftResource.Valorite, amount)
        {
        }

        public ValoriteIngot(Serial serial)
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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class SilverIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Silver; } }

        [Constructable]
        public SilverIngot()
            : this(1)
        {
        }

        [Constructable]
        public SilverIngot(int amount)
            : base(CraftResource.Silver, amount)
        {
        }

        public SilverIngot(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "SilverIngot"; } }

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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class UridiumIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Uridium; } }

        [Constructable]
        public UridiumIngot()
            : this(1)
        {
        }

        [Constructable]
        public UridiumIngot(int amount)
            : base(CraftResource.Uridium, amount)
        {
        }

        public UridiumIngot(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "UridiumIngot"; } }

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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class TrilliumIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Trillium; } }

        [Constructable]
        public TrilliumIngot()
            : this(1)
        {
        }

        [Constructable]
        public TrilliumIngot(int amount)
            : base(CraftResource.Trillium, amount)
        {
        }

        public TrilliumIngot(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "TrilliumIngot"; } }

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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class TitaniumIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Titanium; } }

        [Constructable]
        public TitaniumIngot()
            : this(1)
        {
        }

        [Constructable]
        public TitaniumIngot(int amount)
            : base(CraftResource.Titanium, amount)
        {
        }

        public TitaniumIngot(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "TitaniumIngot"; } }

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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class PlatinumIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Platinum; } }

        [Constructable]
        public PlatinumIngot()
            : this(1)
        {
        }

        [Constructable]
        public PlatinumIngot(int amount)
            : base(CraftResource.Platinum, amount)
        {
        }

        public PlatinumIngot(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "PlatinumIngot"; } }

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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class ZeniteIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Zenite; } }

        [Constructable]
        public ZeniteIngot()
            : this(1)
        {
        }

        [Constructable]
        public ZeniteIngot(int amount)
            : base(CraftResource.Zenite, amount)
        {
        }

        public ZeniteIngot(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "ZeniteIngot"; } }

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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class NaquiniteIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Naquinite; } }

        [Constructable]
        public NaquiniteIngot()
            : this(1)
        {
        }

        [Constructable]
        public NaquiniteIngot(int amount)
            : base(CraftResource.Naquinite, amount)
        {
        }

        public NaquiniteIngot(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "NaquiniteIngot"; } }

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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class GalviniteIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Galvinite; } }

        [Constructable]
        public GalviniteIngot()
            : this(1)
        {
        }

        [Constructable]
        public GalviniteIngot(int amount)
            : base(CraftResource.Galvinite, amount)
        {
        }

        public GalviniteIngot(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "GalviniteIngot"; } }

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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class TrilamideIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Trilamide; } }

        [Constructable]
        public TrilamideIngot()
            : this(1)
        {
        }

        [Constructable]
        public TrilamideIngot(int amount)
            : base(CraftResource.Trilamide, amount)
        {
        }

        public TrilamideIngot(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "TrilamideIngot"; } }

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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class VeramideIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Veramide; } }

        [Constructable]
        public VeramideIngot()
            : this(1)
        {
        }

        [Constructable]
        public VeramideIngot(int amount)
            : base(CraftResource.Veramide, amount)
        {
        }

        public VeramideIngot(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "VeramideIngot"; } }

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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class ZenlamideIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Zenlamide; } }

        [Constructable]
        public ZenlamideIngot()
            : this(1)
        {
        }

        [Constructable]
        public ZenlamideIngot(int amount)
            : base(CraftResource.Zenlamide, amount)
        {
        }

        public ZenlamideIngot(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "ZenlamideIngot"; } }

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
    }

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class GuardiansIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Guardians; } }

        [Constructable]
        public GuardiansIngot()
            : this(1)
        {
        }

        [Constructable]
        public GuardiansIngot(int amount)
            : base(CraftResource.Guardians, amount)
        {
        }

        public GuardiansIngot(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "GuardiansIngot"; } }

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
    }
}