using System;
using Server.Engines.Harvest;

namespace Server.Items
{
    public class GargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public GargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public GargoylesPickaxe(int uses)
            : base(0xE85 + Utility.Random(2))
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public GargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get
            {
                return 1041281;
            }
        }// a gargoyle's pickaxe
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class DullCopperGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public DullCopperGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public DullCopperGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public DullCopperGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "DullCopperGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class ShadowIronGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public ShadowIronGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public ShadowIronGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public ShadowIronGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "ShadowIronGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class CopperGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public CopperGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public CopperGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public CopperGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "CopperGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class BronzeGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public BronzeGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public BronzeGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public BronzeGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "BronzeGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class GoldenGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public GoldenGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public GoldenGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public GoldenGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "GoldenGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class SilverGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public SilverGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public SilverGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public SilverGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "SilverGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class AgapiteGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public AgapiteGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public AgapiteGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public AgapiteGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "AgapiteGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class VeriteGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public VeriteGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public VeriteGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public VeriteGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "VeriteGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class ValoriteGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public ValoriteGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public ValoriteGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public ValoriteGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "ValoriteGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class UridiumGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public UridiumGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public UridiumGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public UridiumGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "UridiumGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class TrilliumGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public TrilliumGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public TrilliumGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public TrilliumGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "TrilliumGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class TitaniumGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public TitaniumGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public TitaniumGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public TitaniumGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "TitaniumGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class PlatinumGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public PlatinumGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public PlatinumGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public PlatinumGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "PlatinumGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class ZeniteGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public ZeniteGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public ZeniteGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public ZeniteGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "ZeniteGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class NaquiniteGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public NaquiniteGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public NaquiniteGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public NaquiniteGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "NaquiniteGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class GalviniteGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public GalviniteGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public GalviniteGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public GalviniteGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "GalviniteGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class TrilamideGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public TrilamideGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public TrilamideGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public TrilamideGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "TrilamideGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class VeramideGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public VeramideGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public VeramideGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public VeramideGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "VeramideGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }

    public class ZenlamideGargoylesPickaxe : BaseAxe, IUsesRemaining
    {
        [Constructable]
        public ZenlamideGargoylesPickaxe()
            : this(90)
        {
        }

        [Constructable]
        public ZenlamideGargoylesPickaxe(int uses)
            : base(90)
        {
            this.Weight = 11.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
            this.Hue = 0x76c;
        }

        public ZenlamideGargoylesPickaxe(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "ZenlamideGargoylesPickaxe";
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return Mining.System;
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Disarm;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 50;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 13;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 35;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 25;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 1;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 15;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 35;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 60;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Slash1H;
            }
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

            if (this.Hue == 0x973 ||
                this.Hue == 0)
            {
                this.Hue = 0x76c;
            }
        }
    }
}
