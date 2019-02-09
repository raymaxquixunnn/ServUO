using System;
using Server.Engines.Craft;

namespace Server.Items
{
    [FlipableAttribute(0x1022, 0x1023)]
    public class SturdyFletcherTools : BaseTool
    {
        [Constructable]
        public SturdyFletcherTools()
            : this(180)
        {
        }

        [Constructable]
        public SturdyFletcherTools(int uses)
            : base(uses, 0x1022)
        {
            this.Weight = 2.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
        }

        public SturdyFletcherTools(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName { get { return "sturdy fletchertools"; } }

        public override CraftSystem CraftSystem
        {
            get
            {
                return DefBowFletching.CraftSystem;
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