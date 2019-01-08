using System;

namespace Server.Items
{
    public class N10AgilityPotion : BaseAgilityPotion
    {
        [Constructable]
        public N10AgilityPotion()
            : base(PotionEffect.Agility)
        {
        }

        public N10AgilityPotion(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "N10AgilityPotion"; } }

        public override int DexOffset
        {
            get
            {
                return 10;
            }
        }
        public override TimeSpan Duration
        {
            get
            {
                return TimeSpan.FromMinutes(20.0);
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