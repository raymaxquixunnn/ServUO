using System; 
using Server; 
using Server.Gumps; 
using Server.Network; 
using Server.Misc; 
using Server.Mobiles; 
using Server.Targeting; 

namespace Server.Items 
{ 
   public class SpellbookDyeTub : DyeTub 
   { 
     
	public override CustomHuePicker CustomHuePicker{ get{ return CustomHuePicker.LeatherDyeTub; } }

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

      [Constructable] 
      public SpellbookDyeTub() 
      { 
         Weight = 10.0; 
         Redyable = true; 
         Name = "Spellbook/SOSBook Dye Tub";
	 LootType = LootType.Blessed;

      } 

      public SpellbookDyeTub( Serial serial ) : base( serial ) 
      { 
      } 

      public override void OnDoubleClick( Mobile from ) 
      { 
         if ( from.InRange( this.GetWorldLocation(), 1 ) ) 
         { 
            from.SendMessage( "Select the Spellbook or SOSBook to dye." ); 
            from.Target = new InternalTarget( this ); 
         } 
         else 
         { 
            from.SendLocalizedMessage( 500446 ); // That is too far away. 
         } 
      } 

      private class InternalTarget : Target 
      { 
         private SpellbookDyeTub m_LTub; 

         public InternalTarget( SpellbookDyeTub tub ) : base( 1, false, TargetFlags.None ) 
         { 
            m_LTub = tub; 
         } 

         protected override void OnTarget( Mobile from, object targeted ) 
         { 
            	if ( targeted is Spellbook ) 
            	{ 
               	 	Spellbook SB = targeted as Spellbook;

               		if ( !from.InRange( m_LTub.GetWorldLocation(), 1 ) || !from.InRange( ((Item)targeted).GetWorldLocation(), 1 ) ) 
               		{ 
                  	from.SendLocalizedMessage( 500446 ); // That is too far away. 
               		} 
               		else if (( ((Item)targeted).Parent != null ) && ( ((Item)targeted).Parent is Mobile ) ) 
               		{ 
                  	from.SendMessage( "You cannot dye that in it's current location." ); 
               		} 
                  SB.Hue = m_LTub.Hue; 
                  from.PlaySound( 0x23E ); 
               	}

		else if ( targeted is SOSBookT ) 
            	{ 
               	 	SOSBookT SB = targeted as SOSBookT;

               		if ( !from.InRange( m_LTub.GetWorldLocation(), 1 ) || !from.InRange( ((Item)targeted).GetWorldLocation(), 1 ) ) 
               		{ 
                  	from.SendLocalizedMessage( 500446 ); // That is too far away. 
               		} 
               		else if (( ((Item)targeted).Parent != null ) && ( ((Item)targeted).Parent is Mobile ) ) 
               		{ 
                  	from.SendMessage( "You cannot dye that in it's current location." ); 
               		} 
                  SB.Hue = m_LTub.Hue; 
                  from.PlaySound( 0x23E ); 
               	}
 
            } 
         } 
      } 
   } 