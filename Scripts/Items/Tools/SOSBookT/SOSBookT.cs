  //
 //  Written by Haazen June 2005
//
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Server.Commands;
using Server.Factions;
using Server;
using Server.Gumps;
using Server.Items;
using Server.Network;
using Server.Multis;
using Server.Engines.Craft;
using Server.ContextMenus;
using Server.Prompts;
using Server.Mobiles;

namespace Server.Items
{
	public class SOSBookT : Item
	{
		private ArrayList m_Entries;
		private int m_DefaultIndex;
		private int m_Charges;

		[CommandProperty( AccessLevel.GameMaster )]
		public int Charges
		{
			get{ return m_Charges; }
			set
			{
				if ( value > this.MaxCharges )
					m_Charges = this.MaxCharges;
				else if ( value < 0 )
					m_Charges = 0;
				else
					m_Charges = value;

				InvalidateProperties();
			}
		}

		[CommandProperty( AccessLevel.GameMaster )]
		public int MaxCharges{ get{ return 100; } }

		[Constructable]
		public SOSBookT( ) : base( Core.AOS ? 0x22C5 : 0xEFA )
		{
			Weight = (Core.SE ? 1.0 : 3.0);
			LootType = LootType.Blessed;
			Hue = 0x461;
			Name = "SOS Book";

			Layer = Layer.OneHanded;
			m_Entries = new ArrayList();
			m_DefaultIndex = -1;
			m_Charges = 0;
		}


		public ArrayList Entries
		{
			get
			{
				return m_Entries;
			}
		}

		public SOSBookTEntry Default
		{
			get
			{
				if ( m_DefaultIndex >= 0 && m_DefaultIndex < m_Entries.Count )
					return (SOSBookTEntry)m_Entries[m_DefaultIndex];

				return null;
			}
			set
			{
				if ( value == null )
					m_DefaultIndex = -1;
				else
					m_DefaultIndex = m_Entries.IndexOf( value );
			}
		}

		public SOSBookT( Serial serial ) : base( serial )
		{
		}

		public override bool AllowEquipedCast( Mobile from )
		{
			return true;
		}

		public override void GetContextMenuEntries( Mobile from,List<ContextMenuEntry> list )
		{
			base.GetContextMenuEntries( from, list );

			if ( from.CheckAlive() && IsChildOf( from.Backpack ) )
				list.Add( new NameBookEntry( from, this ) );
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 );

			writer.Write( (int) m_Charges );
			writer.Write( m_Entries.Count );


			for ( int i = 0; i < m_Entries.Count; ++i )
				((SOSBookTEntry)m_Entries[i]).Serialize( writer );
			writer.Write( m_DefaultIndex );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			LootType = LootType.Blessed;

			if( Core.SE && Weight == 3.0 )
				Weight = 1.0;

			int version = reader.ReadInt();

			switch ( version )
			{
				case 1:
				{
					goto case 0;
				}
				case 0:
				{
					m_Charges = reader.ReadInt();
					int count = reader.ReadInt();

					m_Entries = new ArrayList( count );

					for ( int i = 0; i < count; ++i )
						m_Entries.Add( new SOSBookTEntry( reader ) );

					m_DefaultIndex = reader.ReadInt();

					break;
				}
			}
		}

		public void DropSOS( Mobile from, SOSBookTEntry e, int index )
		{
			if ( m_DefaultIndex == index )
				m_DefaultIndex = -1;

			m_Entries.RemoveAt( index );
			if ( e.Location.Z == 0 )
			{
				SOS sos = new SOS();

				sos.TargetLocation = e.Location;
				sos.TargetMap = e.Map;

				from.AddToBackpack( sos );

				from.SendMessage( "You have removed the SOS" );
			}
			else if ( e.Location.Z > 0 )
			{
				PortSextant ps = new PortSextant();
				ps.TargetLocation = e.Location;
				ps.TargetMap = e.Map;
				ps.MessageIndex = e.Location.Z + 100;
				ps.Hue = 93;
				switch ( e.Location.Z )
				{
					case 1: {ps.Name = "Port of Britian";break;}
					case 2: {ps.Name = "Port of BucsDen";break;}
					case 3: {ps.Name = "Port of Jhelom";break;}
					case 4: {ps.Name = "Port of Magincia";break;}
					case 5: {ps.Name = "Port of Moonglow";break;}
					case 6: {ps.Name = "Port of Occlo/Haven";break;}
					case 7: {ps.Name = "Port of Serpents Hold";break;}
					case 8: {ps.Name = "Port of Skara Brae";break;}
					case 9: {ps.Name = "Port of Trinsic";break;}
					case 10: {ps.Name = "Port of Vesper";break;}
				}
				from.AddToBackpack( ps );

				from.SendMessage( "You have removed the Port Sextant" );
			}
		}

		public bool IsOpen( Mobile toCheck )
		{
			NetState ns = toCheck.NetState;

			if ( ns == null )
				return false;

			//GumpCollection gumps = ns.Gumps;
			 List<Gump> gumps = new List<Gump>(ns.Gumps);

			for ( int i = 0; i < gumps.Count; ++i )
			{
				if ( gumps[i] is SOSBookTGump )
				{
					SOSBookTGump gump = (SOSBookTGump)gumps[i];

					if ( gump.Book == this )
						return true;
				}
			}

			return false;
		}

		public override bool DisplayLootType{ get{ return Core.AOS; } }

		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );
		}

		public override void OnDoubleClick( Mobile from )
		{
			if ( from.InRange( GetWorldLocation(), 1 ) )
			{
				from.CloseGump( typeof( SOSBookTGump ) );
				from.SendGump( new SOSBookTGump( from, this ) );
			}
		}

		/*public override Item Dupe( int amount )
		{
			SOSBookT book = new SOSBookT();
			book.m_DefaultIndex = m_DefaultIndex;
			book.LootType = this.LootType;

			for( int i = 0; i < m_Entries.Count; i++ )
			{
				SOSBookTEntry entry = m_Entries[i] as SOSBookTEntry;
				
				book.m_Entries.Add( new SOSBookTEntry( entry.Location, entry.Map ) ); 
			}

			return base.Dupe( book, amount );
		}*/

		public bool CheckAccess( Mobile m )
		{
			return true;
		}

		public override bool OnDragDrop( Mobile from, Item dropped )
		{
			if ( dropped is PowderOfTranslocation)
			{

				if ( m_Charges >= MaxCharges )
				{
					from.SendLocalizedMessage( 1054137 ); // This item cannot absorb any more powder of translocation.
					return false;
				}

				int chrg = dropped.Amount / 20;
				if ( chrg > 0 )
				{
					if ( chrg * 20 >= dropped.Amount )
						dropped.Delete();
					else
						dropped.Amount -= chrg * 20;
				}
				m_Charges += chrg;
			}

			else if ( dropped is SOS )
			{
				if ( !CheckAccess( from ) )
				{
					from.SendLocalizedMessage( 502413 ); // That cannot be done while the book is locked down.
				}
				else if ( IsOpen( from ) )
				{
					from.SendLocalizedMessage( 1005571 ); // You cannot place objects in the book while viewing the contents.
				}
				else if ( m_Entries.Count < 32 )
				{
					SOS sos = (SOS)dropped;

					if ( sos.TargetMap != null ) 
					{
						m_Entries.Add( new SOSBookTEntry( sos.TargetLocation, sos.TargetMap ) );

						dropped.Delete();

						from.Send( new PlaySound( 0x42, GetWorldLocation() ) );

						return true;
					}
					else
					{
						from.SendMessage( "This map is invalid" );
					}
				}
				else
				{
					from.SendMessage( "This SOS Book is full" );
				}
			}
			else if ( dropped is PortSextant )
			{
				if ( !CheckAccess( from ) )
				{
					from.SendLocalizedMessage( 502413 ); // That cannot be done while the book is locked down.
				}
				else if ( IsOpen( from ) )
				{
					from.SendLocalizedMessage( 1005571 ); // You cannot place objects in the book while viewing the contents.
				}
				else if ( m_Entries.Count < 32 )
				{
					PortSextant ps = (PortSextant)dropped;

					if ( ps.TargetMap != null && ps.TargetLocation.Z != 0 ) 
					{
						m_Entries.Add( new SOSBookTEntry( ps.TargetLocation, ps.TargetMap ) );

						dropped.Delete();

						from.Send( new PlaySound( 0x42, GetWorldLocation() ) );

						return true;
					}
					else
					{
						from.SendMessage( "This map is invalid" );
					}
				}
				else
				{
					from.SendMessage( "This SOS Book is full" );
				}
			}
			return false;
		}

		private class NameBookEntry : ContextMenuEntry
		{
			private Mobile m_From;
			private SOSBookT m_Book;

			public NameBookEntry( Mobile from, SOSBookT book ) : base( 6216 )
			{
				m_From = from;
				m_Book = book;
			}

			public override void OnClick()
			{
				if ( m_From.CheckAlive() && m_Book.IsChildOf( m_From.Backpack ) )
				{
					m_From.Prompt = new NameBookPrompt( m_Book );
					m_From.SendLocalizedMessage( 1062479 ); // Type in the new name of the book:
				}
			}
		}

		private class NameBookPrompt : Prompt
		{
			private SOSBookT m_Book;

			public NameBookPrompt( SOSBookT book )
			{
				m_Book = book;
			}

			public override void OnResponse( Mobile from, string text )
			{
				if ( text.Length > 40 )
					text = text.Substring( 0, 40 );

				if ( from.CheckAlive() && m_Book.IsChildOf( from.Backpack ) )
				{
					m_Book.Name = Utility.FixHtml( text.Trim() );

					from.SendMessage( "This SOS Book name has been changed" );
				}
			}

			public override void OnCancel( Mobile from )
			{
			}
		}
	}

	public class SOSBookTEntry
	{
		private Point3D m_Location;
		private Map m_Map;

		public Point3D Location
		{
			get{ return m_Location; }
		}

		public Map Map
		{
			get{ return m_Map; }
		}

		public SOSBookTEntry( Point3D loc, Map map ) 
		{
			m_Location = loc;
			m_Map = map;
		}

		public SOSBookTEntry( GenericReader reader )
		{
			int version = reader.ReadByte();

			switch ( version )
			{
				case 1:
				{
					goto case 0;
				}
				case 0:
				{
					m_Location = reader.ReadPoint3D();
					m_Map = reader.ReadMap();

					break;
				}
			}
		}

		public void Serialize( GenericWriter writer )
		{

			writer.Write( (byte) 0 ); // version

			writer.Write( m_Location );
			writer.Write( m_Map );
		}
	}
}