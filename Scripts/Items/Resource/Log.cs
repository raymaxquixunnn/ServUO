using System;

namespace Server.Items
{
	[FlipableAttribute( 0x1bdd, 0x1be0 )]
	public class BaseLog : Item, ICommodity, IAxe
	{
		private CraftResource m_Resource;

		[CommandProperty( AccessLevel.GameMaster )]
		public CraftResource Resource
		{
			get { return m_Resource; }
			set { m_Resource = value; InvalidateProperties(); }
		}

		TextDefinition ICommodity.Description { get { return CraftResources.IsStandard( m_Resource ) ? LabelNumber : 1075062 + ( (int)m_Resource - (int)CraftResource.RegularWood ); } }
		bool ICommodity.IsDeedable { get { return true; } }
		[Constructable]
		public BaseLog() : this( 1 )
		{
		}

		[Constructable]
		public BaseLog( int amount ) : this( CraftResource.RegularWood, amount )
		{
		}

		[Constructable]
		public BaseLog( CraftResource resource )
			: this( resource, 1 )
		{
		}
		[Constructable]
		public BaseLog( CraftResource resource, int amount )
			: base( 0x1BDD )
		{
			Stackable = true;
			Weight = 2.0;
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
		public BaseLog( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 2 ); // version

			writer.Write( (int)m_Resource );
		}

		public static bool UpdatingBaseLogClass;
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if (version == 1)
				UpdatingBaseLogClass = true;
			m_Resource = (CraftResource)reader.ReadInt();

			if ( version == 0 )
				m_Resource = CraftResource.RegularWood;
		}

		public virtual bool TryCreateBoards( Mobile from, double skill, Item item )
		{
			if ( Deleted || !from.CanSee( this ) ) 
				return false;
			if ( from.Skills.Carpentry.Value < skill &&
				from.Skills.Lumberjacking.Value < skill )
			{
				item.Delete();
				from.SendLocalizedMessage( 1072652 ); // You cannot work this strange and unusual wood.
				return false;
			}
			base.ScissorHelper( from, item, 1, false );
			return true;
		}

		public virtual bool Axe( Mobile from, BaseAxe axe )
		{
			if ( !TryCreateBoards( from , 0, new Board() ) )
				return false;
			
			return true;
		}
	}

	public class Log : BaseLog
	{
		[Constructable]
		public Log()
			: this(1)
		{
		}

		[Constructable]
		public Log(int amount)
			: base(CraftResource.RegularWood, amount)
		{
		}

		public Log(Serial serial)
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
			//don't deserialize anything on update
			if (BaseLog.UpdatingBaseLogClass)
				return;

			int version = reader.ReadInt();
		}

		public override bool Axe(Mobile from, BaseAxe axe)
		{
			if (!TryCreateBoards(from, 0, new Board()))
				return false;

			return true;
		}
	}

    public class HeartwoodLog : BaseLog
    {
        [Constructable]
        public HeartwoodLog()
            : this(1)
        {
        }

        [Constructable]
        public HeartwoodLog(int amount)
            : base(CraftResource.Heartwood, amount)
        {
        }

        public HeartwoodLog(Serial serial)
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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 100, new HeartwoodBoard()))
                return false;

            return true;
        }
    }

    public class BloodwoodLog : BaseLog
    {
        [Constructable]
        public BloodwoodLog()
            : this(1)
        {
        }

        [Constructable]
        public BloodwoodLog(int amount)
            : base(CraftResource.Bloodwood, amount)
        {
        }

        public BloodwoodLog(Serial serial)
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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 100, new BloodwoodBoard()))
                return false;

            return true;
        }
    }

    public class FrostwoodLog : BaseLog
    {
        [Constructable]
        public FrostwoodLog()
            : this(1)
        {
        }

        [Constructable]
        public FrostwoodLog(int amount)
            : base(CraftResource.Frostwood, amount)
        {
        }

        public FrostwoodLog(Serial serial)
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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 100, new FrostwoodBoard()))
                return false;

            return true;
        }
    }

    public class OakLog : BaseLog
    {
        [Constructable]
        public OakLog()
            : this(1)
        {
        }

        [Constructable]
        public OakLog(int amount)
            : base(CraftResource.OakWood, amount)
        {
        }

        public OakLog(Serial serial)
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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 65, new OakBoard()))
                return false;

            return true;
        }
    }

    public class AshLog : BaseLog
    {
        [Constructable]
        public AshLog()
            : this(1)
        {
        }

        [Constructable]
        public AshLog(int amount)
            : base(CraftResource.AshWood, amount)
        {
        }

        public AshLog(Serial serial)
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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 80, new AshBoard()))
                return false;

            return true;
        }
    }

    public class YewLog : BaseLog
    {
        [Constructable]
        public YewLog()
            : this(1)
        {
        }

        [Constructable]
        public YewLog(int amount)
            : base(CraftResource.YewWood, amount)
        {
        }

        public YewLog(Serial serial)
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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 95, new YewBoard()))
                return false;

            return true;
        }
    }

    public class CalcitewoodLog : BaseLog
    {
        [Constructable]
        public CalcitewoodLog()
            : this(1)
        {
        }

        [Constructable]
        public CalcitewoodLog(int amount)
            : base(CraftResource.Calcitewood, amount)
        {
        }

        public CalcitewoodLog(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "CalcitewoodLog"; } }

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 95, new CalcitewoodBoard()))
                return false;

            return true;
        }
    }

    public class GoldwoodLog : BaseLog
    {
        [Constructable]
        public GoldwoodLog()
            : this(1)
        {
        }

        [Constructable]
        public GoldwoodLog(int amount)
            : base(CraftResource.Goldwood, amount)
        {
        }

        public GoldwoodLog(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "GoldwoodLog"; } }

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 95, new GoldwoodBoard()))
                return false;

            return true;
        }
    }

    public class LabradoritewoodLog : BaseLog
    {
        [Constructable]
        public LabradoritewoodLog()
            : this(1)
        {
        }

        [Constructable]
        public LabradoritewoodLog(int amount)
            : base(CraftResource.Labradoritewood, amount)
        {
        }

        public LabradoritewoodLog(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "LabradoritewoodLog"; } }

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 95, new LabradoritewoodBoard()))
                return false;

            return true;
        }
    }

    public class MoldavitewoodLog : BaseLog
    {
        [Constructable]
        public MoldavitewoodLog()
            : this(1)
        {
        }

        [Constructable]
        public MoldavitewoodLog(int amount)
            : base(CraftResource.Moldavitewood, amount)
        {
        }

        public MoldavitewoodLog(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "MoldavitewoodLog"; } }

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 95, new MoldavitewoodBoard()))
                return false;

            return true;
        }
    }

    public class MorganitewoodLog : BaseLog
    {
        [Constructable]
        public MorganitewoodLog()
            : this(1)
        {
        }

        [Constructable]
        public MorganitewoodLog(int amount)
            : base(CraftResource.Morganitewood, amount)
        {
        }

        public MorganitewoodLog(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "MorganitewoodLog"; } }

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 95, new MorganitewoodBoard()))
                return false;

            return true;
        }
    }

    public class QuartzwoodLog : BaseLog
    {
        [Constructable]
        public QuartzwoodLog()
            : this(1)
        {
        }

        [Constructable]
        public QuartzwoodLog(int amount)
            : base(CraftResource.Quartzwood, amount)
        {
        }

        public QuartzwoodLog(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "QuartzwoodLog"; } }

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 95, new QuartzwoodBoard()))
                return false;

            return true;
        }
    }

    public class RhodonitewoodLog : BaseLog
    {
        [Constructable]
        public RhodonitewoodLog()
            : this(1)
        {
        }

        [Constructable]
        public RhodonitewoodLog(int amount)
            : base(CraftResource.Rhodonitewood, amount)
        {
        }

        public RhodonitewoodLog(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "RhodonitewoodLog"; } }


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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 95, new RhodonitewoodBoard()))
                return false;

            return true;
        }
    }

    public class RubywoodLog : BaseLog
    {
        [Constructable]
        public RubywoodLog()
            : this(1)
        {
        }

        [Constructable]
        public RubywoodLog(int amount)
            : base(CraftResource.Rubywood, amount)
        {
        }

        public RubywoodLog(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "RubywoodLog"; } }

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 95, new RubywoodBoard()))
                return false;

            return true;
        }
    }

    public class SapphirewoodLog : BaseLog
    {
        [Constructable]
        public SapphirewoodLog()
            : this(1)
        {
        }

        [Constructable]
        public SapphirewoodLog(int amount)
            : base(CraftResource.Sapphirewood, amount)
        {
        }

        public SapphirewoodLog(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "SapphirewoodLog"; } }

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 95, new SapphirewoodBoard()))
                return false;

            return true;
        }
    }

    public class SugilitewoodLog : BaseLog
    {
        [Constructable]
        public SugilitewoodLog()
            : this(1)
        {
        }

        [Constructable]
        public SugilitewoodLog(int amount)
            : base(CraftResource.Sugilitewood, amount)
        {
        }

        public SugilitewoodLog(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "SugilitewoodLog"; } }

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 95, new SugilitewoodBoard()))
                return false;

            return true;
        }
    }

    public class TanzanitewoodLog : BaseLog
    {
        [Constructable]
        public TanzanitewoodLog()
            : this(1)
        {
        }

        [Constructable]
        public TanzanitewoodLog(int amount)
            : base(CraftResource.Tanzanitewood, amount)
        {
        }

        public TanzanitewoodLog(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "TanzanitewoodLog"; } }

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 95, new TanzanitewoodBoard()))
                return false;

            return true;
        }
    }

    public class TurquoisewoodLog : BaseLog
    {
        [Constructable]
        public TurquoisewoodLog()
            : this(1)
        {
        }

        [Constructable]
        public TurquoisewoodLog(int amount)
            : base(CraftResource.Turquoisewood, amount)
        {
        }

        public TurquoisewoodLog(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "TurquoisewoodLog"; } }

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 95, new TurquoisewoodBoard()))
                return false;

            return true;
        }
    }

    public class VarisitewoodLog : BaseLog
    {
        [Constructable]
        public VarisitewoodLog()
            : this(1)
        {
        }

        [Constructable]
        public VarisitewoodLog(int amount)
            : base(CraftResource.Varisitewood, amount)
        {
        }

        public VarisitewoodLog(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "VarisitewoodLog"; } }

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 95, new VarisitewoodBoard()))
                return false;

            return true;
        }
    }

    public class GuardianswoodLog : BaseLog
    {
        [Constructable]
        public GuardianswoodLog()
            : this(1)
        {
        }

        [Constructable]
        public GuardianswoodLog(int amount)
            : base(CraftResource.Guardianswood, amount)
        {
        }

        public GuardianswoodLog(Serial serial)
            : base(serial)
        {
        }

		public override string DefaultName { get { return "GuardianswoodLog"; } }

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!this.TryCreateBoards(from, 95, new GuardianswoodBoard()))
                return false;

            return true;
        }
    }
}