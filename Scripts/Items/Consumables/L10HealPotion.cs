using System;

namespace Server.Items
{
    public class L10HealPotion : BaseHealPotion
    {
        [Constructable]
        public L10HealPotion()
            : base(PotionEffect.HealLesser)
        {
        }

        public L10HealPotion(Serial serial)
            : base(serial)
        {
        }

        public override int MinHeal
        {
            get
            {
                return (Core.AOS ? 60 : 30);
            }
        }
        public override int MaxHeal
        {
            get
            {
                return (Core.AOS ? 80 : 100);
            }
        }
        public override double Delay
        {
            get
            {
                return (Core.AOS ? 30.0 : 100.0);
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