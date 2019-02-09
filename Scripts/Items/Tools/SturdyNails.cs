using System;
using Server.Engines.Craft;

namespace Server.Items
{
    [Flipable(0x102E, 0x102F)]
    public class SturdyNails : BaseTool
    {
        [Constructable]
        public SturdyNails()
            : this(180)
        {
        }

        [Constructable]
        public SturdyNails(int uses)
            : base(uses, 0x102C)
        {
            this.Weight = 2.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
        }

        public SturdyNails(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName { get { return "sturdy Nails"; } }

        public override CraftSystem CraftSystem
        {
            get
            {
                return DefCarpentry.CraftSystem;
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