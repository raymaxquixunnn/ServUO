using System; 
using Server;
using Server.Items; 

namespace Server.Items 
{ 
	[Flipable( 0x0EDC, 0x0EDB )]
   public class AtmStone : AddonComponent 
   { 

      [Constructable] 
      public AtmStone() : this( 0x0EDC ) 
      { 
      }

      [Constructable] 
      public AtmStone( int itemID ) : base( itemID ) 
       {
         Name = "ATM"; 
         Movable = false; 
         Hue = 0x0;
      }

      public override void OnDoubleClick( Mobile from ) 
      {
	    AtmCard card = from.Backpack.FindItemByType( typeof( AtmCard ), true ) as AtmCard;
		
      	BankBox box = from.BankBox; 

      	if( card != null )
			{
			if ( box != null )
      	 		box.Open();
			}
		else
			{
			from.SendMessage( "キャッシュカードがないので開けることができません。" );
		}
      }

	  public AtmStone( Serial serial ) : base( serial ) 
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