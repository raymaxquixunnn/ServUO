using System;

namespace Server.Items
{
    public abstract class BaseHides : Item, ICommodity
    {
        protected virtual CraftResource DefaultResource { get { return CraftResource.RegularLeather; } }

        private CraftResource m_Resource;
        public BaseHides(CraftResource resource)
            : this(resource, 1)
        {
        }

        public BaseHides(CraftResource resource, int amount)
            : base(0x1079)
        {
            this.Stackable = true;
            this.Weight = 5.0;
            this.Amount = amount;
            this.Hue = CraftResources.GetHue(resource);

            this.m_Resource = resource;
        }

        public BaseHides(Serial serial)
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
        public override int LabelNumber
        {
            get
            {
                if (this.m_Resource >= CraftResource.SpinedLeather && this.m_Resource <= CraftResource.GuardiansLeather)
                    return 1049687 + (int)(this.m_Resource - CraftResource.SpinedLeather);

                return 1047023;
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
                        OreInfo info = new OreInfo(reader.ReadInt(), reader.ReadInt(), reader.ReadString());

                        this.m_Resource = CraftResources.GetFromOreInfo(info);
                        break;
                    }
            }
        }

        public override void AddNameProperty(ObjectPropertyList list)
        {
            if (this.Amount > 1)
                list.Add(1050039, "{0}\t#{1}", this.Amount, 1024216); // ~1_NUMBER~ ~2_ITEMNAME~
            else
                list.Add(1024216); // pile of hides
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

    [FlipableAttribute(0x1079, 0x1078)]
    public class Hides : BaseHides, IScissorable
    {
        [Constructable]
        public Hides()
            : this(1)
        {
        }

        [Constructable]
        public Hides(int amount)
            : base(CraftResource.RegularLeather, amount)
        {
        }

        public Hides(Serial serial)
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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }
            base.ScissorHelper(from, new Leather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class SpinedHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.SpinedLeather; } }

        [Constructable]
        public SpinedHides()
            : this(1)
        {
        }

        [Constructable]
        public SpinedHides(int amount)
            : base(CraftResource.SpinedLeather, amount)
        {
        }

        public SpinedHides(Serial serial)
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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new SpinedLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class HornedHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.HornedLeather; } }

        [Constructable]
        public HornedHides()
            : this(1)
        {
        }

        [Constructable]
        public HornedHides(int amount)
            : base(CraftResource.HornedLeather, amount)
        {
        }

        public HornedHides(Serial serial)
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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }
			
            base.ScissorHelper(from, new HornedLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class BarbedHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.BarbedLeather; } }

        [Constructable]
        public BarbedHides()
            : this(1)
        {
        }

        [Constructable]
        public BarbedHides(int amount)
            : base(CraftResource.BarbedLeather, amount)
        {
        }

        public BarbedHides(Serial serial)
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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new BarbedLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class DullHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.DullLeather; } }

        [Constructable]
        public DullHides()
            : this(1)
        {
        }

        [Constructable]
        public DullHides(int amount)
            : base(CraftResource.DullLeather, amount)
        {
        }

        public DullHides(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "DullHides"; } }

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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new DullLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class ShadowHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.ShadowLeather; } }

        [Constructable]
        public ShadowHides()
            : this(1)
        {
        }

        [Constructable]
        public ShadowHides(int amount)
            : base(CraftResource.ShadowLeather, amount)
        {
        }

        public ShadowHides(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "ShadowHides"; } }

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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new ShadowLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class CopperHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.CopperLeather; } }

        [Constructable]
        public CopperHides()
            : this(1)
        {
        }

        [Constructable]
        public CopperHides(int amount)
            : base(CraftResource.CopperLeather, amount)
        {
        }

        public CopperHides(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "CopperHides"; } }

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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new CopperLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class BronzeHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.BronzeLeather; } }

        [Constructable]
        public BronzeHides()
            : this(1)
        {
        }

        [Constructable]
        public BronzeHides(int amount)
            : base(CraftResource.BronzeLeather, amount)
        {
        }

        public BronzeHides(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "BronzeHides"; } }

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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new BronzeLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class GoldenHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.GoldenLeather; } }

        [Constructable]
        public GoldenHides()
            : this(1)
        {
        }

        [Constructable]
        public GoldenHides(int amount)
            : base(CraftResource.GoldenLeather, amount)
        {
        }

        public GoldenHides(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "GoldenHides"; } }

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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new GoldenLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class SilverHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.SilverLeather; } }

        [Constructable]
        public SilverHides()
            : this(1)
        {
        }

        [Constructable]
        public SilverHides(int amount)
            : base(CraftResource.SilverLeather, amount)
        {
        }

        public SilverHides(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "SilverHides"; } }

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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new SilverLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class AgapiteHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.AgapiteLeather; } }

        [Constructable]
        public AgapiteHides()
            : this(1)
        {
        }

        [Constructable]
        public AgapiteHides(int amount)
            : base(CraftResource.AgapiteLeather, amount)
        {
        }

        public AgapiteHides(Serial serial)
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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new AgapiteLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class VeriteHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.VeriteLeather; } }

        [Constructable]
        public VeriteHides()
            : this(1)
        {
        }

        [Constructable]
        public VeriteHides(int amount)
            : base(CraftResource.VeriteLeather, amount)
        {
        }

        public VeriteHides(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "VeriteHides"; } }

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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new VeriteLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class ValoriteHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.ValoriteLeather; } }

        [Constructable]
        public ValoriteHides()
            : this(1)
        {
        }

        [Constructable]
        public ValoriteHides(int amount)
            : base(CraftResource.ValoriteLeather, amount)
        {
        }

        public ValoriteHides(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "ValoriteHides"; } }

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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new ValoriteLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class UridiumHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.UridiumLeather; } }

        [Constructable]
        public UridiumHides()
            : this(1)
        {
        }

        [Constructable]
        public UridiumHides(int amount)
            : base(CraftResource.UridiumLeather, amount)
        {
        }

        public UridiumHides(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "UridiumHides"; } }

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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new UridiumLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class AmberHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.AmberLeather; } }

        [Constructable]
        public AmberHides()
            : this(1)
        {
        }

        [Constructable]
        public AmberHides(int amount)
            : base(CraftResource.AmberLeather, amount)
        {
        }

        public AmberHides(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "AmberHides"; } }

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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new AmberLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class AmethystHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.AmethystLeather; } }

        [Constructable]
        public AmethystHides()
            : this(1)
        {
        }

        [Constructable]
        public AmethystHides(int amount)
            : base(CraftResource.AmethystLeather, amount)
        {
        }

        public AmethystHides(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "AmethystHides"; } }

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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new AmethystLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class AragoniteHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.AragoniteLeather; } }

        [Constructable]
        public AragoniteHides()
            : this(1)
        {
        }

        [Constructable]
        public AragoniteHides(int amount)
            : base(CraftResource.AragoniteLeather, amount)
        {
        }

        public AragoniteHides(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "AragoniteHides"; } }

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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new AragoniteLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class BixbiteHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.BixbiteLeather; } }

        [Constructable]
        public BixbiteHides()
            : this(1)
        {
        }

        [Constructable]
        public BixbiteHides(int amount)
            : base(CraftResource.BixbiteLeather, amount)
        {
        }

        public BixbiteHides(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "BixbiteHides"; } }

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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new BixbiteLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class BloodHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.BloodLeather; } }

        [Constructable]
        public BloodHides()
            : this(1)
        {
        }

        [Constructable]
        public BloodHides(int amount)
            : base(CraftResource.BloodLeather, amount)
        {
        }

        public BloodHides(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "BloodHides"; } }

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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new BloodLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class AmazonHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.AmazonLeather; } }

        [Constructable]
        public AmazonHides()
            : this(1)
        {
        }

        [Constructable]
        public AmazonHides(int amount)
            : base(CraftResource.AmazonLeather, amount)
        {
        }

        public AmazonHides(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "AmazonHides"; } }

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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new AmazonLeather(), 1);

            return true;
        }
    }

    [FlipableAttribute(0x1079, 0x1078)]
    public class GuardiansHides : BaseHides, IScissorable
    {
        protected override CraftResource DefaultResource { get { return CraftResource.GuardiansLeather; } }

        [Constructable]
        public GuardiansHides()
            : this(1)
        {
        }

        [Constructable]
        public GuardiansHides(int amount)
            : base(CraftResource.GuardiansLeather, amount)
        {
        }

        public GuardiansHides(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "GuardiansHides"; } }

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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (this.Deleted || !from.CanSee(this))
                return false;

            if (Core.AOS && !this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }

            base.ScissorHelper(from, new GuardiansLeather(), 1);

            return true;
        }
    }
}