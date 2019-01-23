  //
 //  Written by Haazen June 2005
//
using System;
using Server;
using Server.Items;
using Server.Network;
using Server.Gumps;

namespace Server.Gumps
{
	public class PortGump : Gump
	{
		private PortSextant m_PortS;
		public PortGump( Mobile from, PortSextant port)	: base( 100, 100 )
		{
			m_PortS = port;
			this.Closable=true;
			this.Disposable=true;
			this.Dragable=true;
			this.Resizable=false;
			this.AddPage(0);
			this.AddBackground(0, 1, 191, 367, 9200);
			this.AddButton(20, 20, 2117, 11411, (int)Buttons.Britian, GumpButtonType.Reply, 0);
			this.AddLabel(40, 18, 0, @"Britian");
			this.AddButton(20, 50, 2117, 11411, (int)Buttons.BucsDen, GumpButtonType.Reply, 0);
			this.AddLabel(40, 48, 0, @"Buccaneer's Den");
			this.AddButton(20, 80, 2117, 11411, (int)Buttons.Jhelom, GumpButtonType.Reply, 0);
			this.AddLabel(40, 78, 0, @"Jhelom");
			this.AddButton(20, 110, 2117, 11411, (int)Buttons.Magincia, GumpButtonType.Reply, 0);
			this.AddLabel(40, 108, 0, @"Magincia");
			this.AddButton(20, 140, 2117, 11411, (int)Buttons.Moonglow, GumpButtonType.Reply, 0);
			this.AddLabel(40, 138, 0, @"Moonglow");
			this.AddButton(20, 170, 2117, 11411, (int)Buttons.Occlo, GumpButtonType.Reply, 0);
			this.AddLabel(40, 168, 0, @"Occlo/Haven");
			this.AddButton(20, 200, 2117, 11411, (int)Buttons.SerpHold, GumpButtonType.Reply, 0);
			this.AddLabel(40, 198, 0, @"Serpents Hold");
			this.AddButton(20, 230, 2117, 11411, (int)Buttons.Skara, GumpButtonType.Reply, 0);
			this.AddLabel(40, 228, 0, @"Skara Brae");
			this.AddButton(20, 260, 2117, 11411, (int)Buttons.Trinsic, GumpButtonType.Reply, 0);
			this.AddLabel(40, 258, 0, @"Trinsic");
			this.AddButton(20, 290, 2117, 11411, (int)Buttons.Vesper, GumpButtonType.Reply, 0);
			this.AddLabel(40, 288, 0, @"Vesper");
			this.AddLabel(30, 316, 0, @"Select Your Home Port");
			this.AddLabel(15, 336, 0, @"Then drop on your SOSBook");

		}
		
		public enum Buttons
		{
			None,
			Britian,
			BucsDen,
			Jhelom,
			Magincia,
			Moonglow,
			Occlo,
			SerpHold,
			Skara,
			Trinsic,
			Vesper,
		}
		public override void OnResponse( NetState state, RelayInfo info )
		{
			Mobile from = state.Mobile;
			switch( info.ButtonID )
			{
				case (int)Buttons.Britian: {m_PortS.Name = "Port of Britian";
					m_PortS.MessageIndex = 101;
					m_PortS.TargetLocation = new Point3D( 1480, 1795, 1 );
					m_PortS.TargetMap = from.Map;
					m_PortS.Hue = 93;
				break;}
				case (int)Buttons.BucsDen: {m_PortS.Name = "Port of BucsDen";
					m_PortS.MessageIndex = 102;
					m_PortS.TargetLocation = new Point3D( 2785, 2170, 2 );
					m_PortS.TargetMap = from.Map;
					m_PortS.Hue = 93;
				break;}
				case (int)Buttons.Jhelom: {m_PortS.Name = "Port of Jhelom";
					m_PortS.MessageIndex = 103;
					m_PortS.TargetLocation = new Point3D( 1540, 3695, 3 );
					m_PortS.TargetMap = from.Map;
					m_PortS.Hue = 93;
				break;}
				case (int)Buttons.Magincia: {m_PortS.Name = "Port of Magincia";
					m_PortS.MessageIndex = 104;
					m_PortS.TargetLocation = new Point3D( 3680, 2320, 4 );
					m_PortS.TargetMap = from.Map;
					m_PortS.Hue = 93;
				break;}
				case (int)Buttons.Moonglow: {m_PortS.Name = "Port of Moonglow";
					m_PortS.MessageIndex = 105;
					m_PortS.TargetLocation = new Point3D( 4410, 1000, 5 );
					m_PortS.TargetMap = from.Map;
					m_PortS.Hue = 93;
				break;}
				case (int)Buttons.Occlo: {m_PortS.Name = "Port of Occlo/Haven";
					m_PortS.MessageIndex = 106;
					m_PortS.TargetLocation = new Point3D( 3650, 2705, 6 );
					m_PortS.TargetMap = from.Map;
					m_PortS.Hue = 93;
				break;}
				case (int)Buttons.SerpHold: {m_PortS.Name = "Port of Serpents Hold";
					m_PortS.MessageIndex = 107;
					m_PortS.TargetLocation = new Point3D( 3065, 3525, 7 );
					m_PortS.TargetMap = from.Map;
					m_PortS.Hue = 93;
				break;}
				case (int)Buttons.Skara: {m_PortS.Name = "Port of Skara Brae";
					m_PortS.MessageIndex = 108;
					m_PortS.TargetLocation = new Point3D( 665, 2270, 8 );
					m_PortS.TargetMap = from.Map;
					m_PortS.Hue = 93;
				break;}
				case (int)Buttons.Trinsic: {m_PortS.Name = "Port of Trinsic";
					m_PortS.MessageIndex = 109;
					m_PortS.TargetLocation = new Point3D( 2105, 2885, 9 );
					m_PortS.TargetMap = from.Map;
					m_PortS.Hue = 93;
				break;}
				case (int)Buttons.Vesper: {m_PortS.Name = "Port of Vesper";
					m_PortS.MessageIndex = 110;
					m_PortS.TargetLocation = new Point3D( 3070, 825, 10 );
					m_PortS.TargetMap = from.Map;
					m_PortS.Hue = 93;
				break;}

			}
		}

	}
}