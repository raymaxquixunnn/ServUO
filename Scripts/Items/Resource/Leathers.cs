using System;

namespace Server.Items
{
    public abstract class BaseLeather : Item, ICommodity
    {
        protected virtual CraftResource DefaultResource { get { return CraftResource.RegularLeather; } }

        private CraftResource m_Resource;
        public BaseLeather(CraftResource resource)
            : this(resource, 1)
        {
        }

        public BaseLeather(CraftResource resource, int amount)
            : base(0x1081)
        {
            this.Stackable = true;
            this.Weight = 1.0;
            this.Amount = amount;
            this.Hue = CraftResources.GetHue(resource);

            this.m_Resource = resource;
        }

        public BaseLeather(Serial serial)
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
                if (this.m_Resource >= CraftResource.SpinedLeather && this.m_Resource <= CraftResource.AmazonLeather)
                    return 1049684 + (int)(this.m_Resource - CraftResource.SpinedLeather);

                return 1047022;
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
                list.Add(1050039, "{0}\t#{1}", this.Amount, 1024199); // ~1_NUMBER~ ~2_ITEMNAME~

            else
                list.Add(1024199); // cut leather
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

    [FlipableAttribute(0x1081, 0x1082)]
    public class Leather : BaseLeather
    {
        [Constructable]
        public Leather()
            : this(1)
        {
        }

        [Constructable]
        public Leather(int amount)
            : base(CraftResource.RegularLeather, amount)
        {
        }

        public Leather(Serial serial)
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

    [FlipableAttribute(0x1081, 0x1082)]
    public class SpinedLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.SpinedLeather; } }

        [Constructable]
        public SpinedLeather()
            : this(1)
        {
        }

        [Constructable]
        public SpinedLeather(int amount)
            : base(CraftResource.SpinedLeather, amount)
        {
        }

        public SpinedLeather(Serial serial)
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

    [FlipableAttribute(0x1081, 0x1082)]
    public class HornedLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.HornedLeather; } }

        [Constructable]
        public HornedLeather()
            : this(1)
        {
        }

        [Constructable]
        public HornedLeather(int amount)
            : base(CraftResource.HornedLeather, amount)
        {
        }

        public HornedLeather(Serial serial)
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

    [FlipableAttribute(0x1081, 0x1082)]
    public class BarbedLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.BarbedLeather; } }

        [Constructable]
        public BarbedLeather()
            : this(1)
        {
        }

        [Constructable]
        public BarbedLeather(int amount)
            : base(CraftResource.BarbedLeather, amount)
        {
        }

        public BarbedLeather(Serial serial)
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

    [FlipableAttribute(0x1081, 0x1082)]
    public class DullLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.DullLeather; } }

        [Constructable]
        public DullLeather()
            : this(1)
        {
        }

        [Constructable]
        public DullLeather(int amount)
            : base(CraftResource.DullLeather, amount)
        {
        }

        public DullLeather(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "DullLeather"; } }

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

    [FlipableAttribute(0x1081, 0x1082)]
    public class ShadowLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.ShadowLeather; } }

        [Constructable]
        public ShadowLeather()
            : this(1)
        {
        }

        [Constructable]
        public ShadowLeather(int amount)
            : base(CraftResource.ShadowLeather, amount)
        {
        }

        public ShadowLeather(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "ShadowLeather"; } }

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

    [FlipableAttribute(0x1081, 0x1082)]
    public class CopperLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.CopperLeather; } }

        [Constructable]
        public CopperLeather()
            : this(1)
        {
        }

        [Constructable]
        public CopperLeather(int amount)
            : base(CraftResource.CopperLeather, amount)
        {
        }

        public CopperLeather(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "CopperLeather"; } }

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

    [FlipableAttribute(0x1081, 0x1082)]
    public class BronzeLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.BronzeLeather; } }

        [Constructable]
        public BronzeLeather()
            : this(1)
        {
        }

        [Constructable]
        public BronzeLeather(int amount)
            : base(CraftResource.BronzeLeather, amount)
        {
        }

        public BronzeLeather(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "BronzeLeather"; } }

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

    [FlipableAttribute(0x1081, 0x1082)]
    public class GoldenLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.GoldenLeather; } }

        [Constructable]
        public GoldenLeather()
            : this(1)
        {
        }

        [Constructable]
        public GoldenLeather(int amount)
            : base(CraftResource.GoldenLeather, amount)
        {
        }

        public GoldenLeather(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "GoldenLeather"; } }

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

    [FlipableAttribute(0x1081, 0x1082)]
    public class SilverLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.SilverLeather; } }

        [Constructable]
        public SilverLeather()
            : this(1)
        {
        }

        [Constructable]
        public SilverLeather(int amount)
            : base(CraftResource.SilverLeather, amount)
        {
        }

        public SilverLeather(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "SilverLeather"; } }

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

    [FlipableAttribute(0x1081, 0x1082)]
    public class AgapiteLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.AgapiteLeather; } }

        [Constructable]
        public AgapiteLeather()
            : this(1)
        {
        }

        [Constructable]
        public AgapiteLeather(int amount)
            : base(CraftResource.AgapiteLeather, amount)
        {
        }

        public AgapiteLeather(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "AgapiteLeather"; } }

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

    [FlipableAttribute(0x1081, 0x1082)]
    public class VeriteLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.VeriteLeather; } }

        [Constructable]
        public VeriteLeather()
            : this(1)
        {
        }

        [Constructable]
        public VeriteLeather(int amount)
            : base(CraftResource.VeriteLeather, amount)
        {
        }

        public VeriteLeather(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "VeriteLeather"; } }

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

    [FlipableAttribute(0x1081, 0x1082)]
    public class ValoriteLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.ValoriteLeather; } }

        [Constructable]
        public ValoriteLeather()
            : this(1)
        {
        }

        [Constructable]
        public ValoriteLeather(int amount)
            : base(CraftResource.ValoriteLeather, amount)
        {
        }

        public ValoriteLeather(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "ValoriteLeather"; } }

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

    [FlipableAttribute(0x1081, 0x1082)]
    public class UridiumLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.UridiumLeather; } }

        [Constructable]
        public UridiumLeather()
            : this(1)
        {
        }

        [Constructable]
        public UridiumLeather(int amount)
            : base(CraftResource.UridiumLeather, amount)
        {
        }

        public UridiumLeather(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "UridiumLeather"; } }

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

    [FlipableAttribute(0x1081, 0x1082)]
    public class AmberLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.AmberLeather; } }

        [Constructable]
        public AmberLeather()
            : this(1)
        {
        }

        [Constructable]
        public AmberLeather(int amount)
            : base(CraftResource.AmberLeather, amount)
        {
        }

        public AmberLeather(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "AmberLeather"; } }

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

    [FlipableAttribute(0x1081, 0x1082)]
    public class AmethystLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.AmethystLeather; } }

        [Constructable]
        public AmethystLeather()
            : this(1)
        {
        }

        [Constructable]
        public AmethystLeather(int amount)
            : base(CraftResource.AmethystLeather, amount)
        {
        }

        public AmethystLeather(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "AmethystLeather"; } }

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

    [FlipableAttribute(0x1081, 0x1082)]
    public class AragoniteLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.AragoniteLeather; } }

        [Constructable]
        public AragoniteLeather()
            : this(1)
        {
        }

        [Constructable]
        public AragoniteLeather(int amount)
            : base(CraftResource.AragoniteLeather, amount)
        {
        }

        public AragoniteLeather(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "AragoniteLeather"; } }

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

    [FlipableAttribute(0x1081, 0x1082)]
    public class BixbiteLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.BixbiteLeather; } }

        [Constructable]
        public BixbiteLeather()
            : this(1)
        {
        }

        [Constructable]
        public BixbiteLeather(int amount)
            : base(CraftResource.BixbiteLeather, amount)
        {
        }

        public BixbiteLeather(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "BixbiteLeather"; } }

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

    [FlipableAttribute(0x1081, 0x1082)]
    public class BloodLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.BloodLeather; } }

        [Constructable]
        public BloodLeather()
            : this(1)
        {
        }

        [Constructable]
        public BloodLeather(int amount)
            : base(CraftResource.BloodLeather, amount)
        {
        }

        public BloodLeather(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "BloodLeather"; } }

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

    [FlipableAttribute(0x1081, 0x1082)]
    public class AmazonLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.AmazonLeather; } }

        [Constructable]
        public AmazonLeather()
            : this(1)
        {
        }

        [Constructable]
        public AmazonLeather(int amount)
            : base(CraftResource.AmazonLeather, amount)
        {
        }

        public AmazonLeather(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "AmazonLeather"; } }

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

    [FlipableAttribute(0x1081, 0x1082)]
    public class GuardiansLeather : BaseLeather
    {
        protected override CraftResource DefaultResource { get { return CraftResource.GuardiansLeather; } }

        [Constructable]
        public GuardiansLeather()
            : this(1)
        {
        }

        [Constructable]
        public GuardiansLeather(int amount)
            : base(CraftResource.GuardiansLeather, amount)
        {
        }

        public GuardiansLeather(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "GuardiansLeather"; } }

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