using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("an earth elemental corpse")]
    public class EnragedEarthElemental : BaseCreature
    {
        [Constructable]
        public EnragedEarthElemental()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "Enraged Earth Elemental";
            Body = 14;
            BaseSoundID = 268;
            Hue = 442;

            SetStr(147, 155);
            SetDex(78, 90);
            SetInt(94, 115);

            SetHits(500, 550);

            SetDamage(9, 16);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 55, 65);
            SetResistance(ResistanceType.Fire, 20, 30);
            SetResistance(ResistanceType.Cold, 20, 30);
            SetResistance(ResistanceType.Poison, 45, 55);
            SetResistance(ResistanceType.Energy, 25, 35);

            SetSkill(SkillName.MagicResist, 100.0);
            SetSkill(SkillName.Tactics, 100.0);
            SetSkill(SkillName.Wrestling, 120.0);
            SetSkill(SkillName.Parry, 120.0);

            Fame = 3500;
            Karma = -3500;

            VirtualArmor = 34;
            ControlSlots = 2;

            PackItem(new FertileDirt(Utility.RandomMinMax(1, 4)));
            PackItem(new MandrakeRoot());
			
            Item ore = new IronOre(5);
            ore.ItemID = 0x19B7;
            PackItem(ore);
        }

        public EnragedEarthElemental(Serial serial)
            : base(serial)
        {
        }

        public override double DispelDifficulty
        {
            get
            {
                return 117.5;
            }
        }
        public override double DispelFocus
        {
            get
            {
                return 45.0;
            }
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
        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
            AddLoot(LootPack.Meager);
            AddLoot(LootPack.Gems);
        }

        public override void OnDeath(Container c)
        {
            base.OnDeath(c);

            if (Utility.RandomDouble() < 0.03)
                c.DropItem(new LuckyCoin());
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