using System;

namespace Server.Items
{
    public class DungeonNightSightPotion : BasePotion
    {
        [Constructable]
        public DungeonNightSightPotion()
            : base(0xF06, PotionEffect.Nightsight)
        {
        }

        public DungeonNightSightPotion(Serial serial)
            : base(serial)
        {
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

        public override void Drink(Mobile from)
        {
            if (from.BeginAction(typeof(LightCycle)))
            {
                new LightCycle.DungeonNightSightTimer(from).Start();
                from.LightLevel = LightCycle.DayLevel;

                from.FixedParticles(0x376A, 9, 32, 5007, EffectLayer.Waist);
                from.PlaySound(0x1E3);

                PlayDrinkEffect(from);
                Consume();
            }
            else
            {
                from.SendMessage("You already have nightsight.");
            }
        }
    }
}
