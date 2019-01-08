using System;

namespace Server.Items
{
    public class N10ConflagrationPotion : BaseConflagrationPotion
    {
        [Constructable]
        public N10ConflagrationPotion()
            : base(PotionEffect.Conflagration)
        {
        }

        public N10ConflagrationPotion(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "N10ConflagrationPotion"; } }

        public override int MinDamage
        {
            get
            {
                return 20;
            }
        }
        public override int MaxDamage
        {
            get
            {
                return 40;
            }
        }
        public override int LabelNumber
        {
            get
            {
                return 1072095;
            }
        }// a Conflagration potion
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