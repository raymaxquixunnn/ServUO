using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a snow elemental corpse")]
    public class SnowElemental : BaseCreature
    {
        [Constructable]
        public SnowElemental()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a snow elemental";
            Body = 163;
            BaseSoundID = 263;

            SetStr(326, 355);
            SetDex(166, 185);
            SetInt(71, 95);

            SetHits(196, 213);

            SetDamage(11, 17);

            SetDamageType(ResistanceType.Physical, 20);
            SetDamageType(ResistanceType.Cold, 80);

            SetResistance(ResistanceType.Physical, 45, 55);
            SetResistance(ResistanceType.Fire, 10, 15);
            SetResistance(ResistanceType.Cold, 60, 70);
            SetResistance(ResistanceType.Poison, 25, 35);
            SetResistance(ResistanceType.Energy, 25, 35);

            SetSkill(SkillName.MagicResist, 50.1, 65.0);
            SetSkill(SkillName.Tactics, 80.1, 100.0);
            SetSkill(SkillName.Wrestling, 80.1, 100.0);

            Fame = 5000;
            Karma = -5000;

            VirtualArmor = 50;

            PackItem(new BlackPearl(3));
            Item ore = new IronOre(3);
            ore.ItemID = 0x19B8;
            PackItem(ore);
        }

        public SnowElemental(Serial serial)
            : base(serial)
        {
        }

        public override bool BleedImmune
        {
            get
            {
                return true;
            }
        }
        public override int TreasureMapLevel
        {
            get
            {
                return 2;
            }
        }

        public override bool HasAura { get { return true; } }
        public override int AuraBaseDamage { get { return 15; } }
        public override int AuraRange { get { return 2; } }
        public override int AuraFireDamage { get { return 0; } }
        public override int AuraColdDamage { get { return 100; } }

        public override void AuraEffect(Mobile m)
        {
            m.SendLocalizedMessage(1008111, false, Name); //  : The intense cold is damaging you!
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}