using System; 
using Server;
using Server.Items; 

namespace Server.Items 
{  
   public class AtmStoneAddon : BaseAddon 
   { 
		public override BaseAddonDeed Deed{ get{ return new AtmStoneDeed(); } }

      [Constructable] 
      public AtmStoneAddon() 
      { 
			AddComponent( new AtmStone( 0x0EDC ), 0, 0, 0 );
      }

	  public AtmStoneAddon( Serial serial ) : base( serial ) 
      { 
      } 

      public override void Serialize( GenericWriter writer ) 
      { 
         base.Serialize( writer ); 

         writer.Write( (int) 0 ); // version 
      } 

      public override void Deserialize( GenericReader reader ) 
      { 
         base.Deserialize( reader ); 

         int version = reader.ReadInt(); 
      } 
   } 

	public class AtmStoneDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new AtmStoneAddon(); } }

		[Constructable]
		public AtmStoneDeed()
		{
                                 Hue = 0x0;
                                 Name = "ATM設置Deed";
		}

		public AtmStoneDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}

