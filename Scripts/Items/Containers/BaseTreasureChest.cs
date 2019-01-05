using System;

namespace Server.Items
{
    public class BaseTreasureChest : LockableContainer
    {
        private TreasureLevel m_TreasureLevel;
        private short m_MaxSpawnTime = 60;
        private short m_MinSpawnTime = 10;
        private TreasureResetTimer m_ResetTimer;
        public BaseTreasureChest(int itemID)
            : this(itemID, TreasureLevel.Level2)
        {
        }

        public BaseTreasureChest(int itemID, TreasureLevel level)
            : base(itemID)
        {
            this.m_TreasureLevel = level;
            this.Locked = true;
            this.Movable = false;

            this.SetLockLevel();
            this.GenerateTreasure();
        }

        public BaseTreasureChest(Serial serial)
            : base(serial)
        {
        }

        public enum TreasureLevel
        {
            Level1,
            Level2,
            Level3,
            Level4,
            Level5,
            Level6,
            Level7,
            Level8,
            Level9,
            Level10,
            Level11,
            Level12,
            Level13,
            Level14,
            Level15,
            Level16,
            Level17,
            Level18,
            Level19,
            Level20,
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public TreasureLevel Level
        {
            get
            {
                return this.m_TreasureLevel;
            }
            set
            {
                this.m_TreasureLevel = value;
            }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public short MaxSpawnTime
        {
            get
            {
                return this.m_MaxSpawnTime;
            }
            set
            {
                this.m_MaxSpawnTime = value;
            }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public short MinSpawnTime
        {
            get
            {
                return this.m_MinSpawnTime;
            }
            set
            {
                this.m_MinSpawnTime = value;
            }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public override bool Locked
        {
            get
            {
                return base.Locked;
            }
            set
            {
                if (base.Locked != value)
                {
                    base.Locked = value;
					
                    if (!value)
                        this.StartResetTimer();
                }
            }
        }
        public override bool IsDecoContainer
        {
            get
            {
                return false;
            }
        }
        public override string DefaultName
        {
            get
            {
                if (this.Locked)
                    return "a locked treasure chest";

                return "a treasure chest";
            }
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
            writer.Write((byte)this.m_TreasureLevel);
            writer.Write(this.m_MinSpawnTime);
            writer.Write(this.m_MaxSpawnTime);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            this.m_TreasureLevel = (TreasureLevel)reader.ReadByte();
            this.m_MinSpawnTime = reader.ReadShort();
            this.m_MaxSpawnTime = reader.ReadShort();

            if (!this.Locked)
                this.StartResetTimer();
        }

        public void ClearContents()
        {
            for (int i = this.Items.Count - 1; i >= 0; --i)
            {
                if (i < this.Items.Count)
                    this.Items[i].Delete();
            }
        }

        public void Reset()
        {
            if (this.m_ResetTimer != null)
            {
                if (this.m_ResetTimer.Running)
                    this.m_ResetTimer.Stop();
            }

            this.Locked = true;
            this.ClearContents();
            this.GenerateTreasure();
        }

        protected virtual void SetLockLevel()
        {
            switch( this.m_TreasureLevel )
            {
                case TreasureLevel.Level1:
                    this.RequiredSkill = this.LockLevel = 30;
                    break;
                case TreasureLevel.Level2:
                    this.RequiredSkill = this.LockLevel = 35;
                    break;
                case TreasureLevel.Level3:
                    this.RequiredSkill = this.LockLevel = 40;
                    break;
                case TreasureLevel.Level4:
                    this.RequiredSkill = this.LockLevel = 45;
                    break;
                case TreasureLevel.Level5:
                    this.RequiredSkill = this.LockLevel = 50;
                    break;
                case TreasureLevel.Level6:
                    this.RequiredSkill = this.LockLevel = 55;
                    break;
                case TreasureLevel.Level7:
                    this.RequiredSkill = this.LockLevel = 60;
                    break;
                case TreasureLevel.Level8:
                    this.RequiredSkill = this.LockLevel = 65;
                    break;
                case TreasureLevel.Level9:
                    this.RequiredSkill = this.LockLevel = 70;
                    break;
                case TreasureLevel.Level10:
                    this.RequiredSkill = this.LockLevel = 75;
                    break;
                case TreasureLevel.Level11:
                    this.RequiredSkill = this.LockLevel = 80;
                    break;
                case TreasureLevel.Level12:
                    this.RequiredSkill = this.LockLevel = 85;
                    break;
                case TreasureLevel.Level13:
                    this.RequiredSkill = this.LockLevel = 90;
                    break;
                case TreasureLevel.Level14:
                    this.RequiredSkill = this.LockLevel = 95;
                    break;
                case TreasureLevel.Level15:
                    this.RequiredSkill = this.LockLevel = 100;
                    break;
                case TreasureLevel.Level16:
                    this.RequiredSkill = this.LockLevel = 110;
                    break;
                case TreasureLevel.Level17:
                    this.RequiredSkill = this.LockLevel = 120;
                    break;
                case TreasureLevel.Level18:
                    this.RequiredSkill = this.LockLevel = 130;
                    break;
                case TreasureLevel.Level19:
                    this.RequiredSkill = this.LockLevel = 140;
                    break;
                case TreasureLevel.Level20:
                    this.RequiredSkill = this.LockLevel = 150;
                    break;
            }
        }

        protected virtual void GenerateTreasure()
        {
            int MinGold = 1;
            int MaxGold = 2;

            switch( this.m_TreasureLevel )
            {
                case TreasureLevel.Level1:
                    MinGold = 3000;
                    MaxGold = 3000;
                    break;
                case TreasureLevel.Level2:
                    MinGold = 6000;
                    MaxGold = 6000;
                    break;
                case TreasureLevel.Level3:
                    MinGold = 9000;
                    MaxGold = 9000;
                    break;
                case TreasureLevel.Level4:
                    MinGold = 12000;
                    MaxGold = 12000;
                    break;
                case TreasureLevel.Level5:
                    MinGold = 150000;
                    MaxGold = 15000;
                    break;
                case TreasureLevel.Level6:
                    MinGold = 18000;
                    MaxGold = 18000;
                    break;
                case TreasureLevel.Level7:
                    MinGold = 21000;
                    MaxGold = 21000;
                    break;
                case TreasureLevel.Level8:
                    MinGold = 24000;
                    MaxGold = 24000;
                    break;
                case TreasureLevel.Level9:
                    MinGold = 27000;
                    MaxGold = 27000;
                    break;
                case TreasureLevel.Level10:
                    MinGold = 30000;
                    MaxGold = 30000;
                    break;
                case TreasureLevel.Level11:
                    MinGold = 33000;
                    MaxGold = 33000;
                    break;
                case TreasureLevel.Level12:
                    MinGold = 36000;
                    MaxGold = 36000;
                    break;
                case TreasureLevel.Level13:
                    MinGold = 39000;
                    MaxGold = 39000;
                    break;
                case TreasureLevel.Level14:
                    MinGold = 42000;
                    MaxGold = 42000;
                    break;
                case TreasureLevel.Level15:
                    MinGold = 45000;
                    MaxGold = 45000;
                    break;
                case TreasureLevel.Level16:
                    MinGold = 48000;
                    MaxGold = 48000;
                    break;
                case TreasureLevel.Level17:
                    MinGold = 51000;
                    MaxGold = 51000;
                    break;
                case TreasureLevel.Level18:
                    MinGold = 54000;
                    MaxGold = 54000;
                    break;
                case TreasureLevel.Level19:
                    MinGold = 57000;
                    MaxGold = 57000;
                    break;
                case TreasureLevel.Level20:
                    MinGold = 60000;
                    MaxGold = 60000;
                    break;
            }

            this.DropItem(new Gold(MinGold, MaxGold));
        }

        private void StartResetTimer()
        {
            if (this.m_ResetTimer == null)
                this.m_ResetTimer = new TreasureResetTimer(this);
            else
                this.m_ResetTimer.Delay = TimeSpan.FromMinutes(Utility.Random(this.m_MinSpawnTime, this.m_MaxSpawnTime));

            this.m_ResetTimer.Start();
        }

        private class TreasureResetTimer : Timer
        {
            private readonly BaseTreasureChest m_Chest;
            public TreasureResetTimer(BaseTreasureChest chest)
                : base(TimeSpan.FromMinutes(Utility.Random(chest.MinSpawnTime, chest.MaxSpawnTime)))
            {
                this.m_Chest = chest;
                this.Priority = TimerPriority.OneMinute;
            }

            protected override void OnTick()
            {
                this.m_Chest.Reset();
            }
        }
        ; 
    }
}