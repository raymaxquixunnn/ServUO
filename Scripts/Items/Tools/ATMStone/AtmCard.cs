using System;
using Server.Network;
using Server.Prompts;
using Server.Items;

namespace Server.Items
{
	public class AtmCard : Item
	{
		[Constructable]
		public AtmCard() : base( 0x12AC )
		{
			base.Weight = 1.0;
			base.Name = "ATMカード";
			LootType = LootType.Blessed;
		}

		public AtmCard( Serial serial ) : base( serial )
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
