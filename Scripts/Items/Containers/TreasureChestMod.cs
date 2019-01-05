// Treasure Chest Pack - Version 0.99I
// By Nerun

using Server;
using Server.Items;
using Server.Multis;
using Server.Network;
using System;

namespace Server.Items
{
// ---------- [Level01] ----------
    [FlipableAttribute( 0xe3e, 0xe3f )]
    public class TreasureLevel1 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel1() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 30;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 50;

            DropItem( new Gold(3000,3000));
            DropItem( new Arrow(200));
            DropItem( new BlankScroll(20));
            for (int i = Utility.Random(1, 1); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(10, 10);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(1, 1); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(1, 2); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(1, 1) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(1, 1); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(1, 2); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(1, 2); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel1( Serial serial ) : base( serial ) 
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
// ---------- [Level02] ----------
    [FlipableAttribute( 0xe3e, 0xe3f )]
    public class TreasureLevel2 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel2() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 35;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 100;

            DropItem( new Gold(6000,6000));
            DropItem( new Arrow(400));
            DropItem( new BlankScroll(40));
            for (int i = Utility.Random(2, 2); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(20, 20);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(1, 2); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(2, 4); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(1, 2) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(1, 1); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(2, 4); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(1, 2); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel2( Serial serial ) : base( serial ) 
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
// ---------- [Level03] ----------
    [FlipableAttribute( 0xe3e, 0xe3f )]
    public class TreasureLevel3 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel3() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 40;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 150;

            DropItem( new Gold(9000,9000));
            DropItem( new Arrow(600));
            DropItem( new BlankScroll(60));
            for (int i = Utility.Random(3, 3); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(30, 30);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(2, 3); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(3, 6); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(2, 3) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(1, 2); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(3, 6); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(2, 4); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel3( Serial serial ) : base( serial ) 
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
// ---------- [Level04] ----------
    [FlipableAttribute( 0xe3e, 0xe3f )]
    public class TreasureLevel4 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel4() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 45;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 200;

            DropItem( new Gold(12000,12000));
            DropItem( new Arrow(800));
            DropItem( new BlankScroll(80));
            for (int i = Utility.Random(4, 4); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(40, 40);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(2, 4); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(4, 8); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(2, 4) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(1, 2); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(4, 8); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(2, 4); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel4( Serial serial ) : base( serial ) 
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
// ---------- [Level05] ----------
    [FlipableAttribute( 0xe3e, 0xe3f )]
    public class TreasureLevel5 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel5() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 50;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 250;

            DropItem( new Gold(15000,15000));
            DropItem( new Arrow(1000));
            DropItem( new BlankScroll(100));
            for (int i = Utility.Random(5, 5); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(50, 50);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(3, 5); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(5, 10); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(3, 5) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(2, 3); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(5, 10); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(3, 6); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel5( Serial serial ) : base( serial ) 
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
// ---------- [Level06] ----------
    [FlipableAttribute( 0xe43, 0xe42 )]
    public class TreasureLevel6 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel6() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 55;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 300;

            DropItem( new Gold(18000,18000));
            DropItem( new Arrow(1200));
            DropItem( new BlankScroll(120));
            for (int i = Utility.Random(6, 6); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(60, 60);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(3, 6); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(6, 12); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(3, 6) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(2, 3); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(6, 12); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(3, 6); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel6( Serial serial ) : base( serial ) 
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
// ---------- [Level07] ----------
    [FlipableAttribute( 0xe43, 0xe42 )]
    public class TreasureLevel7 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel7() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 60;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 350;

            DropItem( new Gold(21000,21000));
            DropItem( new Arrow(1400));
            DropItem( new BlankScroll(140));
            for (int i = Utility.Random(7, 7); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(70, 70);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(4, 7); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(7, 14); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(4, 7) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(2, 4); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(7, 14); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(4, 8); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel7( Serial serial ) : base( serial ) 
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
// ---------- [Level08] ----------
    [FlipableAttribute( 0xe43, 0xe42 )]
    public class TreasureLevel8 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel8() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 65;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 400;

            DropItem( new Gold(24000,24000));
            DropItem( new Arrow(1600));
            DropItem( new BlankScroll(160));
            for (int i = Utility.Random(8, 8); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(80, 80);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(4, 8); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(8, 16); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(4, 8) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(2, 4); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(8, 16); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(4, 8); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel8( Serial serial ) : base( serial ) 
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
// ---------- [Level09] ----------
    [FlipableAttribute( 0xe43, 0xe42 )]
    public class TreasureLevel9 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel9() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 70;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 450;

            DropItem( new Gold(27000,27000));
            DropItem( new Arrow(1800));
            DropItem( new BlankScroll(180));
            for (int i = Utility.Random(9, 9); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(90, 90);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(5, 9); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(9, 18); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(5, 9) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(3, 5); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(9, 18); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(5, 10); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel9( Serial serial ) : base( serial ) 
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
// ---------- [Level 10] ----------
    [FlipableAttribute( 0xe43, 0xe42 )]
    public class TreasureLevel10 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel10() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 75;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 500;

            DropItem( new Gold(30000,30000));
            DropItem( new Arrow(2000));
            DropItem( new BlankScroll(200));
            for (int i = Utility.Random(10, 10); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(100, 100);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(5, 10); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(10, 20); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(5, 10) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(3, 5); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(10, 20); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(5, 10); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel10( Serial serial ) : base( serial ) 
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
// ---------- [Level 11] ----------
    [FlipableAttribute( 0x9ab, 0xe7c )]
    public class TreasureLevel11 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel11() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 80;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 550;

            DropItem( new Gold(33000,33000));
            DropItem( new Arrow(2200));
            DropItem( new BlankScroll(220));
            for (int i = Utility.Random(11, 11); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(110, 110);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(6, 11); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(11, 22); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(6, 11) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(3, 6); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(11, 22); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(6, 12); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel11( Serial serial ) : base( serial ) 
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
// ---------- [Level 12] ----------
    [FlipableAttribute( 0x9ab, 0xe7c )]
    public class TreasureLevel12 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel12() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 85;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 600;

            DropItem( new Gold(36000,36000));
            DropItem( new Arrow(2400));
            DropItem( new BlankScroll(240));
            for (int i = Utility.Random(12, 12); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(120, 120);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(6, 12); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(12, 24); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(6, 12) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(3, 6); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(12, 24); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(6, 12); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel12( Serial serial ) : base( serial ) 
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
// ---------- [Level 13] ----------
    [FlipableAttribute( 0x9ab, 0xe7c )]
    public class TreasureLevel13 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel13() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 90;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 650;

            DropItem( new Gold(39000,39000));
            DropItem( new Arrow(2600));
            DropItem( new BlankScroll(260));
            for (int i = Utility.Random(13, 13); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(130, 130);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(7, 13); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(13, 26); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(7, 13) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(4, 7); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(13, 26); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(7, 14); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel13( Serial serial ) : base( serial ) 
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
// ---------- [Level 14] ----------
    [FlipableAttribute( 0x9ab, 0xe7c )]
    public class TreasureLevel14 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel14() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 95;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 700;

            DropItem( new Gold(42000,42000));
            DropItem( new Arrow(2800));
            DropItem( new BlankScroll(280));
            for (int i = Utility.Random(14, 14); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(140, 140);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(7, 14); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(14, 28); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(7, 14) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(4, 7); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(14, 28); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(7, 14); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel14( Serial serial ) : base( serial ) 
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
// ---------- [Level 15] ----------
    [FlipableAttribute( 0x9ab, 0xe7c )]
    public class TreasureLevel15 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel15() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 100;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 750;

            DropItem( new Gold(45000,45000));
            DropItem( new Arrow(3000));
            DropItem( new BlankScroll(300));
            for (int i = Utility.Random(15, 15); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(150, 150);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(8, 15); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(15, 30); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(8, 15) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(4, 8); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(15, 30); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(8, 16); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel15( Serial serial ) : base( serial ) 
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
// ---------- [Level 16] ----------
    [FlipableAttribute( 0xe41, 0xe40 )]
    public class TreasureLevel16 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel16() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 110;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 800;

            DropItem( new Gold(48000,48000));
            DropItem( new Arrow(3200));
            DropItem( new BlankScroll(320));
            for (int i = Utility.Random(16, 16); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(160, 160);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(8, 16); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(16, 32); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(8, 16) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(4, 8); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(16, 32); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(8, 16); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel16( Serial serial ) : base( serial ) 
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
// ---------- [Level 17] ----------
    [FlipableAttribute( 0xe41, 0xe40 )]
    public class TreasureLevel17 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel17() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 120;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 850;

            DropItem( new Gold(51000,51000));
            DropItem( new Arrow(3400));
            DropItem( new BlankScroll(340));
            for (int i = Utility.Random(17, 17); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(170, 170);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(9, 17); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(17, 34); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(9, 17) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(5, 9); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(17, 34); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(9, 18); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel17( Serial serial ) : base( serial ) 
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
// ---------- [Level 18] ----------
    [FlipableAttribute( 0xe41, 0xe40 )]
    public class TreasureLevel18 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel18() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 130;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 900;

            DropItem( new Gold(54000,54000));
            DropItem( new Arrow(3600));
            DropItem( new BlankScroll(360));
            for (int i = Utility.Random(18, 18); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(180, 180);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(9, 18); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(18, 36); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(9, 18) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(5, 9); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(18, 36); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(9, 18); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel18( Serial serial ) : base( serial ) 
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
// ---------- [Level 19] ----------
    [FlipableAttribute( 0xe41, 0xe40 )]
    public class TreasureLevel19 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel19() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 140;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 950;

            DropItem( new Gold(57000,57000));
            DropItem( new Arrow(3800));
            DropItem( new BlankScroll(380));
            for (int i = Utility.Random(19, 19); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(190, 190);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(10, 19); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(19, 38); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(10, 19) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(5, 10); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(19, 38); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(10, 20); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel19( Serial serial ) : base( serial ) 
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
// ---------- [Level 20] ----------
    [FlipableAttribute( 0xe41, 0xe40 )]
    public class TreasureLevel20 : BaseTreasureChestMod
    {
        [Constructable] 
        public TreasureLevel20() : base( Utility.RandomList( 0x9a9, 0x9ab,  0xE3E, 0xe40, 0xe42, 0xe77, 0xe7f ) )
        {
            RequiredSkill = 150;
            LockLevel = this.RequiredSkill;
            MaxLockLevel = this.RequiredSkill;
            TrapType = TrapType.MagicTrap;
            TrapPower = 1000;

            DropItem( new Gold(60000,60000));
            DropItem( new Arrow(4000));
            DropItem( new BlankScroll(400));
            for (int i = Utility.Random(20, 20); i > 1; i--)
            {
            Item ReagentLoot = Loot.RandomReagent();
            ReagentLoot.Amount = Utility.Random(200, 200);
            DropItem( ReagentLoot );
            }

            for (int j = Utility.Random(10, 20); j > 1; j--)
            {
            DropItem(Loot.RandomPotion());
            }

            for (int k = Utility.RandomMinMax(20, 40); k > 0; k--)
            {
            DropItem(Loot.RandomScroll(0, 47, SpellbookType.Regular));
            }

            for (int l = Utility.RandomMinMax(10, 20) + 1; l > 0; l--)
            {
            DropItem(Loot.RandomGem());
            }

            for (int m = Utility.Random(5, 10); m > 1; m--)
            {
            DropItem(Loot.RandomWand());
            }

            for (int num = Utility.Random(20, 40); num > 1; num--)
            {
            AddLoot(Loot.RandomClothing());
            }

            for (int num2 = Utility.Random(10, 20); num2 > 1; num2--)
            {
            AddLoot(Loot.RandomJewelry());
            }
        }

        public TreasureLevel20( Serial serial ) : base( serial ) 
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