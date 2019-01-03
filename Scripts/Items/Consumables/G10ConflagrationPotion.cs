using System;

namespace Server.Items
{
    public class G10ConflagrationPotion : BaseConflagrationPotion
    {
        [Constructable]
        public G10ConflagrationPotion()
            : base(PotionEffect.ConflagrationGreater)
        {
        }

        public G10ConflagrationPotion(Serial serial)
            : base(serial)
        {
        }

        public override int MinDamage
        {
            get
            {
                return 40;
            }
        }
        public override int MaxDamage
        {
            get
            {
                return 80;
            }
        }
        public override int LabelNumber
        {
            get
            {
                return 1072098;
            }
        }// a Greater Conflagration potion
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