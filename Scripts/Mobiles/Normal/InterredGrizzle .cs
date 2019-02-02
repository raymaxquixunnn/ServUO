using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("an interred grizzle corpse")]
    public class InterredGrizzle : BaseCreature
    {
        [Constructable]
        public InterredGrizzle()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
                Name = "an interred grizzle";
                Body = 259;

                SetStr(451, 500);
                SetDex(201, 250);
                SetInt(801, 850);

                SetHits(1500);
                SetStam(150);

                SetDamage(16, 19);

                SetDamageType(ResistanceType.Physical, 30);
                SetDamageType(ResistanceType.Fire, 70);

                SetResistance(ResistanceType.Physical, 35, 55);
                SetResistance(ResistanceType.Fire, 20, 65);
                SetResistance(ResistanceType.Cold, 55, 80);
                SetResistance(ResistanceType.Poison, 20, 35);
                SetResistance(ResistanceType.Energy, 60, 80);

                SetSkill(SkillName.Meditation, 77.7, 84.0);
                SetSkill(SkillName.EvalInt, 72.2, 79.6);
                SetSkill(SkillName.Magery, 83.7, 89.6);
                SetSkill(SkillName.Poisoning, 0);
                SetSkill(SkillName.Anatomy, 0);
                SetSkill(SkillName.MagicResist, 80.2, 87.3);
                SetSkill(SkillName.Tactics, 104.5, 105.1);
                SetSkill(SkillName.Wrestling, 105.1, 109.4);

                Fame = 3700;  // Guessed
                Karma = -3700;  // Guessed

            for (int i = 0; i < Utility.RandomMinMax(0, 1); i++)
            {
                    PackItem(Loot.RandomScroll(0, Loot.ArcanistScrollTypes.Length, SpellbookType.Arcanist));
            }
        }
        public override bool CanBeParagon { get { return false; } }
        /*
        public override bool OnBeforeDeath()
        {
        SpillAcid( 1, 4, 10, 6, 10 );

        return base.OnBeforeDeath();
        }
        */

        public override int TreasureMapLevel
        {
            get
            {
                return 4;
            }
        }

        public InterredGrizzle(Serial serial)
            : base(serial)
        {
        }

        public override void GenerateLoot() // -- Need to verify
        {
                AddLoot(LootPack.FilthyRich);
        }

        public override void OnDamage(int amount, Mobile from, bool willKill)
        {
            if (Utility.RandomDouble() < 0.3)
                    DropOoze();

            base.OnDamage(amount, from, willKill);
        }

        public virtual void DropOoze()
        {
            int amount = Utility.RandomMinMax(1, 3);

            for (int i = 0; i < amount; i++)
            {
                Item ooze = new InfernalOoze(false, Utility.RandomMinMax(6, 10));
                Point3D p = new Point3D(    Location);

                for (int j = 0; j < 5; j++)
                {
                    p =     GetSpawnPosition(2);
                    bool found = false;

                    foreach (Item item in     Map.GetItemsInRange(p, 0))
                        if (item is InfernalOoze)
                        {
                            found = true;
                            break;
                        }

                    if (!found)
                        break;
                }

                ooze.MoveToWorld(p,     Map);
            }

            if (    Combatant is Mobile)
            {
                ((Mobile)    Combatant).SendLocalizedMessage(1070820); // The creature spills a pool of acidic slime!
            }
        }

        public override int GetAngerSound()
        {
            return 0x581;
        }

        public override int GetIdleSound()
        {
            return 0x582;
        }

        public override int GetAttackSound()
        {
            return 0x580;
        }

        public override int GetHurtSound()
        {
            return 0x583;
        }

        public override int GetDeathSound()
        {
            return 0x584;
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