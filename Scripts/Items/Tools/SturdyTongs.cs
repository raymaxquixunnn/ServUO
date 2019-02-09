using System;
using Server.Engines.Craft;

namespace Server.Items
{
    [FlipableAttribute(0xfbb, 0xfbc)]
    public class SturdyTongs : BaseTool
    {
        [Constructable]
        public SturdyTongs()
            : this(180)
        {
        }

        [Constructable]
        public SturdyTongs(int uses)
            : base(uses, 0xFBB)
        {
            this.Weight = 2.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
        }

        public override string DefaultName { get { return "sturdy Tongs"; } }

        public SturdyTongs(Serial serial)
            : base(serial)
        {
        }

        public override CraftSystem CraftSystem
        {
            get
            {
                return DefBlacksmithy.CraftSystem;
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