using System;
using Server.Targeting;
using Server.Engines.Harvest;

namespace Server.Items
{

    public class LumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public LumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public LumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 1];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly LumberjackingTool m_Tool;
            public InternalTarget(LumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class OakLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public OakLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public OakLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 2];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly OakLumberjackingTool m_Tool;
            public InternalTarget(OakLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class AshLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public AshLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public AshLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 3];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly AshLumberjackingTool m_Tool;
            public InternalTarget(AshLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class YewLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public YewLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public YewLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 4];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly YewLumberjackingTool m_Tool;
            public InternalTarget(YewLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class HeartLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public HeartLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public HeartLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 5];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly HeartLumberjackingTool m_Tool;
            public InternalTarget(HeartLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class BloodLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public BloodLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public BloodLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 6];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly BloodLumberjackingTool m_Tool;
            public InternalTarget(BloodLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class FrostLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public FrostLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public FrostLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 7];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly FrostLumberjackingTool m_Tool;
            public InternalTarget(FrostLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class CalciteLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public CalciteLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public CalciteLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 8];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly CalciteLumberjackingTool m_Tool;
            public InternalTarget(CalciteLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class GoldLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public GoldLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public GoldLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 9];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly GoldLumberjackingTool m_Tool;
            public InternalTarget(GoldLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class LabradoriteLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public LabradoriteLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public LabradoriteLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 10];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly LabradoriteLumberjackingTool m_Tool;
            public InternalTarget(LabradoriteLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class MoldaviteLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public MoldaviteLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public MoldaviteLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 11];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly MoldaviteLumberjackingTool m_Tool;
            public InternalTarget(MoldaviteLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class MorganiteLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public MorganiteLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public MorganiteLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 12];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly MorganiteLumberjackingTool m_Tool;
            public InternalTarget(MorganiteLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class QuartzLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public QuartzLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public QuartzLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 13];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly QuartzLumberjackingTool m_Tool;
            public InternalTarget(QuartzLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class RhodoniteLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public RhodoniteLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public RhodoniteLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 14];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly RhodoniteLumberjackingTool m_Tool;
            public InternalTarget(RhodoniteLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class RubyLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public RubyLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public RubyLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 15];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly RubyLumberjackingTool m_Tool;
            public InternalTarget(RubyLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class SapphireLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public SapphireLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public SapphireLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 16];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly SapphireLumberjackingTool m_Tool;
            public InternalTarget(SapphireLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class SugiliteLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public SugiliteLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public SugiliteLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 17];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly SugiliteLumberjackingTool m_Tool;
            public InternalTarget(SugiliteLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class TanzaniteLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public TanzaniteLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public TanzaniteLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 18];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly TanzaniteLumberjackingTool m_Tool;
            public InternalTarget(TanzaniteLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class TurquoiseLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public TurquoiseLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public TurquoiseLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 19];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly TurquoiseLumberjackingTool m_Tool;
            public InternalTarget(TurquoiseLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}

namespace Server.Items
{

    public class VarisiteLumberjackingTool : BaseAxe
    {
        public override int LabelNumber{ get{ return 1049065; } } // prospector's tool

        [Constructable]
        public VarisiteLumberjackingTool() : base( 0xF44 )
        {
            Weight = 9.0;
            ShowUsesRemaining = true;
            UsesRemaining = 50;
        }

        public VarisiteLumberjackingTool( Serial serial )
            : base( serial )
        {
        }

        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int AosStrengthReq{ get{ return 20; } }
        public override int AosMinDamage{ get{ return 13; } }
        public override int AosMaxDamage{ get{ return 15; } }
        public override int AosSpeed{ get{ return 41; } }
        public override int OldStrengthReq{ get{ return 15; } }
        public override int OldMinDamage{ get{ return 2; } }
        public override int OldMaxDamage{ get{ return 17; } }
        public override int OldSpeed{ get{ return 40; } }
        public override int InitMinHits{ get{ return 31; } }
        public override int InitMaxHits{ get{ return 80; } }

        public override void OnDoubleClick( Mobile from )
        {
            if ( IsChildOf( from.Backpack ) || Parent == from )
                from.Target = new InternalTarget( this );
            else
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
        }

        public void Prospect( Mobile from, object toProspect )
        {
            if ( !IsChildOf( from.Backpack ) && Parent != from )
            {
                from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                return;
            }

            HarvestSystem system = Lumberjacking.System;

            int tileID;
            Map map;
            Point3D loc;

            if ( !system.GetHarvestDetails( from, this, toProspect, out tileID, out map, out loc ) )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestDefinition def = system.GetDefinition( tileID );

            if ( def == null || def.Veins.Length <= 1 )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
                return;
            }

            HarvestBank bank = def.GetBank( map, loc.X, loc.Y );

            if ( bank == null )
            {
                from.SendLocalizedMessage( 1049048 ); // You cannot use your prospector tool on that.
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
                from.SendLocalizedMessage(1049061); // You cannot improve valorite ore through prospecting.
            }
            else
            {
                bank.Vein = def.Veins[veinIndex + 20];
                from.SendLocalizedMessage(1049050 + veinIndex);

                --this.UsesRemaining;

                if (this.UsesRemaining <= 0)
                {
                    from.SendLocalizedMessage(1049062); // You have used up your prospector's tool.
                    this.Delete();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize(writer);
            writer.Write((int)2); // version
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
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
            private readonly VarisiteLumberjackingTool m_Tool;
            public InternalTarget(VarisiteLumberjackingTool tool)
                : base(2, true, TargetFlags.None)
            {
                m_Tool = tool;
            }

            protected override void OnTarget( Mobile from, object targeted )
            {
                m_Tool.Prospect( from, targeted );
            }
        }
    }
}
