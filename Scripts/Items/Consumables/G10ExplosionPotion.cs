using System;

namespace Server.Items
{
    public class G10ExplosionPotion : BaseExplosionPotion
    {
        [Constructable]
        public G10ExplosionPotion()
            : base(PotionEffect.ExplosionGreater)
        {
        }

        public G10ExplosionPotion(Serial serial)
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
                return Core.AOS ? 200 : 150;
            }
        }
        public override int MaxDamage
        {
            get
            {
                return Core.AOS ? 400 : 300;
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