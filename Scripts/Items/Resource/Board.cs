using System;

namespace Server.Items
{
    [FlipableAttribute( 0x1BD7, 0x1BDA )]
	public class BaseWoodBoard : Item, ICommodity
	{
		private CraftResource m_Resource;

		[CommandProperty( AccessLevel.GameMaster )]
		public CraftResource Resource
		{
			get { return m_Resource; }
			set { m_Resource = value; InvalidateProperties(); }
		}

		TextDefinition ICommodity.Description
		{ 
			get
			{
				if ( m_Resource >= CraftResource.OakWood && m_Resource <= CraftResource.YewWood )
					return 1075052 + ( (int)m_Resource - (int)CraftResource.OakWood );

				switch ( m_Resource )
				{
					case CraftResource.Bloodwood: return 1075055;
					case CraftResource.Frostwood: return 1075056;
					case CraftResource.Heartwood: return 1075062;	//WHY Osi.  Why?
				}

				return LabelNumber;
			} 
		}

		bool ICommodity.IsDeedable { get { return true; } }

		[Constructable]
		public BaseWoodBoard()
			: this( 1 )
		{
		}

		[Constructable]
		public BaseWoodBoard( int amount )
			: this( CraftResource.RegularWood, amount )
		{
		}

		public BaseWoodBoard( Serial serial )
			: base( serial )
		{
		}

		[Constructable]
		public BaseWoodBoard( CraftResource resource ) : this( resource, 1 )
		{
		}

		[Constructable]
		public BaseWoodBoard( CraftResource resource, int amount )
			: base( 0x1BD7 )
		{
			Stackable = true;
			Amount = amount;

			m_Resource = resource;
			Hue = CraftResources.GetHue( resource );
		}

		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			if ( !CraftResources.IsStandard( m_Resource ) )
			{
				int num = CraftResources.GetLocalizationNumber( m_Resource );

				if ( num > 0 )
					list.Add( num );
				else
					list.Add( CraftResources.GetName( m_Resource ) );
			}
		}

		

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 4 );

			writer.Write( (int)m_Resource );
		}

		public static bool UpdatingBaseClass;
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
			if ( version == 3 )
				UpdatingBaseClass = true;
			switch ( version )
			{
				case 4:
				case 3:
				case 2:
					{
						m_Resource = (CraftResource)reader.ReadInt();
						break;
					}
			}

			if ( (version == 0 && Weight == 0.1) || ( version <= 2 && Weight == 2 ) )
				Weight = -1;

			if ( version <= 1 )
				m_Resource = CraftResource.RegularWood;
		}
	}
	
	public class Board : BaseWoodBoard
	{
		[Constructable]
		public Board()
			: this(1)
		{
		}

		[Constructable]
		public Board(int amount)
			: base(CraftResource.RegularWood, amount)
		{
		}

		public Board(Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0); // version
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);
			if (BaseWoodBoard.UpdatingBaseClass)
				return;
			int version = reader.ReadInt();
		}
	}

    public class HeartwoodBoard : BaseWoodBoard
    {
        [Constructable]
        public HeartwoodBoard()
            : this(1)
        {
        }

        [Constructable]
        public HeartwoodBoard(int amount)
            : base(CraftResource.Heartwood, amount)
        {
        }

        public HeartwoodBoard(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    public class BloodwoodBoard : BaseWoodBoard
    {
        [Constructable]
        public BloodwoodBoard()
            : this(1)
        {
        }

        [Constructable]
        public BloodwoodBoard(int amount)
            : base(CraftResource.Bloodwood, amount)
        {
        }

        public BloodwoodBoard(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    public class FrostwoodBoard : BaseWoodBoard
    {
        [Constructable]
        public FrostwoodBoard()
            : this(1)
        {
        }

        [Constructable]
        public FrostwoodBoard(int amount)
            : base(CraftResource.Frostwood, amount)
        {
        }

        public FrostwoodBoard(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    public class OakBoard : BaseWoodBoard
    {
        [Constructable]
        public OakBoard()
            : this(1)
        {
        }

        [Constructable]
        public OakBoard(int amount)
            : base(CraftResource.OakWood, amount)
        {
        }

        public OakBoard(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    public class AshBoard : BaseWoodBoard
    {
        [Constructable]
        public AshBoard()
            : this(1)
        {
        }

        [Constructable]
        public AshBoard(int amount)
            : base(CraftResource.AshWood, amount)
        {
        }

        public AshBoard(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    public class YewBoard : BaseWoodBoard
    {
        [Constructable]
        public YewBoard()
            : this(1)
        {
        }

        [Constructable]
        public YewBoard(int amount)
            : base(CraftResource.YewWood, amount)
        {
        }

        public YewBoard(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    public class CalcitewoodBoard : BaseWoodBoard
    {
        [Constructable]
        public CalcitewoodBoard()
            : this(1)
        {
        }

        [Constructable]
        public CalcitewoodBoard(int amount)
            : base(CraftResource.Calcitewood, amount)
        {
        }

        public CalcitewoodBoard(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "CalcitewoodBoard"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
    
    public class GoldwoodBoard : BaseWoodBoard
    {
        [Constructable]
        public GoldwoodBoard()
            : this(1)
        {
        }

        [Constructable]
        public GoldwoodBoard(int amount)
            : base(CraftResource.Goldwood, amount)
        {
        }

        public GoldwoodBoard(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "GoldwoodBoard"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
    
    public class LabradoritewoodBoard : BaseWoodBoard
    {
        [Constructable]
        public LabradoritewoodBoard()
            : this(1)
        {
        }

        [Constructable]
        public LabradoritewoodBoard(int amount)
            : base(CraftResource.Labradoritewood, amount)
        {
        }

        public LabradoritewoodBoard(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "LabradoritewoodBoard"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
    
    public class MoldavitewoodBoard : BaseWoodBoard
    {
        [Constructable]
        public MoldavitewoodBoard()
            : this(1)
        {
        }

        [Constructable]
        public MoldavitewoodBoard(int amount)
            : base(CraftResource.Moldavitewood, amount)
        {
        }

        public MoldavitewoodBoard(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "MoldavitewoodBoard"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
    
    public class MorganitewoodBoard : BaseWoodBoard
    {
        [Constructable]
        public MorganitewoodBoard()
            : this(1)
        {
        }

        [Constructable]
        public MorganitewoodBoard(int amount)
            : base(CraftResource.Morganitewood, amount)
        {
        }

        public MorganitewoodBoard(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "MorganitewoodBoard"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
    
    public class QuartzwoodBoard : BaseWoodBoard
    {
        [Constructable]
        public QuartzwoodBoard()
            : this(1)
        {
        }

        [Constructable]
        public QuartzwoodBoard(int amount)
            : base(CraftResource.Quartzwood, amount)
        {
        }

        public QuartzwoodBoard(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "QuartzwoodBoard"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
    
    public class RhodonitewoodBoard : BaseWoodBoard
    {
        [Constructable]
        public RhodonitewoodBoard()
            : this(1)
        {
        }

        [Constructable]
        public RhodonitewoodBoard(int amount)
            : base(CraftResource.Rhodonitewood, amount)
        {
        }

        public RhodonitewoodBoard(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "RhodonitewoodBoard"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    public class RubywoodBoard : BaseWoodBoard
    {
        [Constructable]
        public RubywoodBoard()
            : this(1)
        {
        }

        [Constructable]
        public RubywoodBoard(int amount)
            : base(CraftResource.Rubywood, amount)
        {
        }

        public RubywoodBoard(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "RubywoodBoard"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
    
    public class SapphirewoodBoard : BaseWoodBoard
    {
        [Constructable]
        public SapphirewoodBoard()
            : this(1)
        {
        }

        [Constructable]
        public SapphirewoodBoard(int amount)
            : base(CraftResource.Sapphirewood, amount)
        {
        }

        public SapphirewoodBoard(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "SapphirewoodBoard"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
    
    public class SugilitewoodBoard : BaseWoodBoard
    {
        [Constructable]
        public SugilitewoodBoard()
            : this(1)
        {
        }

        [Constructable]
        public SugilitewoodBoard(int amount)
            : base(CraftResource.Sugilitewood, amount)
        {
        }

        public SugilitewoodBoard(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "SugilitewoodBoard"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
    
    public class TanzanitewoodBoard : BaseWoodBoard
    {
        [Constructable]
        public TanzanitewoodBoard()
            : this(1)
        {
        }

        [Constructable]
        public TanzanitewoodBoard(int amount)
            : base(CraftResource.Tanzanitewood, amount)
        {
        }

        public TanzanitewoodBoard(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "TanzanitewoodBoard"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
    
    public class TurquoisewoodBoard : BaseWoodBoard
    {
        [Constructable]
        public TurquoisewoodBoard()
            : this(1)
        {
        }

        [Constructable]
        public TurquoisewoodBoard(int amount)
            : base(CraftResource.Turquoisewood, amount)
        {
        }

        public TurquoisewoodBoard(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "TurquoisewoodBoard"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
    
    public class VarisitewoodBoard : BaseWoodBoard
    {
        [Constructable]
        public VarisitewoodBoard()
            : this(1)
        {
        }

        [Constructable]
        public VarisitewoodBoard(int amount)
            : base(CraftResource.Varisitewood, amount)
        {
        }

        public VarisitewoodBoard(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "VarisitewoodBoard"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    public class GuardianswoodBoard : BaseWoodBoard
    {
        [Constructable]
        public GuardianswoodBoard()
            : this(1)
        {
        }

        [Constructable]
        public GuardianswoodBoard(int amount)
            : base(CraftResource.Guardianswood, amount)
        {
        }

        public GuardianswoodBoard(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "GuardianswoodBoard"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}