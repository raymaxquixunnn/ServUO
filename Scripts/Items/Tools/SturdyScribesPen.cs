using System;
using Server.Engines.Craft;

namespace Server.Items
{
    [FlipableAttribute(0x0FBF, 0x0FC0)]
    public class SturdyScribesPen : BaseTool
    {
        [Constructable]
        public SturdyScribesPen()
            : this(180)
        {
        }

        [Constructable]
        public SturdyScribesPen(int uses)
            : base(uses, 0x0FBF)
        {
            this.Weight = 2.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
        }

        public override string DefaultName { get { return "sturdy ScribesPen"; } }

        public SturdyScribesPen(Serial serial)
            : base(serial)
        {
        }

        public override CraftSystem CraftSystem
        {
            get
            {
                return DefInscription.CraftSystem;
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