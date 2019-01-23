  //
 //  Written by Haazen June 2005
//
using System;
using System.Collections;
using Server;
using Server.Items;
using Server.Network;
using Server.Prompts;
using Server.Multis;

namespace Server.Gumps
{
	public class SOSBookTGump : Gump
	{
		private SOSBookT m_Book;

		public SOSBookT Book{ get{ return m_Book; } }

		public int GetMapHue( Map map )
		{
			if ( map == Map.Trammel )
				return 10;
			else if ( map == Map.Felucca )
				return 81;
			else if ( map == Map.Ilshenar )
				return 1102;
			else if ( map == Map.Malas )
				return 1102;

			return 0;
		}


		public string GetName( string name )
		{
			if ( name == null || (name = name.Trim()).Length <= 0 )
				return "(indescript)";

			return name;
		}

		private void AddBackground()
		{
			AddPage( 0 );

			AddImage( 100, 10, 2200 ); // background 
			AddHtml( 160, 20, 80, 18, "Incants:", false, false );
			AddHtml( 230, 20, 30, 18, m_Book.Charges.ToString(), false, false );

			for ( int i = 0; i < 2; ++i ) // page separators
			{
				int xOffset = 125 + (i * 165);

				AddImage( xOffset, 105, 57 );
				xOffset += 20;

				for ( int j = 0; j < 6; ++j, xOffset += 15 )
					AddImage( xOffset, 105, 58 );

				AddImage( xOffset - 5, 105, 59 );
			} 

			//  page buttons
			for ( int i = 0, xOffset = 130, gumpID = 2225; i < 4; ++i, xOffset += 35, ++gumpID )
				AddButton( xOffset, 187, gumpID, gumpID, 0, GumpButtonType.Page, 1 + i );


			for ( int i = 0, xOffset = 300, gumpID = 2229; i < 4; ++i, xOffset += 35, ++gumpID )
				AddButton( xOffset, 187, gumpID, gumpID, 0, GumpButtonType.Page, 5 + i ); 


		}

		private void AddDetails( int index, int half, int tb )
		{
			int hue;

			if ( index < m_Book.Entries.Count )
			{
				int btn;
				btn = (index * 2) + 1;
		
				SOSBookTEntry e = (SOSBookTEntry)m_Book.Entries[index];
				hue = GetMapHue( e.Map );
				int xLong = 0, yLat = 0;
				int xMins = 0, yMins = 0;
				bool xEast = false, ySouth = false;

				if ( Sextant.Format( e.Location, e.Map, ref xLong, ref yLat, ref xMins, ref yMins, ref xEast, ref ySouth ) )
				{

					if ( e.Location.Z == 0 )
					{

					AddLabel( 135 + (half * 160), 40 + (tb * 80), hue, String.Format( "{0}° {1}'{2}", yLat, yMins, ySouth ? "S" : "N" ) );
					AddLabel( 135 + (half * 160), 55 + (tb * 80), hue, String.Format( "{0}° {1}'{2}", xLong, xMins, xEast ? "E" : "W" ) );
					}
					else
					{
						hue = 93;
						string port = "";
						switch ( e.Location.Z )
						{
						case 1: {port = "Port of Britian";break;}
						case 2: {port = "Port of BucsDen";break;}
						case 3: {port = "Port of Jhelom";break;}
						case 4: {port = "Port of Magincia";break;}
						case 5: {port = "Port of Moonglow";break;}
						case 6: {port = "Port of Occlo/Haven";break;}
						case 7: {port = "Port of Serpents Hold";break;}
						case 8: {port = "Port of Skara Brae";break;}
						case 9: {port = "Port of Trinsic";break;}
						case 10: {port = "Port of Vesper";break;}
						}
					AddLabel( 135 + (half * 160), 40 + (tb * 80), hue, port );

					}
				}

				// buttons

				AddButton( 135 + (half * 160), 75 + (tb * 80), 2437, 2438, btn, GumpButtonType.Reply, 0 );
				
				AddHtml( 150 + (half * 160), 73 + (tb * 80), 100, 18, "Drop SOS", false, false );

				AddButton( 135 + (half * 160), 89 + (tb * 80), 216, 216, btn + 1, GumpButtonType.Reply, 0 );
				
				AddHtml( 150 + (half * 160), 87 + (tb * 80), 100, 18, "Transport", false, false );

			}
		}

		public SOSBookTGump( Mobile from, SOSBookT book ) : base( 150, 200 )
		{
			m_Book = book;

			AddBackground();

			for ( int page = 0; page < 8; ++page )
			{
				AddPage( 1 + page );
				
				if ( page > 0 ) //0
				AddButton( 125, 14, 2205, 2205, 0, GumpButtonType.Page, page );

				if ( page < 7 )
				AddButton( 393, 14, 2206, 2206, 0, GumpButtonType.Page, 2 + page );

				if ( page < 4 )
				AddImage ( 135 + ( page * 35), 190, 36 );
				if ( page > 3 )
				AddImage ( 305 + (( page - 4) * 35), 190, 36 );

				for ( int half = 0; half < 2; ++half )
				{
					int tb = 0;
					AddDetails( (page * 4) + (half * 2), half, tb );
					tb = 1;
					AddDetails( (page * 4) + (half * 2) + 1, half, tb );
				}
			}
		}

		public override void OnResponse( NetState state, RelayInfo info )
		{
			Mobile from = state.Mobile;

			if ( m_Book.Deleted || !from.InRange( m_Book.GetWorldLocation(), 1 ) || !Multis.DesignContext.Check( from ) )
				return;

			int buttonID = info.ButtonID;

			int index = (buttonID / 2);
			int drp = buttonID % 2; // 1 = drop 0 = teleport

			if ( index >= 0 && index < m_Book.Entries.Count && drp == 1 )
			{
				SOSBookTEntry e = (SOSBookTEntry)m_Book.Entries[index];

				if ( m_Book.CheckAccess( from ) )
				{
					m_Book.DropSOS( from, e, index );
					from.CloseGump( typeof( SOSBookTGump ) );
					from.SendGump( new SOSBookTGump( from, m_Book ) );
				}
				else
				{
					from.SendLocalizedMessage( 502413 ); // That cannot be done while the book is locked down.
				}

			}
			 else	if (index >= 1 && index < m_Book.Entries.Count +1 && drp == 0)
			{

				index = index - 1;
				
				SOSBookTEntry e = (SOSBookTEntry)m_Book.Entries[index];
				BaseBoat boat = BaseBoat.FindBoatAt( from, from.Map );
				if ( boat == null )
					return;
				Map mapf = from.Map;
				Map mapd = e.Map;
				if ( e.Location.Z > 0 )
					mapd = mapf;
				if (mapf != mapd )
				{
					if ( boat.TillerMan != null )
					//boat.TillerMan.Say( true,"ARG! We can not transport to that Facet from here" );
					return;
				}

				Point3D xyz = e.Location;
				Map map = from.Map;

				for ( int i = 0; i < 5; i++ ) // Try 5 times
				{
					int x = Utility.Random( xyz.X -15, 30 );
					int y = Utility.Random( xyz.Y - 15, 30 );
					int z = map.GetAverageZ( x, y );

					Point3D dest = new Point3D( x, y, z );

					if ( boat.CanFit( dest, map, boat.ItemID ) )
					{
						int xOffset = x - boat.X;
						int yOffset = y - boat.Y;
						int zOffset = z - boat.Z;

						if ( m_Book.Charges > 0 )			
						{
							m_Book.Charges -- ;
							boat.Teleport( xOffset, yOffset, zOffset );
							//boat.TillerMan.Say( true,"AR! Captain! We are near our destination" );
						}
						else
						{

						from.SendMessage("You have no charges left in this book");

						}
						return;
					}
				}
			}  
		}
	}
}