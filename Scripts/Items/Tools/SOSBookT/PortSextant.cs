  //
 //  Written by Haazen June 2005
//
using System;
using Server.Network;
using Server.Gumps;

namespace Server.Items
{
	public class PortSextant : Item
	{

		private Map m_TargetMap;
		private Point3D m_TargetLocation;
		private int m_MessageIndex;

		[CommandProperty( AccessLevel.GameMaster )]
		public Map TargetMap
		{
			get{ return m_TargetMap; }
			set{ m_TargetMap = value; }
		}

		[CommandProperty( AccessLevel.GameMaster )]
		public Point3D TargetLocation
		{
			get{ return m_TargetLocation; }
			set{ m_TargetLocation = value; }
		}

		[CommandProperty( AccessLevel.GameMaster )]
		public int MessageIndex
		{
			get{ return m_MessageIndex; }
			set{ m_MessageIndex = value; }
		}

		[Constructable]
		public PortSextant() : this( Map.Felucca )
		{
		}

		[Constructable]
		public PortSextant( Map map) : base( 0x1058 )
		{
			Weight = 1.0;
			Name = "Port Sextant";
			m_MessageIndex = 0;
			m_TargetMap = map;
		}

		public PortSextant( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 ); // version

			writer.Write( m_TargetMap );
			writer.Write( m_TargetLocation );
			writer.Write( m_MessageIndex );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
			m_TargetMap = reader.ReadMap();
			m_TargetLocation = reader.ReadPoint3D();
			m_MessageIndex = reader.ReadInt();
		}
		public override void OnDoubleClick( Mobile from )
		{
			if ( from.InRange( GetWorldLocation(), 1 ) )
			{
				if ( this.MessageIndex == 0 )
				{
					from.CloseGump( typeof( PortGump ) );
					from.SendGump( new PortGump( from, this ) );
				}
				else
				{
					from.SendMessage (" This Sextant is set to {0}", this.Name );
				}
			}
		}
		
	}
}