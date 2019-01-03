using System;

namespace Server.Items
{
    public class L10ExplosionPotion : BaseExplosionPotion
    {
        [Constructable]
        public L10ExplosionPotion()
            : base(PotionEffect.ExplosionLesser)
        {
        }

        public L10ExplosionPotion(Serial serial)
            : base(serial)
        {
        }

        public override int ExplosionRange
        {
            get
            {
                return 6;
            }
        }
        public override int MinDamage
        {
            get
            {
                return 50;
            }
        }
        public override int MaxDamage
        {
            get
            {
                return 100;
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