using System;

namespace Server.Items
{
    public class G10AgilityPotion : BaseAgilityPotion
    {
        [Constructable]
        public G10AgilityPotion()
            : base(PotionEffect.AgilityGreater)
        {
        }

        public G10AgilityPotion(Serial serial)
            : base(serial)
        {
        }

        public override int DexOffset
        {
            get
            {
                return 20;
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