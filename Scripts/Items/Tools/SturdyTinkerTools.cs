using System;
using Server.Engines.Craft;
using Server.ContextMenus;

namespace Server.Items
{
    [Flipable(0x1EB8, 0x1EB9)]
    public class SturdyTinkerTools : BaseTool
    {
        [Constructable]
        public SturdyTinkerTools()
            : this(180)
        {
        }

        [Constructable]
        public SturdyTinkerTools(int uses)
            : base(uses, 0x1EB8)
        {
            this.Weight = 1.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
        }

        public SturdyTinkerTools(Serial serial)
            : base(serial)
        {
        }

        public override CraftSystem CraftSystem
        {
            get
            {
                return DefTinkering.CraftSystem;
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

        public override void GetContextMenuEntries(Mobile from, System.Collections.Generic.List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);

            if (Core.TOL)
                list.Add(new ToggleRepairContextMenuEntry(from, this));
        }

        public class ToggleRepairContextMenuEntry : ContextMenuEntry
        {
            private Mobile _From;
            private BaseTool _Tool;

            public ToggleRepairContextMenuEntry(Mobile from, BaseTool tool)
                : base(1157040) // Toggle Repair Mode
            {
                _From = from;
                _Tool = tool;
            }

            public override void OnClick()
            {
                if (_Tool.RepairMode)
                {
                    _From.SendLocalizedMessage(1157042); // This tool is fully functional. 
                    _Tool.RepairMode = false;
                }
                else
                {
                    _From.SendLocalizedMessage(1157041); // This tool will only repair items in this mode.
                    _Tool.RepairMode = true;
                }
            }
        }
    }

    public class SturdyTinkersTools : BaseTool
    {
        [Constructable]
        public SturdyTinkersTools()
            : this(180)
        {
        }

        [Constructable]
        public SturdyTinkersTools(int uses)
            : base(uses, 0x1EBC)
        {
            this.Weight = 1.0;
            this.UsesRemaining = uses;
            this.ShowUsesRemaining = true;
        }

        public SturdyTinkersTools(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName { get { return "sturdy TinkersTools"; } }

        public override CraftSystem CraftSystem
        {
            get
            {
                return DefTinkering.CraftSystem;
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

        public override void GetContextMenuEntries(Mobile from, System.Collections.Generic.List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);

            if (Core.TOL)
                list.Add(new ToggleRepairContextMenuEntry(from, this));
        }

        public class ToggleRepairContextMenuEntry : ContextMenuEntry
        {
            private Mobile _From;
            private BaseTool _Tool;

            public ToggleRepairContextMenuEntry(Mobile from, BaseTool tool)
                : base(1157040) // Toggle Repair Mode
            {
                _From = from;
                _Tool = tool;
            }

            public override void OnClick()
            {
                if (_Tool.RepairMode)
                {
                    _From.SendLocalizedMessage(1157042); // This tool is fully functional. 
                    _Tool.RepairMode = false;
                }
                else
                {
                    _From.SendLocalizedMessage(1157041); // This tool will only repair items in this mode.
                    _Tool.RepairMode = true;
                }
            }
        }
    }
}