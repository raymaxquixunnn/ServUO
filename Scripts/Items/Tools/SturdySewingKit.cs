using System;
using Server.Engines.Craft;

namespace Server.Items
{
    public class SturdySewingKit : BaseTool
    {
        [Constructable]
        public SturdySewingKit()
            : this(180)
        {
            this.Weight = 2.0;
        }

        public SturdySewingKit(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName { get { return "sturdy sewing kit"; } }

        public override CraftSystem CraftSystem
        {
            get
            {
                return DefTailoring.CraftSystem;
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