using System;

namespace Server.Items
{
    public class N10ExplosionPotion : BaseExplosionPotion
    {
        [Constructable]
        public N10ExplosionPotion()
            : base(PotionEffect.Explosion)
        {
        }

        public N10ExplosionPotion(Serial serial)
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
                return 100;
            }
        }
        public override int MaxDamage
        {
            get
            {
                return 200;
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