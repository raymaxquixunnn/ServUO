using System;
using Server.Engines.Craft;

namespace Server.Items
{
    public class SturdySkillet : BaseTool
    {
        [Constructable]
        public SturdySkillet()
            : this(180)
        {
        }

        [Constructable]
        public SturdySkillet(int uses)
            : base(uses, 0x97F)
        {
            this.Weight = 1.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
        }

        public SturdySkillet(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName { get { return "sturdy Skillet"; } }

        public override CraftSystem CraftSystem
        {
            get
            {
                return DefCooking.CraftSystem;
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