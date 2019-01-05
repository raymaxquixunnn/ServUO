using System;

namespace Server.Items
{
    public class MessageInABottle : Item
    {
        private Map m_TargetMap;
        private int m_Level;
        [Constructable]
        public MessageInABottle()
            : this(Map.Trammel)
        {
        }

        public MessageInABottle(Map map)
            : this(map, GetRandomLevel())
        {
        }

        [Constructable]
        public MessageInABottle(Map map, int level)
            : base(0x099F)
        {
            Weight = 1.0;
            m_TargetMap = map;
            m_Level = level;
        }

        public MessageInABottle(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get
            {
                return 1041080;
            }
        }// a message in a bottle
        [CommandProperty(AccessLevel.GameMaster)]
        public Map TargetMap
        {
            get
            {
                return m_TargetMap;
            }
            set
            {
                m_TargetMap = value;
            }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public int Level
        {
            get
            {
                return m_Level;
            }
            set
            {
                double levelchance = Utility.RandomDouble();

				     if (levelchance >= 0.475713)  m_Level =01;
				else if (levelchance >= 0.262144)  m_Level =02;
				else if (levelchance >= 0.131072)  m_Level =03;
				else if (levelchance >= 0.065536)  m_Level =04;
				else if (levelchance >= 0.032768)  m_Level =05;
				else if (levelchance >= 0.016384)  m_Level =06;
				else if (levelchance >= 0.008192)  m_Level =07;
				else if (levelchance >= 0.004096)  m_Level =08;
				else if (levelchance >= 0.002048)  m_Level =09;
				else if (levelchance >= 0.001024)  m_Level =10;
				else if (levelchance >= 0.000512)  m_Level =11;
				else if (levelchance >= 0.000256)  m_Level =12;
				else if (levelchance >= 0.000128)  m_Level =13;
				else if (levelchance >= 0.000064)  m_Level =14;
				else if (levelchance >= 0.000032)  m_Level =15;
				else if (levelchance >= 0.000016)  m_Level =16;
				else if (levelchance >= 0.000008)  m_Level =17;
				else if (levelchance >= 0.000004)  m_Level =18;
				else if (levelchance >= 0.000002)  m_Level =19;
				else                               m_Level =20;                
                
            }
        }
        public static int GetRandomLevel()
        {
            if (Core.AOS && 10 == Utility.RandomMinMax(1,25))
                return 4; // ancient

            return Utility.RandomMinMax(1, 20);
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)3); // version

            writer.Write((int)m_Level);

            writer.Write(m_TargetMap);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch ( version )
            {
                case 3:
                case 2:
                    {
                        m_Level = reader.ReadInt();
                        goto case 1;
                    }
                case 1:
                    {
                        m_TargetMap = reader.ReadMap();
                        break;
                    }
                case 0:
                    {
                        m_TargetMap = Map.Trammel;
                        break;
                    }
            }

            if (version < 2)
                m_Level = GetRandomLevel();

            if (version < 3 && m_TargetMap == Map.Tokuno)
                m_TargetMap = Map.Trammel;
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack))
            {
                ReplaceWith(new SOS(m_TargetMap, m_Level));
                from.LocalOverheadMessage(Network.MessageType.Regular, 0x3B2, 501891); // You extract the message from the bottle.
            }
            else
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
            }
        }
    }
}