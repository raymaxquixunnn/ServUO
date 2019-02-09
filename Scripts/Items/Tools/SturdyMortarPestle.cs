using System;
using Server.Engines.Craft;

namespace Server.Items
{
    public class SturdyMortarPestle : BaseTool
    {
        [Constructable]
        public SturdyMortarPestle()
            : this(180)
        {
        }

        [Constructable]
        public SturdyMortarPestle(int uses)
            : base(uses, 0xE9B)
        {
            this.Weight = 2.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
        }

        public override string DefaultName { get { return "sturdy mortar and pestle"; } }

        public SturdyMortarPestle(Serial serial)
            : base(serial)
        {
        }

        public override CraftSystem CraftSystem
        {
            get
            {
                return DefAlchemy.CraftSystem;
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