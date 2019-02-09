using System;
using Server.Engines.Craft;

namespace Server.Items
{
    [FlipableAttribute(0x0FBF, 0x0FC0)]
    public class SturdyMapmakersPen : BaseTool
    {
        [Constructable]
        public SturdyMapmakersPen()
            : this(180)
        {
        }

        [Constructable]
        public SturdyMapmakersPen(int uses)
            : base(uses, 0x0FBF)
        {
            this.Weight = 2.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
        }

        public override string DefaultName { get { return "sturdy Mapmakers Pen"; } }

        public SturdyMapmakersPen(Serial serial)
            : base(serial)
        {
        }

        public override CraftSystem CraftSystem
        {
            get
            {
                return DefCartography.CraftSystem;
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