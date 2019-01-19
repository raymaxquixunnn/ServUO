using System;
using Server.Engines.Harvest;
using Server.Targeting;

namespace Server.Items
{
    public class ProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public ProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public ProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 1))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly ProspectorsTool m_Tool;
            public InternalTarget(ProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class DullCopperProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public DullCopperProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public DullCopperProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 2))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly DullCopperProspectorsTool m_Tool;
            public InternalTarget(DullCopperProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class ShadowProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public ShadowProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public ShadowProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 3))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly ShadowProspectorsTool m_Tool;
            public InternalTarget(ShadowProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class CopperProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public CopperProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public CopperProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 4))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly CopperProspectorsTool m_Tool;
            public InternalTarget(CopperProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class BronzeProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public BronzeProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public BronzeProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 5))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly BronzeProspectorsTool m_Tool;
            public InternalTarget(BronzeProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class GoldProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public GoldProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public GoldProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 6))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly GoldProspectorsTool m_Tool;
            public InternalTarget(GoldProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class SilverProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public SilverProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public SilverProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 7))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly SilverProspectorsTool m_Tool;
            public InternalTarget(SilverProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class AgapiteProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public AgapiteProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public AgapiteProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 8))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly AgapiteProspectorsTool m_Tool;
            public InternalTarget(AgapiteProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class VeriteProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public VeriteProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public VeriteProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 9))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly VeriteProspectorsTool m_Tool;
            public InternalTarget(VeriteProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class ValoriteProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public ValoriteProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public ValoriteProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 10))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly ValoriteProspectorsTool m_Tool;
            public InternalTarget(ValoriteProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class UridiumProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public UridiumProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public UridiumProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 11))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly UridiumProspectorsTool m_Tool;
            public InternalTarget(UridiumProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class TrilliumProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public TrilliumProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public TrilliumProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 12))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly TrilliumProspectorsTool m_Tool;
            public InternalTarget(TrilliumProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class TitaniumProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public TitaniumProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public TitaniumProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 13))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly TitaniumProspectorsTool m_Tool;
            public InternalTarget(TitaniumProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class PlatinumProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public PlatinumProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public PlatinumProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 14))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly PlatinumProspectorsTool m_Tool;
            public InternalTarget(PlatinumProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class ZeniteProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public ZeniteProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public ZeniteProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 15))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly ZeniteProspectorsTool m_Tool;
            public InternalTarget(ZeniteProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class NaquiniteProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public NaquiniteProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public NaquiniteProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 16))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly NaquiniteProspectorsTool m_Tool;
            public InternalTarget(NaquiniteProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class GalviniteProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public GalviniteProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public GalviniteProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 17))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly GalviniteProspectorsTool m_Tool;
            public InternalTarget(GalviniteProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class TrilamideProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public TrilamideProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public TrilamideProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 18))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly TrilamideProspectorsTool m_Tool;
            public InternalTarget(TrilamideProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class VeramideProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public VeramideProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public VeramideProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 19))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly VeramideProspectorsTool m_Tool;
            public InternalTarget(VeramideProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}

namespace Server.Items
{
    public class ZenlamideProspectorsTool : BaseBashing
    {
        public override int LabelNumber { get { return 1049065; } } // prospector's tool

        [Constructable]
        public ZenlamideProspectorsTool()
            : base(0xFB4)
        {
            Weight = 10.0;
            UsesRemaining = 50;
            ShowUsesRemaining = true;
        }

        public ZenlamideProspectorsTool(Serial serial)
            : base(serial)
        {
        }        

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ShadowStrike; } }
        public override int AosStrengthReq { get { return 40; } }
        public override int AosMinDamage { get { return 13; } }
        public override int AosMaxDamage { get { return 15; } }
        public override int AosSpeed { get { return 33; } }
        public override float MlSpeed { get { return 3.25f; } }
        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 6; } }
        public override int OldMaxDamage { get { return 8; } }
        public override int OldSpeed { get { return 33; } }
        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 60; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || Parent == from)
                from.Target = new InternalTarget(this);
            else
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
        }

        public void Prospect(Mobile from, object toProspect)
        {
            if (!IsChildOf(from.Backpack) && Parent != from)
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Mining.System;

            int tileID;
            Map map;
            Point3D loc;

            if (!system.GetHarvestDetails(from, this, toProspect, out tileID, out map, out loc))
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition(tileID);

            if (def == null || def.Veins.Length <= 1)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);

            if (bank == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }

            HarvestVein vein = bank.Vein, defaultVein = bank.DefaultVein;

            if (vein == null || defaultVein == null)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
                return;
            }
            else if (vein != defaultVein)
            {
                from.SendLocalizedMessage(1049049); // That ore looks to be prospected already.
                return;
            }

            int veinIndex = Array.IndexOf(def.Veins, vein);

            if (veinIndex < 0)
            {
                from.SendLocalizedMessage(1049048); // You cannot use your prospector tool on that.
            }
            else if (veinIndex >= (def.Veins.Length - 20))
            {
                from.SendLocalizedMessage(1049061); // You cannot improve Guardians ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --UsesRemaining;

                if (UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            switch ( version )
            {
                case 2:
                    break;
                case 1:
                    {
                        UsesRemaining = reader.ReadInt();
                        break;
                    }
            }
        }

        private class InternalTarget : Target
        {
            private readonly ZenlamideProspectorsTool m_Tool;
            public InternalTarget(ZenlamideProspectorsTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                m_Tool.Prospect(from, targeted);
            }
        }
    }
}
