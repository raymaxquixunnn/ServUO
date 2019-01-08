using System;

namespace Server.Items
{
    public class G10HealPotion : BaseHealPotion
    {
        [Constructable]
        public G10HealPotion()
            : base(PotionEffect.HealGreater)
        {
        }

        public G10HealPotion(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "G10HealPotion"; } }

        public override int MinHeal
        {
            get
            {
                return (Core.AOS ? 200 : 90);
            }
        }
        public override int MaxHeal
        {
            get
            {
                return (Core.AOS ? 250 : 300);
            }
        }
        public override double Delay
        {
            get
            {
                return 100.0;
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