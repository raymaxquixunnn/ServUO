using System;

namespace Server.Items
{
    public class N10HealPotion : BaseHealPotion
    {
        [Constructable]
        public N10HealPotion()
            : base(PotionEffect.Heal)
        {
        }

        public N10HealPotion(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "N10HealPotion"; } }

        public override int MinHeal
        {
            get
            {
                return (Core.AOS ? 130 : 60);
            }
        }
        public override int MaxHeal
        {
            get
            {
                return (Core.AOS ? 160 : 200);
            }
        }
        public override double Delay
        {
            get
            {
                return (Core.AOS ? 80.0 : 100.0);
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
        }
    }
}