using System;
using System.Collections;

namespace Server.Items
{
    public enum CraftResource
    {
        None = 0,
        Iron = 1,
        DullCopper,
        ShadowIron,
        Copper,
        Bronze,
        Gold,
        Silver,
        Agapite,
        Verite,
        Valorite,
        Uridium,
        Trillium,
        Titanium,
        Platinum,
        Zenite,
        Naquinite,
        Galvinite,
        Trilamide,
        Veramide,
        Zenlamide,
        Guardians,

        RegularLeather = 101,
        SpinedLeather,
        HornedLeather,
        BarbedLeather,
        DullLeather,
        ShadowLeather,
        CopperLeather,
        BronzeLeather,
        GoldenLeather,
        SilverLeather,
        AgapiteLeather,
        VeriteLeather,
        ValoriteLeather,
        UridiumLeather,
        AmberLeather,
        AmethystLeather,
        AragoniteLeather,
        BixbiteLeather,
        BloodLeather,
        AmazonLeather,
        GuardiansLeather,

        RedScales = 201,
        YellowScales,
        BlackScales,
        GreenScales,
        WhiteScales,
        BlueScales,

        RegularWood = 301,
        OakWood,
        AshWood,
        YewWood,
        Heartwood,
        Bloodwood,
        Frostwood,
        Calcitewood,
        Goldwood,
        Labradoritewood,
        Moldavitewood,
        Morganitewood,
        Quartzwood,
        Rhodonitewood,
        Rubywood,
        Sapphirewood,
        Sugilitewood,
        Tanzanitewood,
        Turquoisewood,
        Varisitewood,
        Guardianswood,
    }

    public enum CraftResourceType
    {
        None,
        Metal,
        Leather,
        Scales,
        Wood,
    }

    public class CraftAttributeInfo
    {
        private int m_WeaponFireDamage;
        private int m_WeaponColdDamage;
        private int m_WeaponPoisonDamage;
        private int m_WeaponEnergyDamage;
        private int m_WeaponChaosDamage;
        private int m_WeaponDirectDamage;
        private int m_WeaponDurability;
        private int m_WeaponLuck;
        private int m_WeaponGoldIncrease;
        private int m_WeaponLowerRequirements;
        private int m_WeaponDamage;
        private int m_WeaponHitChance;
        private int m_WeaponHitLifeLeech;
        private int m_WeaponRegenHits;
        private int m_WeaponSwingSpeed;

        private int m_ArmorPhysicalResist;
        private int m_ArmorFireResist;
        private int m_ArmorColdResist;
        private int m_ArmorPoisonResist;
        private int m_ArmorEnergyResist;
        private int m_ArmorDurability;
        private int m_ArmorLuck;
        private int m_ArmorGoldIncrease;
        private int m_ArmorLowerRequirements;
        private int m_ArmorDamage;
        private int m_ArmorHitChance;
        private int m_ArmorRegenHits;
        private int m_ArmorMage;

        private int m_ShieldPhysicalResist;
        private int m_ShieldFireResist;
        private int m_ShieldColdResist;
        private int m_ShieldPoisonResist;
        private int m_ShieldEnergyResist;
        private int m_ShieldPhysicalRandom;
        private int m_ShieldColdRandom;
        private int m_ShieldSpellChanneling;
        private int m_ShieldLuck;
        private int m_ShieldLowerRequirements;
        private int m_ShieldRegenHits;
        private int m_ShieldBonusDex;
        private int m_ShieldBonusStr;
        private int m_ShieldReflectPhys;
        private int m_SelfRepair;

        private int m_OtherSpellChanneling;
        private int m_OtherLuck;
        private int m_OtherRegenHits;
        private int m_OtherLowerRequirements;

        private int m_RunicMinAttributes;
        private int m_RunicMaxAttributes;
        private int m_RunicMinIntensity;
        private int m_RunicMaxIntensity;

        private int AttackChance;
        private int BonusDex;
        private int BonusHits;
        private int BonusInt;
        private int BonusMana;
        private int BonusStam;
        private int BonusStr;
        private int CastRecovery;
        private int CastSpeed;
        private int Cold;
        private int DefendChance;
        private int DurabilityBonus;
        private int Energy;
        private int EnhancePotions;
        private int Fire;
        private int HitColdArea;
        private int HitDispel;
        private int HitEnergyArea;
        private int HitFireArea;
        private int HitFireball;
        private int HitHarm;
        private int HitLeechHits;
        private int HitLeechMana;
        private int HitLeechStam;
        private int HitLightning;
        private int HitLowerAttack;
        private int HitLowerDefend;
        private int HitMagicArrow;
        private int HitPhysicalArea;
        private int HitPoisonArea;
        private int LowerManaCost;
        private int LowerRegCost;
        private int LowerStatReq;
        private int Luck;
        private int MageArmor;
        private int MageWeapon;
        private int NightSight;
        private int Physical;
        private int Poison;
        private int ReflectPhysical;
        private int RegenHits;
        private int RegenMana;
        private int RegenStam;
        private int ResistColdBonus;
        private int ResistEnergyBonus;
        private int ResistFireBonus;
        private int ResistPhysicalBonus;
        private int ResistPoisonBonus;
        private int SelfRepair;
        private int SpellChanneling;
        private int SpellDamage;
        private int UseBestSkill;
        private int WeaponSpeed;
        
        public int WeaponFireDamage { get { return m_WeaponFireDamage; } set { m_WeaponFireDamage = value; } }
        public int WeaponColdDamage { get { return m_WeaponColdDamage; } set { m_WeaponColdDamage = value; } }
        public int WeaponPoisonDamage { get { return m_WeaponPoisonDamage; } set { m_WeaponPoisonDamage = value; } }
        public int WeaponEnergyDamage { get { return m_WeaponEnergyDamage; } set { m_WeaponEnergyDamage = value; } }
        public int WeaponChaosDamage { get { return m_WeaponChaosDamage; } set { m_WeaponChaosDamage = value; } }
        public int WeaponDirectDamage { get { return m_WeaponDirectDamage; } set { m_WeaponDirectDamage = value; } }
        public int WeaponDurability { get { return m_WeaponDurability; } set { m_WeaponDurability = value; } }
        public int WeaponLuck { get { return m_WeaponLuck; } set { m_WeaponLuck = value; } }
        public int WeaponGoldIncrease { get { return m_WeaponGoldIncrease; } set { m_WeaponGoldIncrease = value; } }
        public int WeaponLowerRequirements { get { return m_WeaponLowerRequirements; } set { m_WeaponLowerRequirements = value; } }
        public int WeaponDamage { get { return m_WeaponDamage; } set { m_WeaponDamage = value; } }
        public int WeaponHitChance { get { return m_WeaponHitChance; } set { m_WeaponHitChance = value; } }
        public int WeaponHitLifeLeech { get { return m_WeaponHitLifeLeech; } set { m_WeaponHitLifeLeech = value; } }
        public int WeaponRegenHits { get { return m_WeaponRegenHits; } set { m_WeaponRegenHits = value; } }
        public int WeaponSwingSpeed { get { return m_WeaponSwingSpeed; } set { m_WeaponSwingSpeed = value; } }

        public int ArmorPhysicalResist { get { return m_ArmorPhysicalResist; } set { m_ArmorPhysicalResist = value; } }
        public int ArmorFireResist { get { return m_ArmorFireResist; } set { m_ArmorFireResist = value; } }
        public int ArmorColdResist { get { return m_ArmorColdResist; } set { m_ArmorColdResist = value; } }
        public int ArmorPoisonResist { get { return m_ArmorPoisonResist; } set { m_ArmorPoisonResist = value; } }
        public int ArmorEnergyResist { get { return m_ArmorEnergyResist; } set { m_ArmorEnergyResist = value; } }
        public int ArmorDurability { get { return m_ArmorDurability; } set { m_ArmorDurability = value; } }
        public int ArmorLuck { get { return m_ArmorLuck; } set { m_ArmorLuck = value; } }
        public int ArmorGoldIncrease { get { return m_ArmorGoldIncrease; } set { m_ArmorGoldIncrease = value; } }
        public int ArmorLowerRequirements { get { return m_ArmorLowerRequirements; } set { m_ArmorLowerRequirements = value; } }
        public int ArmorDamage { get { return m_ArmorDamage; } set { m_ArmorDamage = value; } }
        public int ArmorHitChance { get { return m_ArmorHitChance; } set { m_ArmorHitChance = value; } }
        public int ArmorRegenHits { get { return m_ArmorRegenHits; } set { m_ArmorRegenHits = value; } }
        public int ArmorMage { get { return m_ArmorMage; } set { m_ArmorMage = value; } }

        public int ShieldPhysicalResist { get { return m_ShieldPhysicalResist; } set { m_ShieldPhysicalResist = value; } }
        public int ShieldFireResist { get { return m_ShieldFireResist; } set { m_ShieldFireResist = value; } }
        public int ShieldColdResist { get { return m_ShieldColdResist; } set { m_ShieldColdResist = value; } }
        public int ShieldPoisonResist { get { return m_ShieldPoisonResist; } set { m_ShieldPoisonResist = value; } }
        public int ShieldEnergyResist { get { return m_ShieldEnergyResist; } set { m_ShieldEnergyResist = value; } }
        public int ShieldPhysicalRandom { get { return m_ShieldPhysicalRandom; } set { m_ShieldPhysicalRandom = value; } }
        public int ShieldColdRandom { get { return m_ShieldColdRandom; } set { m_ShieldColdRandom = value; } }
        public int ShieldSpellChanneling { get { return m_ShieldSpellChanneling; } set { m_ShieldSpellChanneling = value; } }
        public int ShieldLuck { get { return m_ShieldLuck; } set { m_ShieldLuck = value; } }
        public int ShieldLowerRequirements { get { return m_ShieldLowerRequirements; } set { m_ShieldLowerRequirements = value; } }
        public int ShieldRegenHits { get { return m_ShieldRegenHits; } set { m_ShieldRegenHits = value; } }
        public int ShieldBonusDex { get { return m_ShieldBonusDex; } set { m_ShieldBonusDex = value; } }
        public int ShieldBonusStr { get { return m_ShieldBonusStr; } set { m_ShieldBonusStr = value; } }
        public int ShieldReflectPhys { get { return m_ShieldReflectPhys; } set { m_ShieldReflectPhys = value; } }
        public int ShieldSelfRepair { get { return m_SelfRepair; } set { m_SelfRepair = value; } }

        public int OtherSpellChanneling { get { return m_OtherSpellChanneling; } set { m_OtherSpellChanneling = value; } }
        public int OtherLuck { get { return m_OtherLuck; } set { m_OtherLuck = value; } }
        public int OtherRegenHits { get { return m_OtherRegenHits; } set { m_OtherRegenHits = value; } }
        public int OtherLowerRequirements { get { return m_OtherLowerRequirements; } set { m_OtherLowerRequirements = value; } }

        public int RunicMinAttributes { get { return m_RunicMinAttributes; } set { m_RunicMinAttributes = value; } }
        public int RunicMaxAttributes { get { return m_RunicMaxAttributes; } set { m_RunicMaxAttributes = value; } }
        public int RunicMinIntensity { get { return m_RunicMinIntensity; } set { m_RunicMinIntensity = value; } }
        public int RunicMaxIntensity { get { return m_RunicMaxIntensity; } set { m_RunicMaxIntensity = value; } }

        public CraftAttributeInfo()
        {
        }

        public static readonly CraftAttributeInfo Blank;
        public static readonly CraftAttributeInfo DullCopper, ShadowIron, Copper, Bronze, Gold, Silver, Agapite, Verite, Valorite, Uridium, Trillium, Titanium, Platinum, Zenite, Naquinite, Galvinite, Trilamide, Veramide, Zenlamide, Guardians;
        public static readonly CraftAttributeInfo Spined, Horned, Barbed;
        public static readonly CraftAttributeInfo RedScales, YellowScales, BlackScales, GreenScales, WhiteScales, BlueScales;
        public static readonly CraftAttributeInfo OakWood, AshWood, YewWood, Heartwood, Bloodwood, Frostwood;

        static CraftAttributeInfo()
        {
            Blank = new CraftAttributeInfo();

            CraftAttributeInfo DullCopper = DullCopper = new CraftAttributeInfo();

            DullCopper.m_ArmorColdResist = 3;
            DullCopper.m_ArmorEnergyResist = 3;
            DullCopper.m_ArmorFireResist = 3;
            DullCopper.m_ArmorPhysicalResist = 98;
            DullCopper.m_ArmorPoisonResist = 3;
            DullCopper.m_ArmorDamage = 3;
            DullCopper.m_ArmorDurability = 12;
            DullCopper.m_ArmorGoldIncrease = 12;
            DullCopper.m_ArmorHitChance = 1;
            DullCopper.m_ArmorLowerRequirements = 0;
            DullCopper.m_ArmorMage = 0;
            DullCopper.m_ArmorLuck = 1;
            DullCopper.m_RunicMinAttributes = 1;
            DullCopper.m_RunicMaxAttributes = 2;
            DullCopper.m_RunicMinIntensity = 4;
            DullCopper.m_RunicMaxIntensity = 8;
            DullCopper.m_ShieldColdResist = 3;
            DullCopper.m_ShieldEnergyResist = 3;
            DullCopper.m_ShieldFireResist = 3;
            DullCopper.m_ShieldPhysicalResist = 98;
            DullCopper.m_ShieldPoisonResist = 3;
            DullCopper.m_WeaponChaosDamage = 3;
            DullCopper.m_WeaponColdDamage = 3;
            DullCopper.m_WeaponEnergyDamage = 3;
            DullCopper.m_WeaponFireDamage = 3;
            DullCopper.m_WeaponPoisonDamage = 3;
            DullCopper.m_WeaponDirectDamage = 3;
            DullCopper.m_WeaponDamage = 3;
            DullCopper.m_WeaponDurability = 12;
            DullCopper.m_WeaponGoldIncrease = 12;
            DullCopper.m_WeaponHitChance = 0;
            DullCopper.m_WeaponHitLifeLeech = 1;
            DullCopper.m_WeaponLowerRequirements = 0;
            DullCopper.m_WeaponLuck = 25;
            DullCopper.m_WeaponSwingSpeed = 0;
            DullCopper.m_ArmorRegenHits = 0;
            DullCopper.m_WeaponRegenHits = 0;
            DullCopper.AttackChance = 0;
            DullCopper.BonusDex = 0;
            DullCopper.BonusHits = 0;
            DullCopper.BonusInt = 0;
            DullCopper.BonusMana = 0;
            DullCopper.BonusStam = 0;
            DullCopper.BonusStr = 0;
            DullCopper.CastRecovery = 0;
            DullCopper.CastSpeed = 0;
            DullCopper.Cold = 0;
            DullCopper.DefendChance = 0;
            DullCopper.DurabilityBonus = 5;
            DullCopper.Energy = 0;
            DullCopper.EnhancePotions = 1;
            DullCopper.Fire = 0;
            DullCopper.HitColdArea = 2;
            DullCopper.HitDispel = 2;
            DullCopper.HitEnergyArea = 2;
            DullCopper.HitFireArea = 2;
            DullCopper.HitFireball = 2;
            DullCopper.HitHarm = 2;
            DullCopper.HitLeechHits = 2;
            DullCopper.HitLeechMana = 2;
            DullCopper.HitLeechStam = 2;
            DullCopper.HitLightning = 2;
            DullCopper.HitLowerAttack = 2;
            DullCopper.HitLowerDefend = 2;
            DullCopper.HitMagicArrow = 2;
            DullCopper.HitPhysicalArea = 2;
            DullCopper.HitPoisonArea = 2;
            DullCopper.LowerManaCost = 0;
            DullCopper.LowerRegCost = 1;
            DullCopper.LowerStatReq = 0;
            DullCopper.LowerStatReq = 0;
            DullCopper.Luck = 0;
            DullCopper.MageArmor = 0;
            DullCopper.MageWeapon = 0;
            DullCopper.NightSight = 0;
            DullCopper.Physical = 0;
            DullCopper.Poison = 0;
            DullCopper.ReflectPhysical = 0;
            DullCopper.RegenHits = 0;
            DullCopper.RegenMana = 0;
            DullCopper.RegenStam = 0;
            DullCopper.ResistColdBonus = 0;
            DullCopper.ResistEnergyBonus = 0;
            DullCopper.ResistFireBonus = 0;
            DullCopper.ResistPhysicalBonus = 0;
            DullCopper.ResistPoisonBonus = 0;
            DullCopper.SelfRepair = 0;
            DullCopper.SpellChanneling = 0;
            DullCopper.SpellDamage = 0;
            DullCopper.UseBestSkill = 0;
            DullCopper.WeaponDamage = 1;
            DullCopper.WeaponSpeed = 0;

            CraftAttributeInfo ShadowIron = ShadowIron = new CraftAttributeInfo();

            ShadowIron.m_ArmorColdResist = 6;
            ShadowIron.m_ArmorEnergyResist = 6;
            ShadowIron.m_ArmorFireResist = 6;
            ShadowIron.m_ArmorPhysicalResist = 96;
            ShadowIron.m_ArmorPoisonResist = 6;
            ShadowIron.m_ArmorDamage = 6;
            ShadowIron.m_ArmorDurability = 24;
            ShadowIron.m_ArmorGoldIncrease = 24;
            ShadowIron.m_ArmorHitChance = 2;
            ShadowIron.m_ArmorLowerRequirements = 0;
            ShadowIron.m_ArmorMage = 0;
            ShadowIron.m_ArmorLuck = 2;
            ShadowIron.m_RunicMinAttributes = 3;
            ShadowIron.m_RunicMaxAttributes = 3;
            ShadowIron.m_RunicMinIntensity = 11;
            ShadowIron.m_RunicMaxIntensity = 11;
            ShadowIron.m_ShieldColdResist = 6;
            ShadowIron.m_ShieldEnergyResist = 6;
            ShadowIron.m_ShieldFireResist = 6;
            ShadowIron.m_ShieldPhysicalResist = 96;
            ShadowIron.m_ShieldPoisonResist = 6;
            ShadowIron.m_WeaponChaosDamage = 6;
            ShadowIron.m_WeaponColdDamage = 6;
            ShadowIron.m_WeaponEnergyDamage = 6;
            ShadowIron.m_WeaponFireDamage = 6;
            ShadowIron.m_WeaponPoisonDamage = 6;
            ShadowIron.m_WeaponDirectDamage = 6;
            ShadowIron.m_WeaponDamage = 6;
            ShadowIron.m_WeaponDurability = 24;
            ShadowIron.m_WeaponGoldIncrease = 24;
            ShadowIron.m_WeaponHitChance = 0;
            ShadowIron.m_WeaponHitLifeLeech = 2;
            ShadowIron.m_WeaponLowerRequirements = 0;
            ShadowIron.m_WeaponLuck = 50;
            ShadowIron.m_WeaponSwingSpeed = 0;
            ShadowIron.m_ArmorRegenHits = 0;
            ShadowIron.m_WeaponRegenHits = 0;
            ShadowIron.AttackChance = 1;
            ShadowIron.BonusDex = 0;
            ShadowIron.BonusHits = 0;
            ShadowIron.BonusInt = 0;
            ShadowIron.BonusMana = 0;
            ShadowIron.BonusStam = 0;
            ShadowIron.BonusStr = 0;
            ShadowIron.CastRecovery = 0;
            ShadowIron.CastSpeed = 0;
            ShadowIron.Cold = 1;
            ShadowIron.DefendChance = 1;
            ShadowIron.DurabilityBonus = 10;
            ShadowIron.Energy = 1;
            ShadowIron.EnhancePotions = 2;
            ShadowIron.Fire = 1;
            ShadowIron.HitColdArea = 5;
            ShadowIron.HitDispel = 5;
            ShadowIron.HitEnergyArea = 5;
            ShadowIron.HitFireArea = 5;
            ShadowIron.HitFireball = 5;
            ShadowIron.HitHarm = 5;
            ShadowIron.HitLeechHits = 5;
            ShadowIron.HitLeechMana = 5;
            ShadowIron.HitLeechStam = 5;
            ShadowIron.HitLightning = 5;
            ShadowIron.HitLowerAttack = 5;
            ShadowIron.HitLowerDefend = 5;
            ShadowIron.HitMagicArrow = 5;
            ShadowIron.HitPhysicalArea = 5;
            ShadowIron.HitPoisonArea = 5;
            ShadowIron.LowerManaCost = 0;
            ShadowIron.LowerRegCost = 2;
            ShadowIron.LowerStatReq = 0;
            ShadowIron.LowerStatReq = 0;
            ShadowIron.Luck = 0;
            ShadowIron.MageArmor = 0;
            ShadowIron.MageWeapon = 1;
            ShadowIron.NightSight = 0;
            ShadowIron.Physical = 1;
            ShadowIron.Poison = 1;
            ShadowIron.ReflectPhysical = 1;
            ShadowIron.RegenHits = 0;
            ShadowIron.RegenMana = 0;
            ShadowIron.RegenStam = 0;
            ShadowIron.ResistColdBonus = 1;
            ShadowIron.ResistEnergyBonus = 1;
            ShadowIron.ResistFireBonus = 1;
            ShadowIron.ResistPhysicalBonus = 1;
            ShadowIron.ResistPoisonBonus = 1;
            ShadowIron.SelfRepair = 0;
            ShadowIron.SpellChanneling = 0;
            ShadowIron.SpellDamage = 1;
            ShadowIron.UseBestSkill = 0;
            ShadowIron.WeaponDamage = 2;
            ShadowIron.WeaponSpeed = 0;

            CraftAttributeInfo Copper = Copper = new CraftAttributeInfo();

            Copper.m_ArmorColdResist = 9;
            Copper.m_ArmorEnergyResist = 9;
            Copper.m_ArmorFireResist = 9;
            Copper.m_ArmorPhysicalResist = 94;
            Copper.m_ArmorPoisonResist = 9;
            Copper.m_ArmorDamage = 9;
            Copper.m_ArmorDurability = 36;
            Copper.m_ArmorGoldIncrease = 36;
            Copper.m_ArmorHitChance = 3;
            Copper.m_ArmorLowerRequirements = 0;
            Copper.m_ArmorMage = 0;
            Copper.m_ArmorLuck = 3;
            Copper.m_RunicMinAttributes = 4;
            Copper.m_RunicMaxAttributes = 5;
            Copper.m_RunicMinIntensity = 14;
            Copper.m_RunicMaxIntensity = 18;
            Copper.m_ShieldColdResist = 9;
            Copper.m_ShieldEnergyResist = 9;
            Copper.m_ShieldFireResist = 9;
            Copper.m_ShieldPhysicalResist = 94;
            Copper.m_ShieldPoisonResist = 9;
            Copper.m_WeaponChaosDamage = 9;
            Copper.m_WeaponColdDamage = 9;
            Copper.m_WeaponEnergyDamage = 9;
            Copper.m_WeaponFireDamage = 9;
            Copper.m_WeaponPoisonDamage = 9;
            Copper.m_WeaponDirectDamage = 9;
            Copper.m_WeaponDamage = 9;
            Copper.m_WeaponDurability = 36;
            Copper.m_WeaponGoldIncrease = 36;
            Copper.m_WeaponHitChance = 0;
            Copper.m_WeaponHitLifeLeech = 3;
            Copper.m_WeaponLowerRequirements = 0;
            Copper.m_WeaponLuck = 75;
            Copper.m_WeaponSwingSpeed = 0;
            Copper.m_ArmorRegenHits = 0;
            Copper.m_WeaponRegenHits = 0;
            Copper.AttackChance = 2;
            Copper.BonusDex = 1;
            Copper.BonusHits = 0;
            Copper.BonusInt = 1;
            Copper.BonusMana = 1;
            Copper.BonusStam = 1;
            Copper.BonusStr = 1;
            Copper.CastRecovery = 0;
            Copper.CastSpeed = 0;
            Copper.Cold = 2;
            Copper.DefendChance = 2;
            Copper.DurabilityBonus = 15;
            Copper.Energy = 2;
            Copper.EnhancePotions = 3;
            Copper.Fire = 2;
            Copper.HitColdArea = 7;
            Copper.HitDispel = 7;
            Copper.HitEnergyArea = 7;
            Copper.HitFireArea = 7;
            Copper.HitFireball = 7;
            Copper.HitHarm = 7;
            Copper.HitLeechHits = 7;
            Copper.HitLeechMana = 7;
            Copper.HitLeechStam = 7;
            Copper.HitLightning = 7;
            Copper.HitLowerAttack = 7;
            Copper.HitLowerDefend = 7;
            Copper.HitMagicArrow = 7;
            Copper.HitPhysicalArea = 7;
            Copper.HitPoisonArea = 7;
            Copper.LowerManaCost = 1;
            Copper.LowerRegCost = 3;
            Copper.LowerStatReq = 0;
            Copper.LowerStatReq = 0;
            Copper.Luck = 0;
            Copper.MageArmor = 0;
            Copper.MageWeapon = 1;
            Copper.NightSight = 0;
            Copper.Physical = 2;
            Copper.Poison = 2;
            Copper.ReflectPhysical = 2;
            Copper.RegenHits = 0;
            Copper.RegenMana = 0;
            Copper.RegenStam = 0;
            Copper.ResistColdBonus = 2;
            Copper.ResistEnergyBonus = 2;
            Copper.ResistFireBonus = 2;
            Copper.ResistPhysicalBonus = 2;
            Copper.ResistPoisonBonus = 2;
            Copper.SelfRepair = 0;
            Copper.SpellChanneling = 0;
            Copper.SpellDamage = 1;
            Copper.UseBestSkill = 0;
            Copper.WeaponDamage = 3;
            Copper.WeaponSpeed = 0;

            CraftAttributeInfo Bronze = Bronze = new CraftAttributeInfo();

            Bronze.m_ArmorColdResist = 12;
            Bronze.m_ArmorEnergyResist = 12;
            Bronze.m_ArmorFireResist = 12;
            Bronze.m_ArmorPhysicalResist = 92;
            Bronze.m_ArmorPoisonResist = 12;
            Bronze.m_ArmorDamage = 12;
            Bronze.m_ArmorDurability = 48;
            Bronze.m_ArmorGoldIncrease = 48;
            Bronze.m_ArmorHitChance = 5;
            Bronze.m_ArmorLowerRequirements = 0;
            Bronze.m_ArmorMage = 0;
            Bronze.m_ArmorLuck = 5;
            Bronze.m_RunicMinAttributes = 6;
            Bronze.m_RunicMaxAttributes = 6;
            Bronze.m_RunicMinIntensity = 21;
            Bronze.m_RunicMaxIntensity = 21;
            Bronze.m_ShieldColdResist = 12;
            Bronze.m_ShieldEnergyResist = 12;
            Bronze.m_ShieldFireResist = 12;
            Bronze.m_ShieldPhysicalResist = 92;
            Bronze.m_ShieldPoisonResist = 12;
            Bronze.m_WeaponChaosDamage = 12;
            Bronze.m_WeaponColdDamage = 12;
            Bronze.m_WeaponEnergyDamage = 12;
            Bronze.m_WeaponFireDamage = 12;
            Bronze.m_WeaponPoisonDamage = 12;
            Bronze.m_WeaponDirectDamage = 12;
            Bronze.m_WeaponDamage = 12;
            Bronze.m_WeaponDurability = 48;
            Bronze.m_WeaponGoldIncrease = 48;
            Bronze.m_WeaponHitChance = 1;
            Bronze.m_WeaponHitLifeLeech = 5;
            Bronze.m_WeaponLowerRequirements = 0;
            Bronze.m_WeaponLuck = 100;
            Bronze.m_WeaponSwingSpeed = 0;
            Bronze.m_ArmorRegenHits = 0;
            Bronze.m_WeaponRegenHits = 0;
            Bronze.AttackChance = 3;
            Bronze.BonusDex = 1;
            Bronze.BonusHits = 1;
            Bronze.BonusInt = 1;
            Bronze.BonusMana = 1;
            Bronze.BonusStam = 1;
            Bronze.BonusStr = 1;
            Bronze.CastRecovery = 0;
            Bronze.CastSpeed = 0;
            Bronze.Cold = 3;
            Bronze.DefendChance = 3;
            Bronze.DurabilityBonus = 20;
            Bronze.Energy = 3;
            Bronze.EnhancePotions = 5;
            Bronze.Fire = 3;
            Bronze.HitColdArea = 10;
            Bronze.HitDispel = 10;
            Bronze.HitEnergyArea = 10;
            Bronze.HitFireArea = 10;
            Bronze.HitFireball = 10;
            Bronze.HitHarm = 10;
            Bronze.HitLeechHits = 10;
            Bronze.HitLeechMana = 10;
            Bronze.HitLeechStam = 10;
            Bronze.HitLightning = 10;
            Bronze.HitLowerAttack = 10;
            Bronze.HitLowerDefend = 10;
            Bronze.HitMagicArrow = 10;
            Bronze.HitPhysicalArea = 10;
            Bronze.HitPoisonArea = 10;
            Bronze.LowerManaCost = 1;
            Bronze.LowerRegCost = 4;
            Bronze.LowerStatReq = 0;
            Bronze.LowerStatReq = 0;
            Bronze.Luck = 0;
            Bronze.MageArmor = 0;
            Bronze.MageWeapon = 2;
            Bronze.NightSight = 0;
            Bronze.Physical = 3;
            Bronze.Poison = 3;
            Bronze.ReflectPhysical = 3;
            Bronze.RegenHits = 0;
            Bronze.RegenMana = 0;
            Bronze.RegenStam = 0;
            Bronze.ResistColdBonus = 3;
            Bronze.ResistEnergyBonus = 3;
            Bronze.ResistFireBonus = 3;
            Bronze.ResistPhysicalBonus = 3;
            Bronze.ResistPoisonBonus = 3;
            Bronze.SelfRepair = 1;
            Bronze.SpellChanneling = 0;
            Bronze.SpellDamage = 2;
            Bronze.UseBestSkill = 0;
            Bronze.WeaponDamage = 5;
            Bronze.WeaponSpeed = 0;

            CraftAttributeInfo Gold = Gold = new CraftAttributeInfo();

            Gold.m_ArmorColdResist = 15;
            Gold.m_ArmorEnergyResist = 15;
            Gold.m_ArmorFireResist = 15;
            Gold.m_ArmorPhysicalResist = 90;
            Gold.m_ArmorPoisonResist = 15;
            Gold.m_ArmorDamage = 15;
            Gold.m_ArmorDurability = 60;
            Gold.m_ArmorGoldIncrease = 60;
            Gold.m_ArmorHitChance = 6;
            Gold.m_ArmorLowerRequirements = 0;
            Gold.m_ArmorMage = 0;
            Gold.m_ArmorLuck = 6;
            Gold.m_RunicMinAttributes = 7;
            Gold.m_RunicMaxAttributes = 8;
            Gold.m_RunicMinIntensity = 24;
            Gold.m_RunicMaxIntensity = 27;
            Gold.m_ShieldColdResist = 15;
            Gold.m_ShieldEnergyResist = 15;
            Gold.m_ShieldFireResist = 15;
            Gold.m_ShieldPhysicalResist = 90;
            Gold.m_ShieldPoisonResist = 15;
            Gold.m_WeaponChaosDamage = 15;
            Gold.m_WeaponColdDamage = 15;
            Gold.m_WeaponEnergyDamage = 15;
            Gold.m_WeaponFireDamage = 15;
            Gold.m_WeaponPoisonDamage = 15;
            Gold.m_WeaponDirectDamage = 15;
            Gold.m_WeaponDamage = 15;
            Gold.m_WeaponDurability = 60;
            Gold.m_WeaponGoldIncrease = 60;
            Gold.m_WeaponHitChance = 1;
            Gold.m_WeaponHitLifeLeech = 6;
            Gold.m_WeaponLowerRequirements = 0;
            Gold.m_WeaponLuck = 124;
            Gold.m_WeaponSwingSpeed = 0;
            Gold.m_ArmorRegenHits = 0;
            Gold.m_WeaponRegenHits = 0;
            Gold.AttackChance = 3;
            Gold.BonusDex = 2;
            Gold.BonusHits = 1;
            Gold.BonusInt = 2;
            Gold.BonusMana = 2;
            Gold.BonusStam = 2;
            Gold.BonusStr = 2;
            Gold.CastRecovery = 0;
            Gold.CastSpeed = 0;
            Gold.Cold = 3;
            Gold.DefendChance = 3;
            Gold.DurabilityBonus = 25;
            Gold.Energy = 3;
            Gold.EnhancePotions = 6;
            Gold.Fire = 3;
            Gold.HitColdArea = 12;
            Gold.HitDispel = 12;
            Gold.HitEnergyArea = 12;
            Gold.HitFireArea = 12;
            Gold.HitFireball = 12;
            Gold.HitHarm = 12;
            Gold.HitLeechHits = 12;
            Gold.HitLeechMana = 12;
            Gold.HitLeechStam = 12;
            Gold.HitLightning = 12;
            Gold.HitLowerAttack = 12;
            Gold.HitLowerDefend = 12;
            Gold.HitMagicArrow = 12;
            Gold.HitPhysicalArea = 12;
            Gold.HitPoisonArea = 12;
            Gold.LowerManaCost = 2;
            Gold.LowerRegCost = 5;
            Gold.LowerStatReq = 0;
            Gold.LowerStatReq = 0;
            Gold.Luck = 0;
            Gold.MageArmor = 0;
            Gold.MageWeapon = 2;
            Gold.NightSight = 0;
            Gold.Physical = 3;
            Gold.Poison = 3;
            Gold.ReflectPhysical = 3;
            Gold.RegenHits = 0;
            Gold.RegenMana = 0;
            Gold.RegenStam = 0;
            Gold.ResistColdBonus = 3;
            Gold.ResistEnergyBonus = 3;
            Gold.ResistFireBonus = 3;
            Gold.ResistPhysicalBonus = 3;
            Gold.ResistPoisonBonus = 3;
            Gold.SelfRepair = 1;
            Gold.SpellChanneling = 0;
            Gold.SpellDamage = 3;
            Gold.UseBestSkill = 0;
            Gold.WeaponDamage = 6;
            Gold.WeaponSpeed = 0;

            CraftAttributeInfo Silver = Silver = new CraftAttributeInfo();

            Silver.m_ArmorColdResist = 18;
            Silver.m_ArmorEnergyResist = 18;
            Silver.m_ArmorFireResist = 18;
            Silver.m_ArmorPhysicalResist = 88;
            Silver.m_ArmorPoisonResist = 18;
            Silver.m_ArmorDamage = 18;
            Silver.m_ArmorDurability = 72;
            Silver.m_ArmorGoldIncrease = 72;
            Silver.m_ArmorHitChance = 7;
            Silver.m_ArmorLowerRequirements = 0;
            Silver.m_ArmorMage = 0;
            Silver.m_ArmorLuck = 7;
            Silver.m_RunicMinAttributes = 9;
            Silver.m_RunicMaxAttributes = 9;
            Silver.m_RunicMinIntensity = 31;
            Silver.m_RunicMaxIntensity = 31;
            Silver.m_ShieldColdResist = 18;
            Silver.m_ShieldEnergyResist = 18;
            Silver.m_ShieldFireResist = 18;
            Silver.m_ShieldPhysicalResist = 88;
            Silver.m_ShieldPoisonResist = 18;
            Silver.m_WeaponChaosDamage = 18;
            Silver.m_WeaponColdDamage = 18;
            Silver.m_WeaponEnergyDamage = 18;
            Silver.m_WeaponFireDamage = 18;
            Silver.m_WeaponPoisonDamage = 18;
            Silver.m_WeaponDirectDamage = 18;
            Silver.m_WeaponDamage = 18;
            Silver.m_WeaponDurability = 72;
            Silver.m_WeaponGoldIncrease = 72;
            Silver.m_WeaponHitChance = 1;
            Silver.m_WeaponHitLifeLeech = 7;
            Silver.m_WeaponLowerRequirements = 0;
            Silver.m_WeaponLuck = 149;
            Silver.m_WeaponSwingSpeed = 0;
            Silver.m_ArmorRegenHits = 0;
            Silver.m_WeaponRegenHits = 0;
            Silver.AttackChance = 4;
            Silver.BonusDex = 2;
            Silver.BonusHits = 1;
            Silver.BonusInt = 2;
            Silver.BonusMana = 2;
            Silver.BonusStam = 2;
            Silver.BonusStr = 2;
            Silver.CastRecovery = 0;
            Silver.CastSpeed = 0;
            Silver.Cold = 4;
            Silver.DefendChance = 4;
            Silver.DurabilityBonus = 30;
            Silver.Energy = 4;
            Silver.EnhancePotions = 7;
            Silver.Fire = 4;
            Silver.HitColdArea = 15;
            Silver.HitDispel = 15;
            Silver.HitEnergyArea = 15;
            Silver.HitFireArea = 15;
            Silver.HitFireball = 15;
            Silver.HitHarm = 15;
            Silver.HitLeechHits = 15;
            Silver.HitLeechMana = 15;
            Silver.HitLeechStam = 15;
            Silver.HitLightning = 15;
            Silver.HitLowerAttack = 15;
            Silver.HitLowerDefend = 15;
            Silver.HitMagicArrow = 15;
            Silver.HitPhysicalArea = 15;
            Silver.HitPoisonArea = 15;
            Silver.LowerManaCost = 2;
            Silver.LowerRegCost = 6;
            Silver.LowerStatReq = 0;
            Silver.LowerStatReq = 0;
            Silver.Luck = 0;
            Silver.MageArmor = 0;
            Silver.MageWeapon = 3;
            Silver.NightSight = 0;
            Silver.Physical = 4;
            Silver.Poison = 4;
            Silver.ReflectPhysical = 4;
            Silver.RegenHits = 0;
            Silver.RegenMana = 0;
            Silver.RegenStam = 0;
            Silver.ResistColdBonus = 4;
            Silver.ResistEnergyBonus = 4;
            Silver.ResistFireBonus = 4;
            Silver.ResistPhysicalBonus = 4;
            Silver.ResistPoisonBonus = 4;
            Silver.SelfRepair = 1;
            Silver.SpellChanneling = 0;
            Silver.SpellDamage = 3;
            Silver.UseBestSkill = 0;
            Silver.WeaponDamage = 7;
            Silver.WeaponSpeed = 0;

            CraftAttributeInfo Agapite = Agapite = new CraftAttributeInfo();

            Agapite.m_ArmorColdResist = 21;
            Agapite.m_ArmorEnergyResist = 21;
            Agapite.m_ArmorFireResist = 21;
            Agapite.m_ArmorPhysicalResist = 86;
            Agapite.m_ArmorPoisonResist = 21;
            Agapite.m_ArmorDamage = 21;
            Agapite.m_ArmorDurability = 84;
            Agapite.m_ArmorGoldIncrease = 84;
            Agapite.m_ArmorHitChance = 8;
            Agapite.m_ArmorLowerRequirements = 0;
            Agapite.m_ArmorMage = 0;
            Agapite.m_ArmorLuck = 8;
            Agapite.m_RunicMinAttributes = 10;
            Agapite.m_RunicMaxAttributes = 11;
            Agapite.m_RunicMinIntensity = 34;
            Agapite.m_RunicMaxIntensity = 37;
            Agapite.m_ShieldColdResist = 21;
            Agapite.m_ShieldEnergyResist = 21;
            Agapite.m_ShieldFireResist = 21;
            Agapite.m_ShieldPhysicalResist = 86;
            Agapite.m_ShieldPoisonResist = 21;
            Agapite.m_WeaponChaosDamage = 21;
            Agapite.m_WeaponColdDamage = 21;
            Agapite.m_WeaponEnergyDamage = 21;
            Agapite.m_WeaponFireDamage = 21;
            Agapite.m_WeaponPoisonDamage = 21;
            Agapite.m_WeaponDirectDamage = 21;
            Agapite.m_WeaponDamage = 21;
            Agapite.m_WeaponDurability = 84;
            Agapite.m_WeaponGoldIncrease = 84;
            Agapite.m_WeaponHitChance = 2;
            Agapite.m_WeaponHitLifeLeech = 8;
            Agapite.m_WeaponLowerRequirements = 0;
            Agapite.m_WeaponLuck = 174;
            Agapite.m_WeaponSwingSpeed = 0;
            Agapite.m_ArmorRegenHits = 0;
            Agapite.m_WeaponRegenHits = 0;
            Agapite.AttackChance = 5;
            Agapite.BonusDex = 2;
            Agapite.BonusHits = 1;
            Agapite.BonusInt = 2;
            Agapite.BonusMana = 2;
            Agapite.BonusStam = 2;
            Agapite.BonusStr = 2;
            Agapite.CastRecovery = 1;
            Agapite.CastSpeed = 0;
            Agapite.Cold = 5;
            Agapite.DefendChance = 5;
            Agapite.DurabilityBonus = 35;
            Agapite.Energy = 5;
            Agapite.EnhancePotions = 8;
            Agapite.Fire = 5;
            Agapite.HitColdArea = 17;
            Agapite.HitDispel = 17;
            Agapite.HitEnergyArea = 17;
            Agapite.HitFireArea = 17;
            Agapite.HitFireball = 17;
            Agapite.HitHarm = 17;
            Agapite.HitLeechHits = 17;
            Agapite.HitLeechMana = 17;
            Agapite.HitLeechStam = 17;
            Agapite.HitLightning = 17;
            Agapite.HitLowerAttack = 17;
            Agapite.HitLowerDefend = 17;
            Agapite.HitMagicArrow = 17;
            Agapite.HitPhysicalArea = 17;
            Agapite.HitPoisonArea = 17;
            Agapite.LowerManaCost = 2;
            Agapite.LowerRegCost = 7;
            Agapite.LowerStatReq = 0;
            Agapite.LowerStatReq = 0;
            Agapite.Luck = 0;
            Agapite.MageArmor = 0;
            Agapite.MageWeapon = 3;
            Agapite.NightSight = 0;
            Agapite.Physical = 5;
            Agapite.Poison = 5;
            Agapite.ReflectPhysical = 5;
            Agapite.RegenHits = 0;
            Agapite.RegenMana = 0;
            Agapite.RegenStam = 1;
            Agapite.ResistColdBonus = 5;
            Agapite.ResistEnergyBonus = 5;
            Agapite.ResistFireBonus = 5;
            Agapite.ResistPhysicalBonus = 5;
            Agapite.ResistPoisonBonus = 5;
            Agapite.SelfRepair = 1;
            Agapite.SpellChanneling = 0;
            Agapite.SpellDamage = 4;
            Agapite.UseBestSkill = 0;
            Agapite.WeaponDamage = 8;
            Agapite.WeaponSpeed = 0;

            CraftAttributeInfo Verite = Verite = new CraftAttributeInfo();

            Verite.m_ArmorColdResist = 24;
            Verite.m_ArmorEnergyResist = 24;
            Verite.m_ArmorFireResist = 24;
            Verite.m_ArmorPhysicalResist = 84;
            Verite.m_ArmorPoisonResist = 24;
            Verite.m_ArmorDamage = 24;
            Verite.m_ArmorDurability = 96;
            Verite.m_ArmorGoldIncrease = 96;
            Verite.m_ArmorHitChance = 10;
            Verite.m_ArmorLowerRequirements = 0;
            Verite.m_ArmorMage = 0;
            Verite.m_ArmorLuck = 10;
            Verite.m_RunicMinAttributes = 12;
            Verite.m_RunicMaxAttributes = 12;
            Verite.m_RunicMinIntensity = 41;
            Verite.m_RunicMaxIntensity = 41;
            Verite.m_ShieldColdResist = 24;
            Verite.m_ShieldEnergyResist = 24;
            Verite.m_ShieldFireResist = 24;
            Verite.m_ShieldPhysicalResist = 84;
            Verite.m_ShieldPoisonResist = 24;
            Verite.m_WeaponChaosDamage = 24;
            Verite.m_WeaponColdDamage = 24;
            Verite.m_WeaponEnergyDamage = 24;
            Verite.m_WeaponFireDamage = 24;
            Verite.m_WeaponPoisonDamage = 24;
            Verite.m_WeaponDirectDamage = 24;
            Verite.m_WeaponDamage = 24;
            Verite.m_WeaponDurability = 96;
            Verite.m_WeaponGoldIncrease = 96;
            Verite.m_WeaponHitChance = 2;
            Verite.m_WeaponHitLifeLeech = 10;
            Verite.m_WeaponLowerRequirements = 0;
            Verite.m_WeaponLuck = 199;
            Verite.m_WeaponSwingSpeed = 0;
            Verite.m_ArmorRegenHits = 0;
            Verite.m_WeaponRegenHits = 0;
            Verite.AttackChance = 6;
            Verite.BonusDex = 3;
            Verite.BonusHits = 2;
            Verite.BonusInt = 3;
            Verite.BonusMana = 3;
            Verite.BonusStam = 3;
            Verite.BonusStr = 3;
            Verite.CastRecovery = 1;
            Verite.CastSpeed = 0;
            Verite.Cold = 6;
            Verite.DefendChance = 6;
            Verite.DurabilityBonus = 40;
            Verite.Energy = 6;
            Verite.EnhancePotions = 10;
            Verite.Fire = 6;
            Verite.HitColdArea = 20;
            Verite.HitDispel = 20;
            Verite.HitEnergyArea = 20;
            Verite.HitFireArea = 20;
            Verite.HitFireball = 20;
            Verite.HitHarm = 20;
            Verite.HitLeechHits = 20;
            Verite.HitLeechMana = 20;
            Verite.HitLeechStam = 20;
            Verite.HitLightning = 20;
            Verite.HitLowerAttack = 20;
            Verite.HitLowerDefend = 20;
            Verite.HitMagicArrow = 20;
            Verite.HitPhysicalArea = 20;
            Verite.HitPoisonArea = 20;
            Verite.LowerManaCost = 3;
            Verite.LowerRegCost = 8;
            Verite.LowerStatReq = 0;
            Verite.LowerStatReq = 0;
            Verite.Luck = 0;
            Verite.MageArmor = 0;
            Verite.MageWeapon = 4;
            Verite.NightSight = 0;
            Verite.Physical = 6;
            Verite.Poison = 6;
            Verite.ReflectPhysical = 6;
            Verite.RegenHits = 0;
            Verite.RegenMana = 0;
            Verite.RegenStam = 1;
            Verite.ResistColdBonus = 6;
            Verite.ResistEnergyBonus = 6;
            Verite.ResistFireBonus = 6;
            Verite.ResistPhysicalBonus = 6;
            Verite.ResistPoisonBonus = 6;
            Verite.SelfRepair = 2;
            Verite.SpellChanneling = 0;
            Verite.SpellDamage = 4;
            Verite.UseBestSkill = 0;
            Verite.WeaponDamage = 10;
            Verite.WeaponSpeed = 0;

            CraftAttributeInfo Valorite = Valorite = new CraftAttributeInfo();

            Valorite.m_ArmorColdResist = 27;
            Valorite.m_ArmorEnergyResist = 27;
            Valorite.m_ArmorFireResist = 27;
            Valorite.m_ArmorPhysicalResist = 82;
            Valorite.m_ArmorPoisonResist = 27;
            Valorite.m_ArmorDamage = 27;
            Valorite.m_ArmorDurability = 108;
            Valorite.m_ArmorGoldIncrease = 108;
            Valorite.m_ArmorHitChance = 11;
            Valorite.m_ArmorLowerRequirements = 0;
            Valorite.m_ArmorMage = 0;
            Valorite.m_ArmorLuck = 11;
            Valorite.m_RunicMinAttributes = 13;
            Valorite.m_RunicMaxAttributes = 14;
            Valorite.m_RunicMinIntensity = 44;
            Valorite.m_RunicMaxIntensity = 47;
            Valorite.m_ShieldColdResist = 27;
            Valorite.m_ShieldEnergyResist = 27;
            Valorite.m_ShieldFireResist = 27;
            Valorite.m_ShieldPhysicalResist = 82;
            Valorite.m_ShieldPoisonResist = 27;
            Valorite.m_WeaponChaosDamage = 27;
            Valorite.m_WeaponColdDamage = 27;
            Valorite.m_WeaponEnergyDamage = 27;
            Valorite.m_WeaponFireDamage = 27;
            Valorite.m_WeaponPoisonDamage = 27;
            Valorite.m_WeaponDirectDamage = 27;
            Valorite.m_WeaponDamage = 27;
            Valorite.m_WeaponDurability = 108;
            Valorite.m_WeaponGoldIncrease = 108;
            Valorite.m_WeaponHitChance = 2;
            Valorite.m_WeaponHitLifeLeech = 11;
            Valorite.m_WeaponLowerRequirements = 0;
            Valorite.m_WeaponLuck = 224;
            Valorite.m_WeaponSwingSpeed = 0;
            Valorite.m_ArmorRegenHits = 0;
            Valorite.m_WeaponRegenHits = 0;
            Valorite.AttackChance = 6;
            Valorite.BonusDex = 3;
            Valorite.BonusHits = 2;
            Valorite.BonusInt = 3;
            Valorite.BonusMana = 3;
            Valorite.BonusStam = 3;
            Valorite.BonusStr = 3;
            Valorite.CastRecovery = 1;
            Valorite.CastSpeed = 0;
            Valorite.Cold = 6;
            Valorite.DefendChance = 6;
            Valorite.DurabilityBonus = 45;
            Valorite.Energy = 6;
            Valorite.EnhancePotions = 11;
            Valorite.Fire = 6;
            Valorite.HitColdArea = 22;
            Valorite.HitDispel = 22;
            Valorite.HitEnergyArea = 22;
            Valorite.HitFireArea = 22;
            Valorite.HitFireball = 22;
            Valorite.HitHarm = 22;
            Valorite.HitLeechHits = 22;
            Valorite.HitLeechMana = 22;
            Valorite.HitLeechStam = 22;
            Valorite.HitLightning = 22;
            Valorite.HitLowerAttack = 22;
            Valorite.HitLowerDefend = 22;
            Valorite.HitMagicArrow = 22;
            Valorite.HitPhysicalArea = 22;
            Valorite.HitPoisonArea = 22;
            Valorite.LowerManaCost = 3;
            Valorite.LowerRegCost = 9;
            Valorite.LowerStatReq = 0;
            Valorite.LowerStatReq = 0;
            Valorite.Luck = 0;
            Valorite.MageArmor = 0;
            Valorite.MageWeapon = 4;
            Valorite.NightSight = 0;
            Valorite.Physical = 6;
            Valorite.Poison = 6;
            Valorite.ReflectPhysical = 6;
            Valorite.RegenHits = 0;
            Valorite.RegenMana = 0;
            Valorite.RegenStam = 1;
            Valorite.ResistColdBonus = 6;
            Valorite.ResistEnergyBonus = 6;
            Valorite.ResistFireBonus = 6;
            Valorite.ResistPhysicalBonus = 6;
            Valorite.ResistPoisonBonus = 6;
            Valorite.SelfRepair = 2;
            Valorite.SpellChanneling = 0;
            Valorite.SpellDamage = 5;
            Valorite.UseBestSkill = 0;
            Valorite.WeaponDamage = 11;
            Valorite.WeaponSpeed = 0;

            CraftAttributeInfo Uridium = Uridium = new CraftAttributeInfo();

            Uridium.m_ArmorColdResist = 30;
            Uridium.m_ArmorEnergyResist = 30;
            Uridium.m_ArmorFireResist = 30;
            Uridium.m_ArmorPhysicalResist = 80;
            Uridium.m_ArmorPoisonResist = 30;
            Uridium.m_ArmorDamage = 30;
            Uridium.m_ArmorDurability = 120;
            Uridium.m_ArmorGoldIncrease = 120;
            Uridium.m_ArmorHitChance = 12;
            Uridium.m_ArmorLowerRequirements = 0;
            Uridium.m_ArmorMage = 0;
            Uridium.m_ArmorLuck = 12;
            Uridium.m_RunicMinAttributes = 15;
            Uridium.m_RunicMaxAttributes = 15;
            Uridium.m_RunicMinIntensity = 51;
            Uridium.m_RunicMaxIntensity = 51;
            Uridium.m_ShieldColdResist = 30;
            Uridium.m_ShieldEnergyResist = 30;
            Uridium.m_ShieldFireResist = 30;
            Uridium.m_ShieldPhysicalResist = 80;
            Uridium.m_ShieldPoisonResist = 30;
            Uridium.m_WeaponChaosDamage = 30;
            Uridium.m_WeaponColdDamage = 30;
            Uridium.m_WeaponEnergyDamage = 30;
            Uridium.m_WeaponFireDamage = 30;
            Uridium.m_WeaponPoisonDamage = 30;
            Uridium.m_WeaponDirectDamage = 30;
            Uridium.m_WeaponDamage = 30;
            Uridium.m_WeaponDurability = 120;
            Uridium.m_WeaponGoldIncrease = 120;
            Uridium.m_WeaponHitChance = 3;
            Uridium.m_WeaponHitLifeLeech = 12;
            Uridium.m_WeaponLowerRequirements = 0;
            Uridium.m_WeaponLuck = 249;
            Uridium.m_WeaponSwingSpeed = 0;
            Uridium.m_ArmorRegenHits = 0;
            Uridium.m_WeaponRegenHits = 0;
            Uridium.AttackChance = 7;
            Uridium.BonusDex = 4;
            Uridium.BonusHits = 2;
            Uridium.BonusInt = 4;
            Uridium.BonusMana = 4;
            Uridium.BonusStam = 4;
            Uridium.BonusStr = 4;
            Uridium.CastRecovery = 1;
            Uridium.CastSpeed = 0;
            Uridium.Cold = 7;
            Uridium.DefendChance = 7;
            Uridium.DurabilityBonus = 50;
            Uridium.Energy = 7;
            Uridium.EnhancePotions = 12;
            Uridium.Fire = 7;
            Uridium.HitColdArea = 25;
            Uridium.HitDispel = 25;
            Uridium.HitEnergyArea = 25;
            Uridium.HitFireArea = 25;
            Uridium.HitFireball = 25;
            Uridium.HitHarm = 25;
            Uridium.HitLeechHits = 25;
            Uridium.HitLeechMana = 25;
            Uridium.HitLeechStam = 25;
            Uridium.HitLightning = 25;
            Uridium.HitLowerAttack = 25;
            Uridium.HitLowerDefend = 25;
            Uridium.HitMagicArrow = 25;
            Uridium.HitPhysicalArea = 25;
            Uridium.HitPoisonArea = 25;
            Uridium.LowerManaCost = 4;
            Uridium.LowerRegCost = 10;
            Uridium.LowerStatReq = 0;
            Uridium.LowerStatReq = 0;
            Uridium.Luck = 0;
            Uridium.MageArmor = 0;
            Uridium.MageWeapon = 5;
            Uridium.NightSight = 0;
            Uridium.Physical = 7;
            Uridium.Poison = 7;
            Uridium.ReflectPhysical = 7;
            Uridium.RegenHits = 1;
            Uridium.RegenMana = 1;
            Uridium.RegenStam = 1;
            Uridium.ResistColdBonus = 7;
            Uridium.ResistEnergyBonus = 7;
            Uridium.ResistFireBonus = 7;
            Uridium.ResistPhysicalBonus = 7;
            Uridium.ResistPoisonBonus = 7;
            Uridium.SelfRepair = 2;
            Uridium.SpellChanneling = 0;
            Uridium.SpellDamage = 6;
            Uridium.UseBestSkill = 0;
            Uridium.WeaponDamage = 12;
            Uridium.WeaponSpeed = 0;

            CraftAttributeInfo Trillium = Trillium = new CraftAttributeInfo();

            Trillium.m_ArmorColdResist = 33;
            Trillium.m_ArmorEnergyResist = 33;
            Trillium.m_ArmorFireResist = 33;
            Trillium.m_ArmorPhysicalResist = 78;
            Trillium.m_ArmorPoisonResist = 33;
            Trillium.m_ArmorDamage = 33;
            Trillium.m_ArmorDurability = 132;
            Trillium.m_ArmorGoldIncrease = 132;
            Trillium.m_ArmorHitChance = 13;
            Trillium.m_ArmorLowerRequirements = 0;
            Trillium.m_ArmorMage = 0;
            Trillium.m_ArmorLuck = 13;
            Trillium.m_RunicMinAttributes = 16;
            Trillium.m_RunicMaxAttributes = 17;
            Trillium.m_RunicMinIntensity = 54;
            Trillium.m_RunicMaxIntensity = 57;
            Trillium.m_ShieldColdResist = 33;
            Trillium.m_ShieldEnergyResist = 33;
            Trillium.m_ShieldFireResist = 33;
            Trillium.m_ShieldPhysicalResist = 78;
            Trillium.m_ShieldPoisonResist = 33;
            Trillium.m_WeaponChaosDamage = 33;
            Trillium.m_WeaponColdDamage = 33;
            Trillium.m_WeaponEnergyDamage = 33;
            Trillium.m_WeaponFireDamage = 33;
            Trillium.m_WeaponPoisonDamage = 33;
            Trillium.m_WeaponDirectDamage = 33;
            Trillium.m_WeaponDamage = 33;
            Trillium.m_WeaponDurability = 132;
            Trillium.m_WeaponGoldIncrease = 132;
            Trillium.m_WeaponHitChance = 3;
            Trillium.m_WeaponHitLifeLeech = 13;
            Trillium.m_WeaponLowerRequirements = 0;
            Trillium.m_WeaponLuck = 274;
            Trillium.m_WeaponSwingSpeed = 0;
            Trillium.m_ArmorRegenHits = 0;
            Trillium.m_WeaponRegenHits = 0;
            Trillium.AttackChance = 8;
            Trillium.BonusDex = 4;
            Trillium.BonusHits = 2;
            Trillium.BonusInt = 4;
            Trillium.BonusMana = 4;
            Trillium.BonusStam = 4;
            Trillium.BonusStr = 4;
            Trillium.CastRecovery = 1;
            Trillium.CastSpeed = 0;
            Trillium.Cold = 8;
            Trillium.DefendChance = 8;
            Trillium.DurabilityBonus = 55;
            Trillium.Energy = 8;
            Trillium.EnhancePotions = 13;
            Trillium.Fire = 8;
            Trillium.HitColdArea = 27;
            Trillium.HitDispel = 27;
            Trillium.HitEnergyArea = 27;
            Trillium.HitFireArea = 27;
            Trillium.HitFireball = 27;
            Trillium.HitHarm = 27;
            Trillium.HitLeechHits = 27;
            Trillium.HitLeechMana = 27;
            Trillium.HitLeechStam = 27;
            Trillium.HitLightning = 27;
            Trillium.HitLowerAttack = 27;
            Trillium.HitLowerDefend = 27;
            Trillium.HitMagicArrow = 27;
            Trillium.HitPhysicalArea = 27;
            Trillium.HitPoisonArea = 27;
            Trillium.LowerManaCost = 4;
            Trillium.LowerRegCost = 11;
            Trillium.LowerStatReq = 0;
            Trillium.LowerStatReq = 0;
            Trillium.Luck = 0;
            Trillium.MageArmor = 0;
            Trillium.MageWeapon = 5;
            Trillium.NightSight = 0;
            Trillium.Physical = 8;
            Trillium.Poison = 8;
            Trillium.ReflectPhysical = 8;
            Trillium.RegenHits = 1;
            Trillium.RegenMana = 1;
            Trillium.RegenStam = 1;
            Trillium.ResistColdBonus = 8;
            Trillium.ResistEnergyBonus = 8;
            Trillium.ResistFireBonus = 8;
            Trillium.ResistPhysicalBonus = 8;
            Trillium.ResistPoisonBonus = 8;
            Trillium.SelfRepair = 2;
            Trillium.SpellChanneling = 0;
            Trillium.SpellDamage = 6;
            Trillium.UseBestSkill = 0;
            Trillium.WeaponDamage = 13;
            Trillium.WeaponSpeed = 0;

            CraftAttributeInfo Titanium = Titanium = new CraftAttributeInfo();

            Titanium.m_ArmorColdResist = 36;
            Titanium.m_ArmorEnergyResist = 36;
            Titanium.m_ArmorFireResist = 36;
            Titanium.m_ArmorPhysicalResist = 76;
            Titanium.m_ArmorPoisonResist = 36;
            Titanium.m_ArmorDamage = 36;
            Titanium.m_ArmorDurability = 144;
            Titanium.m_ArmorGoldIncrease = 144;
            Titanium.m_ArmorHitChance = 15;
            Titanium.m_ArmorLowerRequirements = 0;
            Titanium.m_ArmorMage = 0;
            Titanium.m_ArmorLuck = 15;
            Titanium.m_RunicMinAttributes = 18;
            Titanium.m_RunicMaxAttributes = 18;
            Titanium.m_RunicMinIntensity = 60;
            Titanium.m_RunicMaxIntensity = 60;
            Titanium.m_ShieldColdResist = 36;
            Titanium.m_ShieldEnergyResist = 36;
            Titanium.m_ShieldFireResist = 36;
            Titanium.m_ShieldPhysicalResist = 76;
            Titanium.m_ShieldPoisonResist = 36;
            Titanium.m_WeaponChaosDamage = 36;
            Titanium.m_WeaponColdDamage = 36;
            Titanium.m_WeaponEnergyDamage = 36;
            Titanium.m_WeaponFireDamage = 36;
            Titanium.m_WeaponPoisonDamage = 36;
            Titanium.m_WeaponDirectDamage = 36;
            Titanium.m_WeaponDamage = 36;
            Titanium.m_WeaponDurability = 144;
            Titanium.m_WeaponGoldIncrease = 144;
            Titanium.m_WeaponHitChance = 3;
            Titanium.m_WeaponHitLifeLeech = 15;
            Titanium.m_WeaponLowerRequirements = 0;
            Titanium.m_WeaponLuck = 299;
            Titanium.m_WeaponSwingSpeed = 0;
            Titanium.m_ArmorRegenHits = 0;
            Titanium.m_WeaponRegenHits = 0;
            Titanium.AttackChance = 9;
            Titanium.BonusDex = 4;
            Titanium.BonusHits = 3;
            Titanium.BonusInt = 4;
            Titanium.BonusMana = 4;
            Titanium.BonusStam = 4;
            Titanium.BonusStr = 4;
            Titanium.CastRecovery = 1;
            Titanium.CastSpeed = 0;
            Titanium.Cold = 9;
            Titanium.DefendChance = 9;
            Titanium.DurabilityBonus = 60;
            Titanium.Energy = 9;
            Titanium.EnhancePotions = 15;
            Titanium.Fire = 9;
            Titanium.HitColdArea = 30;
            Titanium.HitDispel = 30;
            Titanium.HitEnergyArea = 30;
            Titanium.HitFireArea = 30;
            Titanium.HitFireball = 30;
            Titanium.HitHarm = 30;
            Titanium.HitLeechHits = 30;
            Titanium.HitLeechMana = 30;
            Titanium.HitLeechStam = 30;
            Titanium.HitLightning = 30;
            Titanium.HitLowerAttack = 30;
            Titanium.HitLowerDefend = 30;
            Titanium.HitMagicArrow = 30;
            Titanium.HitPhysicalArea = 30;
            Titanium.HitPoisonArea = 30;
            Titanium.LowerManaCost = 4;
            Titanium.LowerRegCost = 12;
            Titanium.LowerStatReq = 0;
            Titanium.LowerStatReq = 0;
            Titanium.Luck = 0;
            Titanium.MageArmor = 0;
            Titanium.MageWeapon = 6;
            Titanium.NightSight = 0;
            Titanium.Physical = 9;
            Titanium.Poison = 9;
            Titanium.ReflectPhysical = 9;
            Titanium.RegenHits = 1;
            Titanium.RegenMana = 1;
            Titanium.RegenStam = 1;
            Titanium.ResistColdBonus = 9;
            Titanium.ResistEnergyBonus = 9;
            Titanium.ResistFireBonus = 9;
            Titanium.ResistPhysicalBonus = 9;
            Titanium.ResistPoisonBonus = 9;
            Titanium.SelfRepair = 3;
            Titanium.SpellChanneling = 0;
            Titanium.SpellDamage = 7;
            Titanium.UseBestSkill = 0;
            Titanium.WeaponDamage = 15;
            Titanium.WeaponSpeed = 0;

            CraftAttributeInfo Platinum = Platinum = new CraftAttributeInfo();

            Platinum.m_ArmorColdResist = 39;
            Platinum.m_ArmorEnergyResist = 39;
            Platinum.m_ArmorFireResist = 39;
            Platinum.m_ArmorPhysicalResist = 74;
            Platinum.m_ArmorPoisonResist = 39;
            Platinum.m_ArmorDamage = 39;
            Platinum.m_ArmorDurability = 156;
            Platinum.m_ArmorGoldIncrease = 156;
            Platinum.m_ArmorHitChance = 16;
            Platinum.m_ArmorLowerRequirements = 0;
            Platinum.m_ArmorMage = 0;
            Platinum.m_ArmorLuck = 16;
            Platinum.m_RunicMinAttributes = 19;
            Platinum.m_RunicMaxAttributes = 20;
            Platinum.m_RunicMinIntensity = 64;
            Platinum.m_RunicMaxIntensity = 67;
            Platinum.m_ShieldColdResist = 39;
            Platinum.m_ShieldEnergyResist = 39;
            Platinum.m_ShieldFireResist = 39;
            Platinum.m_ShieldPhysicalResist = 74;
            Platinum.m_ShieldPoisonResist = 39;
            Platinum.m_WeaponChaosDamage = 39;
            Platinum.m_WeaponColdDamage = 39;
            Platinum.m_WeaponEnergyDamage = 39;
            Platinum.m_WeaponFireDamage = 39;
            Platinum.m_WeaponPoisonDamage = 39;
            Platinum.m_WeaponDirectDamage = 39;
            Platinum.m_WeaponDamage = 39;
            Platinum.m_WeaponDurability = 156;
            Platinum.m_WeaponGoldIncrease = 156;
            Platinum.m_WeaponHitChance = 3;
            Platinum.m_WeaponHitLifeLeech = 16;
            Platinum.m_WeaponLowerRequirements = 0;
            Platinum.m_WeaponLuck = 324;
            Platinum.m_WeaponSwingSpeed = 0;
            Platinum.m_ArmorRegenHits = 0;
            Platinum.m_WeaponRegenHits = 0;
            Platinum.AttackChance = 9;
            Platinum.BonusDex = 5;
            Platinum.BonusHits = 3;
            Platinum.BonusInt = 5;
            Platinum.BonusMana = 5;
            Platinum.BonusStam = 5;
            Platinum.BonusStr = 5;
            Platinum.CastRecovery = 1;
            Platinum.CastSpeed = 0;
            Platinum.Cold = 9;
            Platinum.DefendChance = 9;
            Platinum.DurabilityBonus = 65;
            Platinum.Energy = 9;
            Platinum.EnhancePotions = 16;
            Platinum.Fire = 9;
            Platinum.HitColdArea = 32;
            Platinum.HitDispel = 32;
            Platinum.HitEnergyArea = 32;
            Platinum.HitFireArea = 32;
            Platinum.HitFireball = 32;
            Platinum.HitHarm = 32;
            Platinum.HitLeechHits = 32;
            Platinum.HitLeechMana = 32;
            Platinum.HitLeechStam = 32;
            Platinum.HitLightning = 32;
            Platinum.HitLowerAttack = 32;
            Platinum.HitLowerDefend = 32;
            Platinum.HitMagicArrow = 32;
            Platinum.HitPhysicalArea = 32;
            Platinum.HitPoisonArea = 32;
            Platinum.LowerManaCost = 5;
            Platinum.LowerRegCost = 13;
            Platinum.LowerStatReq = 0;
            Platinum.LowerStatReq = 0;
            Platinum.Luck = 0;
            Platinum.MageArmor = 0;
            Platinum.MageWeapon = 6;
            Platinum.NightSight = 0;
            Platinum.Physical = 9;
            Platinum.Poison = 9;
            Platinum.ReflectPhysical = 9;
            Platinum.RegenHits = 1;
            Platinum.RegenMana = 1;
            Platinum.RegenStam = 1;
            Platinum.ResistColdBonus = 9;
            Platinum.ResistEnergyBonus = 9;
            Platinum.ResistFireBonus = 9;
            Platinum.ResistPhysicalBonus = 9;
            Platinum.ResistPoisonBonus = 9;
            Platinum.SelfRepair = 3;
            Platinum.SpellChanneling = 0;
            Platinum.SpellDamage = 7;
            Platinum.UseBestSkill = 0;
            Platinum.WeaponDamage = 16;
            Platinum.WeaponSpeed = 0;

            CraftAttributeInfo Zenite = Zenite = new CraftAttributeInfo();

            Zenite.m_ArmorColdResist = 42;
            Zenite.m_ArmorEnergyResist = 42;
            Zenite.m_ArmorFireResist = 42;
            Zenite.m_ArmorPhysicalResist = 72;
            Zenite.m_ArmorPoisonResist = 42;
            Zenite.m_ArmorDamage = 42;
            Zenite.m_ArmorDurability = 168;
            Zenite.m_ArmorGoldIncrease = 168;
            Zenite.m_ArmorHitChance = 17;
            Zenite.m_ArmorLowerRequirements = 0;
            Zenite.m_ArmorMage = 0;
            Zenite.m_ArmorLuck = 17;
            Zenite.m_RunicMinAttributes = 21;
            Zenite.m_RunicMaxAttributes = 21;
            Zenite.m_RunicMinIntensity = 70;
            Zenite.m_RunicMaxIntensity = 70;
            Zenite.m_ShieldColdResist = 42;
            Zenite.m_ShieldEnergyResist = 42;
            Zenite.m_ShieldFireResist = 42;
            Zenite.m_ShieldPhysicalResist = 72;
            Zenite.m_ShieldPoisonResist = 42;
            Zenite.m_WeaponChaosDamage = 42;
            Zenite.m_WeaponColdDamage = 42;
            Zenite.m_WeaponEnergyDamage = 42;
            Zenite.m_WeaponFireDamage = 42;
            Zenite.m_WeaponPoisonDamage = 42;
            Zenite.m_WeaponDirectDamage = 42;
            Zenite.m_WeaponDamage = 42;
            Zenite.m_WeaponDurability = 168;
            Zenite.m_WeaponGoldIncrease = 168;
            Zenite.m_WeaponHitChance = 4;
            Zenite.m_WeaponHitLifeLeech = 17;
            Zenite.m_WeaponLowerRequirements = 0;
            Zenite.m_WeaponLuck = 348;
            Zenite.m_WeaponSwingSpeed = 0;
            Zenite.m_ArmorRegenHits = 0;
            Zenite.m_WeaponRegenHits = 0;
            Zenite.AttackChance = 10;
            Zenite.BonusDex = 5;
            Zenite.BonusHits = 3;
            Zenite.BonusInt = 5;
            Zenite.BonusMana = 5;
            Zenite.BonusStam = 5;
            Zenite.BonusStr = 5;
            Zenite.CastRecovery = 2;
            Zenite.CastSpeed = 0;
            Zenite.Cold = 10;
            Zenite.DefendChance = 10;
            Zenite.DurabilityBonus = 70;
            Zenite.Energy = 10;
            Zenite.EnhancePotions = 17;
            Zenite.Fire = 10;
            Zenite.HitColdArea = 35;
            Zenite.HitDispel = 35;
            Zenite.HitEnergyArea = 35;
            Zenite.HitFireArea = 35;
            Zenite.HitFireball = 35;
            Zenite.HitHarm = 35;
            Zenite.HitLeechHits = 35;
            Zenite.HitLeechMana = 35;
            Zenite.HitLeechStam = 35;
            Zenite.HitLightning = 35;
            Zenite.HitLowerAttack = 35;
            Zenite.HitLowerDefend = 35;
            Zenite.HitMagicArrow = 35;
            Zenite.HitPhysicalArea = 35;
            Zenite.HitPoisonArea = 35;
            Zenite.LowerManaCost = 5;
            Zenite.LowerRegCost = 14;
            Zenite.LowerStatReq = 0;
            Zenite.LowerStatReq = 0;
            Zenite.Luck = 0;
            Zenite.MageArmor = 0;
            Zenite.MageWeapon = 7;
            Zenite.NightSight = 0;
            Zenite.Physical = 10;
            Zenite.Poison = 10;
            Zenite.ReflectPhysical = 10;
            Zenite.RegenHits = 1;
            Zenite.RegenMana = 1;
            Zenite.RegenStam = 2;
            Zenite.ResistColdBonus = 10;
            Zenite.ResistEnergyBonus = 10;
            Zenite.ResistFireBonus = 10;
            Zenite.ResistPhysicalBonus = 10;
            Zenite.ResistPoisonBonus = 10;
            Zenite.SelfRepair = 3;
            Zenite.SpellChanneling = 0;
            Zenite.SpellDamage = 8;
            Zenite.UseBestSkill = 0;
            Zenite.WeaponDamage = 17;
            Zenite.WeaponSpeed = 0;

            CraftAttributeInfo Naquinite = Naquinite = new CraftAttributeInfo();

            Naquinite.m_ArmorColdResist = 45;
            Naquinite.m_ArmorEnergyResist = 45;
            Naquinite.m_ArmorFireResist = 45;
            Naquinite.m_ArmorPhysicalResist = 70;
            Naquinite.m_ArmorPoisonResist = 45;
            Naquinite.m_ArmorDamage = 45;
            Naquinite.m_ArmorDurability = 180;
            Naquinite.m_ArmorGoldIncrease = 180;
            Naquinite.m_ArmorHitChance = 18;
            Naquinite.m_ArmorLowerRequirements = 0;
            Naquinite.m_ArmorMage = 0;
            Naquinite.m_ArmorLuck = 18;
            Naquinite.m_RunicMinAttributes = 22;
            Naquinite.m_RunicMaxAttributes = 23;
            Naquinite.m_RunicMinIntensity = 74;
            Naquinite.m_RunicMaxIntensity = 77;
            Naquinite.m_ShieldColdResist = 45;
            Naquinite.m_ShieldEnergyResist = 45;
            Naquinite.m_ShieldFireResist = 45;
            Naquinite.m_ShieldPhysicalResist = 70;
            Naquinite.m_ShieldPoisonResist = 45;
            Naquinite.m_WeaponChaosDamage = 45;
            Naquinite.m_WeaponColdDamage = 45;
            Naquinite.m_WeaponEnergyDamage = 45;
            Naquinite.m_WeaponFireDamage = 45;
            Naquinite.m_WeaponPoisonDamage = 45;
            Naquinite.m_WeaponDirectDamage = 45;
            Naquinite.m_WeaponDamage = 45;
            Naquinite.m_WeaponDurability = 180;
            Naquinite.m_WeaponGoldIncrease = 180;
            Naquinite.m_WeaponHitChance = 4;
            Naquinite.m_WeaponHitLifeLeech = 18;
            Naquinite.m_WeaponLowerRequirements = 0;
            Naquinite.m_WeaponLuck = 373;
            Naquinite.m_WeaponSwingSpeed = 0;
            Naquinite.m_ArmorRegenHits = 0;
            Naquinite.m_WeaponRegenHits = 0;
            Naquinite.AttackChance = 11;
            Naquinite.BonusDex = 6;
            Naquinite.BonusHits = 3;
            Naquinite.BonusInt = 6;
            Naquinite.BonusMana = 6;
            Naquinite.BonusStam = 6;
            Naquinite.BonusStr = 6;
            Naquinite.CastRecovery = 2;
            Naquinite.CastSpeed = 0;
            Naquinite.Cold = 11;
            Naquinite.DefendChance = 11;
            Naquinite.DurabilityBonus = 75;
            Naquinite.Energy = 11;
            Naquinite.EnhancePotions = 18;
            Naquinite.Fire = 11;
            Naquinite.HitColdArea = 37;
            Naquinite.HitDispel = 37;
            Naquinite.HitEnergyArea = 37;
            Naquinite.HitFireArea = 37;
            Naquinite.HitFireball = 37;
            Naquinite.HitHarm = 37;
            Naquinite.HitLeechHits = 37;
            Naquinite.HitLeechMana = 37;
            Naquinite.HitLeechStam = 37;
            Naquinite.HitLightning = 37;
            Naquinite.HitLowerAttack = 37;
            Naquinite.HitLowerDefend = 37;
            Naquinite.HitMagicArrow = 37;
            Naquinite.HitPhysicalArea = 37;
            Naquinite.HitPoisonArea = 37;
            Naquinite.LowerManaCost = 6;
            Naquinite.LowerRegCost = 15;
            Naquinite.LowerStatReq = 0;
            Naquinite.LowerStatReq = 0;
            Naquinite.Luck = 0;
            Naquinite.MageArmor = 0;
            Naquinite.MageWeapon = 7;
            Naquinite.NightSight = 0;
            Naquinite.Physical = 11;
            Naquinite.Poison = 11;
            Naquinite.ReflectPhysical = 11;
            Naquinite.RegenHits = 1;
            Naquinite.RegenMana = 1;
            Naquinite.RegenStam = 2;
            Naquinite.ResistColdBonus = 11;
            Naquinite.ResistEnergyBonus = 11;
            Naquinite.ResistFireBonus = 11;
            Naquinite.ResistPhysicalBonus = 11;
            Naquinite.ResistPoisonBonus = 11;
            Naquinite.SelfRepair = 3;
            Naquinite.SpellChanneling = 0;
            Naquinite.SpellDamage = 9;
            Naquinite.UseBestSkill = 0;
            Naquinite.WeaponDamage = 18;
            Naquinite.WeaponSpeed = 0;

            CraftAttributeInfo Galvinite = Galvinite = new CraftAttributeInfo();

            Galvinite.m_ArmorColdResist = 48;
            Galvinite.m_ArmorEnergyResist = 48;
            Galvinite.m_ArmorFireResist = 48;
            Galvinite.m_ArmorPhysicalResist = 68;
            Galvinite.m_ArmorPoisonResist = 48;
            Galvinite.m_ArmorDamage = 48;
            Galvinite.m_ArmorDurability = 192;
            Galvinite.m_ArmorGoldIncrease = 192;
            Galvinite.m_ArmorHitChance = 20;
            Galvinite.m_ArmorLowerRequirements = 0;
            Galvinite.m_ArmorMage = 0;
            Galvinite.m_ArmorLuck = 20;
            Galvinite.m_RunicMinAttributes = 24;
            Galvinite.m_RunicMaxAttributes = 24;
            Galvinite.m_RunicMinIntensity = 80;
            Galvinite.m_RunicMaxIntensity = 80;
            Galvinite.m_ShieldColdResist = 48;
            Galvinite.m_ShieldEnergyResist = 48;
            Galvinite.m_ShieldFireResist = 48;
            Galvinite.m_ShieldPhysicalResist = 68;
            Galvinite.m_ShieldPoisonResist = 48;
            Galvinite.m_WeaponChaosDamage = 48;
            Galvinite.m_WeaponColdDamage = 48;
            Galvinite.m_WeaponEnergyDamage = 48;
            Galvinite.m_WeaponFireDamage = 48;
            Galvinite.m_WeaponPoisonDamage = 48;
            Galvinite.m_WeaponDirectDamage = 48;
            Galvinite.m_WeaponDamage = 48;
            Galvinite.m_WeaponDurability = 192;
            Galvinite.m_WeaponGoldIncrease = 192;
            Galvinite.m_WeaponHitChance = 4;
            Galvinite.m_WeaponHitLifeLeech = 20;
            Galvinite.m_WeaponLowerRequirements = 0;
            Galvinite.m_WeaponLuck = 398;
            Galvinite.m_WeaponSwingSpeed = 0;
            Galvinite.m_ArmorRegenHits = 0;
            Galvinite.m_WeaponRegenHits = 0;
            Galvinite.AttackChance = 12;
            Galvinite.BonusDex = 6;
            Galvinite.BonusHits = 4;
            Galvinite.BonusInt = 6;
            Galvinite.BonusMana = 6;
            Galvinite.BonusStam = 6;
            Galvinite.BonusStr = 6;
            Galvinite.CastRecovery = 2;
            Galvinite.CastSpeed = 0;
            Galvinite.Cold = 12;
            Galvinite.DefendChance = 12;
            Galvinite.DurabilityBonus = 80;
            Galvinite.Energy = 12;
            Galvinite.EnhancePotions = 20;
            Galvinite.Fire = 12;
            Galvinite.HitColdArea = 40;
            Galvinite.HitDispel = 40;
            Galvinite.HitEnergyArea = 40;
            Galvinite.HitFireArea = 40;
            Galvinite.HitFireball = 40;
            Galvinite.HitHarm = 40;
            Galvinite.HitLeechHits = 40;
            Galvinite.HitLeechMana = 40;
            Galvinite.HitLeechStam = 40;
            Galvinite.HitLightning = 40;
            Galvinite.HitLowerAttack = 40;
            Galvinite.HitLowerDefend = 40;
            Galvinite.HitMagicArrow = 40;
            Galvinite.HitPhysicalArea = 40;
            Galvinite.HitPoisonArea = 40;
            Galvinite.LowerManaCost = 6;
            Galvinite.LowerRegCost = 16;
            Galvinite.LowerStatReq = 0;
            Galvinite.LowerStatReq = 0;
            Galvinite.Luck = 0;
            Galvinite.MageArmor = 0;
            Galvinite.MageWeapon = 8;
            Galvinite.NightSight = 0;
            Galvinite.Physical = 12;
            Galvinite.Poison = 12;
            Galvinite.ReflectPhysical = 12;
            Galvinite.RegenHits = 1;
            Galvinite.RegenMana = 1;
            Galvinite.RegenStam = 2;
            Galvinite.ResistColdBonus = 12;
            Galvinite.ResistEnergyBonus = 12;
            Galvinite.ResistFireBonus = 12;
            Galvinite.ResistPhysicalBonus = 12;
            Galvinite.ResistPoisonBonus = 12;
            Galvinite.SelfRepair = 4;
            Galvinite.SpellChanneling = 0;
            Galvinite.SpellDamage = 9;
            Galvinite.UseBestSkill = 0;
            Galvinite.WeaponDamage = 20;
            Galvinite.WeaponSpeed = 0;

            CraftAttributeInfo Trilamide = Trilamide = new CraftAttributeInfo();

            Trilamide.m_ArmorColdResist = 51;
            Trilamide.m_ArmorEnergyResist = 51;
            Trilamide.m_ArmorFireResist = 51;
            Trilamide.m_ArmorPhysicalResist = 66;
            Trilamide.m_ArmorPoisonResist = 51;
            Trilamide.m_ArmorDamage = 51;
            Trilamide.m_ArmorDurability = 204;
            Trilamide.m_ArmorGoldIncrease = 204;
            Trilamide.m_ArmorHitChance = 21;
            Trilamide.m_ArmorLowerRequirements = 0;
            Trilamide.m_ArmorMage = 0;
            Trilamide.m_ArmorLuck = 21;
            Trilamide.m_RunicMinAttributes = 25;
            Trilamide.m_RunicMaxAttributes = 26;
            Trilamide.m_RunicMinIntensity = 84;
            Trilamide.m_RunicMaxIntensity = 87;
            Trilamide.m_ShieldColdResist = 51;
            Trilamide.m_ShieldEnergyResist = 51;
            Trilamide.m_ShieldFireResist = 51;
            Trilamide.m_ShieldPhysicalResist = 66;
            Trilamide.m_ShieldPoisonResist = 51;
            Trilamide.m_WeaponChaosDamage = 51;
            Trilamide.m_WeaponColdDamage = 51;
            Trilamide.m_WeaponEnergyDamage = 51;
            Trilamide.m_WeaponFireDamage = 51;
            Trilamide.m_WeaponPoisonDamage = 51;
            Trilamide.m_WeaponDirectDamage = 51;
            Trilamide.m_WeaponDamage = 51;
            Trilamide.m_WeaponDurability = 204;
            Trilamide.m_WeaponGoldIncrease = 204;
            Trilamide.m_WeaponHitChance = 5;
            Trilamide.m_WeaponHitLifeLeech = 21;
            Trilamide.m_WeaponLowerRequirements = 0;
            Trilamide.m_WeaponLuck = 423;
            Trilamide.m_WeaponSwingSpeed = 0;
            Trilamide.m_ArmorRegenHits = 0;
            Trilamide.m_WeaponRegenHits = 0;
            Trilamide.AttackChance = 12;
            Trilamide.BonusDex = 6;
            Trilamide.BonusHits = 4;
            Trilamide.BonusInt = 6;
            Trilamide.BonusMana = 6;
            Trilamide.BonusStam = 6;
            Trilamide.BonusStr = 6;
            Trilamide.CastRecovery = 2;
            Trilamide.CastSpeed = 0;
            Trilamide.Cold = 12;
            Trilamide.DefendChance = 12;
            Trilamide.DurabilityBonus = 85;
            Trilamide.Energy = 12;
            Trilamide.EnhancePotions = 21;
            Trilamide.Fire = 12;
            Trilamide.HitColdArea = 42;
            Trilamide.HitDispel = 42;
            Trilamide.HitEnergyArea = 42;
            Trilamide.HitFireArea = 42;
            Trilamide.HitFireball = 42;
            Trilamide.HitHarm = 42;
            Trilamide.HitLeechHits = 42;
            Trilamide.HitLeechMana = 42;
            Trilamide.HitLeechStam = 42;
            Trilamide.HitLightning = 42;
            Trilamide.HitLowerAttack = 42;
            Trilamide.HitLowerDefend = 42;
            Trilamide.HitMagicArrow = 42;
            Trilamide.HitPhysicalArea = 42;
            Trilamide.HitPoisonArea = 42;
            Trilamide.LowerManaCost = 6;
            Trilamide.LowerRegCost = 17;
            Trilamide.LowerStatReq = 0;
            Trilamide.LowerStatReq = 0;
            Trilamide.Luck = 0;
            Trilamide.MageArmor = 0;
            Trilamide.MageWeapon = 8;
            Trilamide.NightSight = 0;
            Trilamide.Physical = 12;
            Trilamide.Poison = 12;
            Trilamide.ReflectPhysical = 12;
            Trilamide.RegenHits = 1;
            Trilamide.RegenMana = 1;
            Trilamide.RegenStam = 2;
            Trilamide.ResistColdBonus = 12;
            Trilamide.ResistEnergyBonus = 12;
            Trilamide.ResistFireBonus = 12;
            Trilamide.ResistPhysicalBonus = 12;
            Trilamide.ResistPoisonBonus = 12;
            Trilamide.SelfRepair = 4;
            Trilamide.SpellChanneling = 0;
            Trilamide.SpellDamage = 10;
            Trilamide.UseBestSkill = 0;
            Trilamide.WeaponDamage = 21;
            Trilamide.WeaponSpeed = 0;

            CraftAttributeInfo Veramide = Veramide = new CraftAttributeInfo();

            Veramide.m_ArmorColdResist = 54;
            Veramide.m_ArmorEnergyResist = 54;
            Veramide.m_ArmorFireResist = 54;
            Veramide.m_ArmorPhysicalResist = 64;
            Veramide.m_ArmorPoisonResist = 54;
            Veramide.m_ArmorDamage = 54;
            Veramide.m_ArmorDurability = 216;
            Veramide.m_ArmorGoldIncrease = 216;
            Veramide.m_ArmorHitChance = 22;
            Veramide.m_ArmorLowerRequirements = 0;
            Veramide.m_ArmorMage = 0;
            Veramide.m_ArmorLuck = 22;
            Veramide.m_RunicMinAttributes = 27;
            Veramide.m_RunicMaxAttributes = 27;
            Veramide.m_RunicMinIntensity = 90;
            Veramide.m_RunicMaxIntensity = 90;
            Veramide.m_ShieldColdResist = 54;
            Veramide.m_ShieldEnergyResist = 54;
            Veramide.m_ShieldFireResist = 54;
            Veramide.m_ShieldPhysicalResist = 64;
            Veramide.m_ShieldPoisonResist = 54;
            Veramide.m_WeaponChaosDamage = 54;
            Veramide.m_WeaponColdDamage = 54;
            Veramide.m_WeaponEnergyDamage = 54;
            Veramide.m_WeaponFireDamage = 54;
            Veramide.m_WeaponPoisonDamage = 54;
            Veramide.m_WeaponDirectDamage = 54;
            Veramide.m_WeaponDamage = 54;
            Veramide.m_WeaponDurability = 216;
            Veramide.m_WeaponGoldIncrease = 216;
            Veramide.m_WeaponHitChance = 5;
            Veramide.m_WeaponHitLifeLeech = 22;
            Veramide.m_WeaponLowerRequirements = 0;
            Veramide.m_WeaponLuck = 448;
            Veramide.m_WeaponSwingSpeed = 0;
            Veramide.m_ArmorRegenHits = 0;
            Veramide.m_WeaponRegenHits = 0;
            Veramide.AttackChance = 13;
            Veramide.BonusDex = 7;
            Veramide.BonusHits = 4;
            Veramide.BonusInt = 7;
            Veramide.BonusMana = 7;
            Veramide.BonusStam = 7;
            Veramide.BonusStr = 7;
            Veramide.CastRecovery = 2;
            Veramide.CastSpeed = 0;
            Veramide.Cold = 13;
            Veramide.DefendChance = 13;
            Veramide.DurabilityBonus = 90;
            Veramide.Energy = 13;
            Veramide.EnhancePotions = 22;
            Veramide.Fire = 13;
            Veramide.HitColdArea = 45;
            Veramide.HitDispel = 45;
            Veramide.HitEnergyArea = 45;
            Veramide.HitFireArea = 45;
            Veramide.HitFireball = 45;
            Veramide.HitHarm = 45;
            Veramide.HitLeechHits = 45;
            Veramide.HitLeechMana = 45;
            Veramide.HitLeechStam = 45;
            Veramide.HitLightning = 45;
            Veramide.HitLowerAttack = 45;
            Veramide.HitLowerDefend = 45;
            Veramide.HitMagicArrow = 45;
            Veramide.HitPhysicalArea = 45;
            Veramide.HitPoisonArea = 45;
            Veramide.LowerManaCost = 7;
            Veramide.LowerRegCost = 18;
            Veramide.LowerStatReq = 0;
            Veramide.LowerStatReq = 0;
            Veramide.Luck = 0;
            Veramide.MageArmor = 0;
            Veramide.MageWeapon = 9;
            Veramide.NightSight = 0;
            Veramide.Physical = 13;
            Veramide.Poison = 13;
            Veramide.ReflectPhysical = 13;
            Veramide.RegenHits = 1;
            Veramide.RegenMana = 1;
            Veramide.RegenStam = 2;
            Veramide.ResistColdBonus = 13;
            Veramide.ResistEnergyBonus = 13;
            Veramide.ResistFireBonus = 13;
            Veramide.ResistPhysicalBonus = 13;
            Veramide.ResistPoisonBonus = 13;
            Veramide.SelfRepair = 4;
            Veramide.SpellChanneling = 0;
            Veramide.SpellDamage = 10;
            Veramide.UseBestSkill = 0;
            Veramide.WeaponDamage = 22;
            Veramide.WeaponSpeed = 0;

            CraftAttributeInfo Zenlamide = Zenlamide = new CraftAttributeInfo();

            Zenlamide.m_ArmorColdResist = 57;
            Zenlamide.m_ArmorEnergyResist = 57;
            Zenlamide.m_ArmorFireResist = 57;
            Zenlamide.m_ArmorPhysicalResist = 62;
            Zenlamide.m_ArmorPoisonResist = 57;
            Zenlamide.m_ArmorDamage = 57;
            Zenlamide.m_ArmorDurability = 228;
            Zenlamide.m_ArmorGoldIncrease = 228;
            Zenlamide.m_ArmorHitChance = 23;
            Zenlamide.m_ArmorLowerRequirements = 0;
            Zenlamide.m_ArmorMage = 0;
            Zenlamide.m_ArmorLuck = 23;
            Zenlamide.m_RunicMinAttributes = 28;
            Zenlamide.m_RunicMaxAttributes = 29;
            Zenlamide.m_RunicMinIntensity = 93;
            Zenlamide.m_RunicMaxIntensity = 97;
            Zenlamide.m_ShieldColdResist = 57;
            Zenlamide.m_ShieldEnergyResist = 57;
            Zenlamide.m_ShieldFireResist = 57;
            Zenlamide.m_ShieldPhysicalResist = 62;
            Zenlamide.m_ShieldPoisonResist = 57;
            Zenlamide.m_WeaponChaosDamage = 57;
            Zenlamide.m_WeaponColdDamage = 57;
            Zenlamide.m_WeaponEnergyDamage = 57;
            Zenlamide.m_WeaponFireDamage = 57;
            Zenlamide.m_WeaponPoisonDamage = 57;
            Zenlamide.m_WeaponDirectDamage = 57;
            Zenlamide.m_WeaponDamage = 57;
            Zenlamide.m_WeaponDurability = 228;
            Zenlamide.m_WeaponGoldIncrease = 228;
            Zenlamide.m_WeaponHitChance = 5;
            Zenlamide.m_WeaponHitLifeLeech = 23;
            Zenlamide.m_WeaponLowerRequirements = 0;
            Zenlamide.m_WeaponLuck = 473;
            Zenlamide.m_WeaponSwingSpeed = 0;
            Zenlamide.m_ArmorRegenHits = 0;
            Zenlamide.m_WeaponRegenHits = 0;
            Zenlamide.AttackChance = 14;
            Zenlamide.BonusDex = 7;
            Zenlamide.BonusHits = 4;
            Zenlamide.BonusInt = 7;
            Zenlamide.BonusMana = 7;
            Zenlamide.BonusStam = 7;
            Zenlamide.BonusStr = 7;
            Zenlamide.CastRecovery = 2;
            Zenlamide.CastSpeed = 0;
            Zenlamide.Cold = 14;
            Zenlamide.DefendChance = 14;
            Zenlamide.DurabilityBonus = 95;
            Zenlamide.Energy = 14;
            Zenlamide.EnhancePotions = 23;
            Zenlamide.Fire = 14;
            Zenlamide.HitColdArea = 47;
            Zenlamide.HitDispel = 47;
            Zenlamide.HitEnergyArea = 47;
            Zenlamide.HitFireArea = 47;
            Zenlamide.HitFireball = 47;
            Zenlamide.HitHarm = 47;
            Zenlamide.HitLeechHits = 47;
            Zenlamide.HitLeechMana = 47;
            Zenlamide.HitLeechStam = 47;
            Zenlamide.HitLightning = 47;
            Zenlamide.HitLowerAttack = 47;
            Zenlamide.HitLowerDefend = 47;
            Zenlamide.HitMagicArrow = 47;
            Zenlamide.HitPhysicalArea = 47;
            Zenlamide.HitPoisonArea = 47;
            Zenlamide.LowerManaCost = 7;
            Zenlamide.LowerRegCost = 19;
            Zenlamide.LowerStatReq = 0;
            Zenlamide.LowerStatReq = 0;
            Zenlamide.Luck = 0;
            Zenlamide.MageArmor = 0;
            Zenlamide.MageWeapon = 9;
            Zenlamide.NightSight = 0;
            Zenlamide.Physical = 14;
            Zenlamide.Poison = 14;
            Zenlamide.ReflectPhysical = 14;
            Zenlamide.RegenHits = 1;
            Zenlamide.RegenMana = 1;
            Zenlamide.RegenStam = 2;
            Zenlamide.ResistColdBonus = 14;
            Zenlamide.ResistEnergyBonus = 14;
            Zenlamide.ResistFireBonus = 14;
            Zenlamide.ResistPhysicalBonus = 14;
            Zenlamide.ResistPoisonBonus = 14;
            Zenlamide.SelfRepair = 4;
            Zenlamide.SpellChanneling = 0;
            Zenlamide.SpellDamage = 11;
            Zenlamide.UseBestSkill = 0;
            Zenlamide.WeaponDamage = 23;
            Zenlamide.WeaponSpeed = 0;

            CraftAttributeInfo Guardians = Guardians = new CraftAttributeInfo();

            Guardians.m_ArmorColdResist = 60;
            Guardians.m_ArmorEnergyResist = 60;
            Guardians.m_ArmorFireResist = 60;
            Guardians.m_ArmorPhysicalResist = 60;
            Guardians.m_ArmorPoisonResist = 60;
            Guardians.m_ArmorDamage = 60;
            Guardians.m_ArmorDurability = 240;
            Guardians.m_ArmorGoldIncrease = 240;
            Guardians.m_ArmorHitChance = 25;
            Guardians.m_ArmorLowerRequirements = 0;
            Guardians.m_ArmorMage = 0;
            Guardians.m_ArmorLuck = 25;
            Guardians.m_RunicMinAttributes = 30;
            Guardians.m_RunicMaxAttributes = 30;
            Guardians.m_RunicMinIntensity = 100;
            Guardians.m_RunicMaxIntensity = 100;
            Guardians.m_ShieldColdResist = 60;
            Guardians.m_ShieldEnergyResist = 60;
            Guardians.m_ShieldFireResist = 60;
            Guardians.m_ShieldPhysicalResist = 60;
            Guardians.m_ShieldPoisonResist = 60;
            Guardians.m_WeaponChaosDamage = 60;
            Guardians.m_WeaponColdDamage = 60;
            Guardians.m_WeaponEnergyDamage = 60;
            Guardians.m_WeaponFireDamage = 60;
            Guardians.m_WeaponPoisonDamage = 60;
            Guardians.m_WeaponDirectDamage = 60;
            Guardians.m_WeaponDamage = 60;
            Guardians.m_WeaponDurability = 240;
            Guardians.m_WeaponGoldIncrease = 240;
            Guardians.m_WeaponHitChance = 6;
            Guardians.m_WeaponHitLifeLeech = 25;
            Guardians.m_WeaponLowerRequirements = 0;
            Guardians.m_WeaponLuck = 498;
            Guardians.m_WeaponSwingSpeed = 0;
            Guardians.m_ArmorRegenHits = 0;
            Guardians.m_WeaponRegenHits = 0;
            Guardians.AttackChance = 15;
            Guardians.BonusDex = 8;
            Guardians.BonusHits = 5;
            Guardians.BonusInt = 8;
            Guardians.BonusMana = 8;
            Guardians.BonusStam = 8;
            Guardians.BonusStr = 8;
            Guardians.CastRecovery = 3;
            Guardians.CastSpeed = 1;
            Guardians.Cold = 15;
            Guardians.DefendChance = 15;
            Guardians.DurabilityBonus = 100;
            Guardians.Energy = 15;
            Guardians.EnhancePotions = 25;
            Guardians.Fire = 15;
            Guardians.HitColdArea = 50;
            Guardians.HitDispel = 50;
            Guardians.HitEnergyArea = 50;
            Guardians.HitFireArea = 50;
            Guardians.HitFireball = 50;
            Guardians.HitHarm = 50;
            Guardians.HitLeechHits = 50;
            Guardians.HitLeechMana = 50;
            Guardians.HitLeechStam = 50;
            Guardians.HitLightning = 50;
            Guardians.HitLowerAttack = 50;
            Guardians.HitLowerDefend = 50;
            Guardians.HitMagicArrow = 50;
            Guardians.HitPhysicalArea = 50;
            Guardians.HitPoisonArea = 50;
            Guardians.LowerManaCost = 8;
            Guardians.LowerRegCost = 20;
            Guardians.LowerStatReq = 0;
            Guardians.LowerStatReq = 0;
            Guardians.Luck = 0;
            Guardians.MageArmor = 1;
            Guardians.MageWeapon = 10;
            Guardians.NightSight = 0;
            Guardians.Physical = 15;
            Guardians.Poison = 15;
            Guardians.ReflectPhysical = 15;
            Guardians.RegenHits = 2;
            Guardians.RegenMana = 2;
            Guardians.RegenStam = 3;
            Guardians.ResistColdBonus = 15;
            Guardians.ResistEnergyBonus = 15;
            Guardians.ResistFireBonus = 15;
            Guardians.ResistPhysicalBonus = 15;
            Guardians.ResistPoisonBonus = 15;
            Guardians.SelfRepair = 5;
            Guardians.SpellChanneling = 0;
            Guardians.SpellDamage = 12;
            Guardians.UseBestSkill = 0;
            Guardians.WeaponDamage = 25;
            Guardians.WeaponSpeed = 0;

            CraftAttributeInfo spined = Spined = new CraftAttributeInfo();

            spined.ArmorPhysicalResist = 9;
            spined.ArmorLuck = 40;
            spined.RunicMinAttributes = 1;
            spined.RunicMaxAttributes = 3;

            if (Core.ML)
            {
                spined.RunicMinIntensity = 40;
                spined.RunicMaxIntensity = 100;
            }
            else
            {
                spined.RunicMinIntensity = 20;
                spined.RunicMaxIntensity = 40;
            }

            CraftAttributeInfo horned = Horned = new CraftAttributeInfo();

            horned.ArmorPhysicalResist = 2;
            horned.ArmorFireResist = 4;
            horned.ArmorColdResist = 3;
            horned.ArmorPoisonResist = 3;
            horned.ArmorEnergyResist = 3;
            horned.RunicMinAttributes = 3;
            horned.RunicMaxAttributes = 4;
            if (Core.ML)
            {
                horned.RunicMinIntensity = 45;
                horned.RunicMaxIntensity = 100;
            }
            else
            {
                horned.RunicMinIntensity = 30;
                horned.RunicMaxIntensity = 70;
            }

            CraftAttributeInfo barbed = Barbed = new CraftAttributeInfo();

            barbed.ArmorPhysicalResist = 3;
            barbed.ArmorFireResist = 2;
            barbed.ArmorColdResist = 3;
            barbed.ArmorPoisonResist = 3;
            barbed.ArmorEnergyResist = 5;
            barbed.RunicMinAttributes = 4;
            barbed.RunicMaxAttributes = 5;
            if (Core.ML)
            {
                barbed.RunicMinIntensity = 50;
                barbed.RunicMaxIntensity = 100;
            }
            else
            {
                barbed.RunicMinIntensity = 40;
                barbed.RunicMaxIntensity = 100;
            }

            CraftAttributeInfo red = RedScales = new CraftAttributeInfo();
            red.ArmorPhysicalResist = 1;
            red.ArmorFireResist = 11;
            red.ArmorColdResist = -3;
            red.ArmorPoisonResist = 1;
            red.ArmorEnergyResist = 1;

            CraftAttributeInfo yellow = YellowScales = new CraftAttributeInfo();

            yellow.ArmorPhysicalResist = -3;
            yellow.ArmorFireResist = 1;
            yellow.ArmorColdResist = 1;
            yellow.ArmorPoisonResist = 1;
            yellow.ArmorPoisonResist = 1;
            yellow.ArmorLuck = 20;

            CraftAttributeInfo black = BlackScales = new CraftAttributeInfo();

            black.ArmorPhysicalResist = 11;
            black.ArmorEnergyResist = -3;
            black.ArmorFireResist = 1;
            black.ArmorPoisonResist = 1;
            black.ArmorColdResist = 1;

            CraftAttributeInfo green = GreenScales = new CraftAttributeInfo();

            green.ArmorFireResist = -3;
            green.ArmorPhysicalResist = 1;
            green.ArmorColdResist = 1;
            green.ArmorEnergyResist = 1;
            green.ArmorPoisonResist = 11;

            CraftAttributeInfo white = WhiteScales = new CraftAttributeInfo();

            white.ArmorPhysicalResist = -3;
            white.ArmorFireResist = 1;
            white.ArmorEnergyResist = 1;
            white.ArmorPoisonResist = 1;
            white.ArmorColdResist = 11;

            CraftAttributeInfo blue = BlueScales = new CraftAttributeInfo();

            blue.ArmorPhysicalResist = 1;
            blue.ArmorFireResist = 1;
            blue.ArmorColdResist = 1;
            blue.ArmorPoisonResist = -3;
            blue.ArmorEnergyResist = 11;

            #region Mondain's Legacy
            CraftAttributeInfo oak = OakWood = new CraftAttributeInfo();

            oak.ArmorPhysicalResist = 3;
            oak.ArmorFireResist = 3;
            oak.ArmorPoisonResist = 2;
            oak.ArmorEnergyResist = 3;
            oak.ArmorLuck = 40;

            oak.ShieldPhysicalResist = 1;
            oak.ShieldFireResist = 1;
            oak.ShieldColdResist = 1;
            oak.ShieldPoisonResist = 1;
            oak.ShieldEnergyResist = 1;

            oak.WeaponLuck = 40;
            oak.WeaponDamage = 5;

            oak.RunicMinAttributes = 1;
            oak.RunicMaxAttributes = 2;
            oak.RunicMinIntensity = 1;
            oak.RunicMaxIntensity = 50;

            CraftAttributeInfo ash = AshWood = new CraftAttributeInfo();

            ash.ArmorPhysicalResist = 2;
            ash.ArmorColdResist = 4;
            ash.ArmorPoisonResist = 1;
            ash.ArmorEnergyResist = 6;
            ash.ArmorLowerRequirements = 20;

            ash.ShieldEnergyResist = 3;
            ash.ShieldLowerRequirements = 3;

            ash.WeaponSwingSpeed = 10;
            ash.WeaponLowerRequirements = 20;

            ash.OtherLowerRequirements = 20;

            ash.RunicMinAttributes = 2;
            ash.RunicMaxAttributes = 3;
            ash.RunicMinIntensity = 35;
            ash.RunicMaxIntensity = 75;

            CraftAttributeInfo yew = YewWood = new CraftAttributeInfo();

            yew.ArmorPhysicalResist = 6;
            yew.ArmorFireResist = 3;
            yew.ArmorColdResist = 3;
            yew.ArmorEnergyResist = 3;
            yew.ArmorRegenHits = 1;

            yew.ShieldPhysicalResist = 3;
            yew.ShieldRegenHits = 1;

            yew.WeaponHitChance = 5;
            yew.WeaponDamage = 10;

            yew.OtherRegenHits = 2;

            yew.RunicMinAttributes = 3;
            yew.RunicMaxAttributes = 3;
            yew.RunicMinIntensity = 40;
            yew.RunicMaxIntensity = 90;

            CraftAttributeInfo heartwood = Heartwood = new CraftAttributeInfo();

            heartwood.ArmorPhysicalResist = 2;
            heartwood.ArmorFireResist = 3;
            heartwood.ArmorColdResist = 2;
            heartwood.ArmorPoisonResist = 7;
            heartwood.ArmorEnergyResist = 2;

            // one of below
            heartwood.ArmorDamage = 10;
            heartwood.ArmorHitChance = 5;
            heartwood.ArmorLuck = 40;
            heartwood.ArmorLowerRequirements = 20;
            heartwood.ArmorMage = 1;

            // one of below
            heartwood.WeaponDamage = 10;
            heartwood.WeaponHitChance = 5;
            heartwood.WeaponHitLifeLeech = 13;
            heartwood.WeaponLuck = 40;
            heartwood.WeaponLowerRequirements = 20;
            heartwood.WeaponSwingSpeed = 10;

            heartwood.ShieldBonusDex = 2;
            heartwood.ShieldBonusStr = 2;
            heartwood.ShieldPhysicalRandom = 5;
            heartwood.ShieldReflectPhys = 5;
            heartwood.ShieldSelfRepair = 2;
            heartwood.ShieldColdRandom = 3;
            heartwood.ShieldSpellChanneling = 1;

            heartwood.RunicMinAttributes = 4;
            heartwood.RunicMaxAttributes = 4;
            heartwood.RunicMinIntensity = 50;
            heartwood.RunicMaxIntensity = 100;

            CraftAttributeInfo bloodwood = Bloodwood = new CraftAttributeInfo();

            bloodwood.ArmorPhysicalResist = 3;
            bloodwood.ArmorFireResist = 8;
            bloodwood.ArmorColdResist = 1;
            bloodwood.ArmorPoisonResist = 3;
            bloodwood.ArmorEnergyResist = 3;
            bloodwood.ArmorRegenHits = 2;

            bloodwood.ShieldFireResist = 3;
            bloodwood.ShieldLuck = 40;
            bloodwood.ShieldRegenHits = 2;

            bloodwood.WeaponRegenHits = 2;
            bloodwood.WeaponHitLifeLeech = 16;

            bloodwood.OtherLuck = 20;
            bloodwood.OtherRegenHits = 2;

            CraftAttributeInfo frostwood = Frostwood = new CraftAttributeInfo();

            frostwood.ArmorPhysicalResist = 2;
            frostwood.ArmorFireResist = 1;
            frostwood.ArmorColdResist = 8;
            frostwood.ArmorPoisonResist = 3;
            frostwood.ArmorEnergyResist = 4;

            frostwood.ShieldColdResist = 3;
            frostwood.ShieldSpellChanneling = 1;

            frostwood.WeaponColdDamage = 40;
            frostwood.WeaponDamage = 12;

            frostwood.OtherSpellChanneling = 1;
            #endregion
        }
    }

    public class CraftResourceInfo
    {
        private readonly int m_Hue;
        private readonly int m_Number;
        private readonly string m_Name;
        private readonly CraftAttributeInfo m_AttributeInfo;
        private readonly CraftResource m_Resource;
        private readonly Type[] m_ResourceTypes;

        public int Hue
        {
            get
            {
                return this.m_Hue;
            }
        }
        public int Number
        {
            get
            {
                return this.m_Number;
            }
        }
        public string Name
        {
            get
            {
                return this.m_Name;
            }
        }
        public CraftAttributeInfo AttributeInfo
        {
            get
            {
                return this.m_AttributeInfo;
            }
        }
        public CraftResource Resource
        {
            get
            {
                return this.m_Resource;
            }
        }
        public Type[] ResourceTypes
        {
            get
            {
                return this.m_ResourceTypes;
            }
        }

        public CraftResourceInfo(int hue, int number, string name, CraftAttributeInfo attributeInfo, CraftResource resource, params Type[] resourceTypes)
        {
            this.m_Hue = hue;
            this.m_Number = number;
            this.m_Name = name;
            this.m_AttributeInfo = attributeInfo;
            this.m_Resource = resource;
            this.m_ResourceTypes = resourceTypes;

            for (int i = 0; i < resourceTypes.Length; ++i)
                CraftResources.RegisterType(resourceTypes[i], resource);
        }
    }

    public class CraftResources
    {
        private static readonly CraftResourceInfo[] m_MetalInfo = new CraftResourceInfo[]
        {
            new CraftResourceInfo(0x000, 1053109, "Iron", CraftAttributeInfo.Blank, CraftResource.Iron, typeof(IronIngot), typeof(IronOre), typeof(Granite)),
            new CraftResourceInfo(0x973, 1053108, "Dull Copper",	CraftAttributeInfo.DullCopper,	CraftResource.DullCopper, typeof(DullCopperIngot),	typeof(DullCopperOre),	typeof(DullCopperGranite)),
            new CraftResourceInfo(0x966, 1053107, "Shadow Iron",	CraftAttributeInfo.ShadowIron,	CraftResource.ShadowIron, typeof(ShadowIronIngot),	typeof(ShadowIronOre),	typeof(ShadowIronGranite)),
            new CraftResourceInfo(0x96D, 1053106, "Copper", CraftAttributeInfo.Copper, CraftResource.Copper, typeof(CopperIngot), typeof(CopperOre), typeof(CopperGranite)),
            new CraftResourceInfo(0x972, 1053105, "Bronze", CraftAttributeInfo.Bronze, CraftResource.Bronze, typeof(BronzeIngot), typeof(BronzeOre), typeof(BronzeGranite)),
            new CraftResourceInfo(0x8A5, 1053104, "Gold", CraftAttributeInfo.Gold, CraftResource.Gold, typeof(GoldIngot), typeof(GoldOre), typeof(GoldGranite)),
            new CraftResourceInfo(0x979, 1053103, "Agapite", CraftAttributeInfo.Agapite, CraftResource.Agapite, typeof(AgapiteIngot), typeof(AgapiteOre), typeof(AgapiteGranite)),
            new CraftResourceInfo(0x89F, 1053102, "Verite", CraftAttributeInfo.Verite, CraftResource.Verite, typeof(VeriteIngot), typeof(VeriteOre), typeof(VeriteGranite)),
            new CraftResourceInfo(0x8AB, 1053101, "Valorite", CraftAttributeInfo.Valorite,	CraftResource.Valorite, typeof(ValoriteIngot),	typeof(ValoriteOre), typeof(ValoriteGranite)),
        };

        private static readonly CraftResourceInfo[] m_ScaleInfo = new CraftResourceInfo[]
        {
            new CraftResourceInfo(0x66D, 1053129, "Red Scales",	CraftAttributeInfo.RedScales, CraftResource.RedScales, typeof(RedScales)),
            new CraftResourceInfo(0x8A8, 1053130, "Yellow Scales",	CraftAttributeInfo.YellowScales,	CraftResource.YellowScales, typeof(YellowScales)),
            new CraftResourceInfo(0x455, 1053131, "Black Scales",	CraftAttributeInfo.BlackScales, CraftResource.BlackScales, typeof(BlackScales)),
            new CraftResourceInfo(0x851, 1053132, "Green Scales",	CraftAttributeInfo.GreenScales, CraftResource.GreenScales, typeof(GreenScales)),
            new CraftResourceInfo(0x8FD, 1053133, "White Scales",	CraftAttributeInfo.WhiteScales, CraftResource.WhiteScales, typeof(WhiteScales)),
            new CraftResourceInfo(0x8B0, 1053134, "Blue Scales",	CraftAttributeInfo.BlueScales, CraftResource.BlueScales, typeof(BlueScales))
        };

        private static readonly CraftResourceInfo[] m_LeatherInfo = new CraftResourceInfo[]
        {
            new CraftResourceInfo(0x000, 1049353, "Normal", CraftAttributeInfo.Blank, CraftResource.RegularLeather,	typeof(Leather), typeof(Hides)),
            new CraftResourceInfo(0x283, 1049354, "Spined", CraftAttributeInfo.Spined, CraftResource.SpinedLeather,	typeof(SpinedLeather),	typeof(SpinedHides)),
            new CraftResourceInfo(0x227, 1049355, "Horned", CraftAttributeInfo.Horned, CraftResource.HornedLeather,	typeof(HornedLeather),	typeof(HornedHides)),
            new CraftResourceInfo(0x1C1, 1049356, "Barbed", CraftAttributeInfo.Barbed, CraftResource.BarbedLeather,	typeof(BarbedLeather),	typeof(BarbedHides))
        };

        private static readonly CraftResourceInfo[] m_AOSLeatherInfo = new CraftResourceInfo[]
        {
            new CraftResourceInfo(0x000, 1049353, "Normal", CraftAttributeInfo.Blank, CraftResource.RegularLeather,	typeof(Leather), typeof(Hides)),
            new CraftResourceInfo(0x8AC, 1049354, "Spined", CraftAttributeInfo.Spined, CraftResource.SpinedLeather,	typeof(SpinedLeather),	typeof(SpinedHides)),
            new CraftResourceInfo(0x845, 1049355, "Horned", CraftAttributeInfo.Horned, CraftResource.HornedLeather,	typeof(HornedLeather),	typeof(HornedHides)),
            new CraftResourceInfo(0x851, 1049356, "Barbed", CraftAttributeInfo.Barbed, CraftResource.BarbedLeather,	typeof(BarbedLeather),	typeof(BarbedHides)),
        };

        private static readonly CraftResourceInfo[] m_WoodInfo = new CraftResourceInfo[]
        {
            new CraftResourceInfo(0x000, 1011542, "Normal", CraftAttributeInfo.Blank, CraftResource.RegularWood,	typeof(Log), typeof(Board)),
            new CraftResourceInfo(0x7DA, 1072533, "Oak", CraftAttributeInfo.OakWood, CraftResource.OakWood, typeof(OakLog), typeof(OakBoard)),
            new CraftResourceInfo(0x4A7, 1072534, "Ash", CraftAttributeInfo.AshWood, CraftResource.AshWood, typeof(AshLog), typeof(AshBoard)),
            new CraftResourceInfo(0x4A8, 1072535, "Yew", CraftAttributeInfo.YewWood, CraftResource.YewWood, typeof(YewLog), typeof(YewBoard)),
            new CraftResourceInfo(0x4A9, 1072536, "Heartwood", CraftAttributeInfo.Heartwood,	CraftResource.Heartwood,	typeof(HeartwoodLog),	typeof(HeartwoodBoard)),
            new CraftResourceInfo(0x4AA, 1072538, "Bloodwood", CraftAttributeInfo.Bloodwood,	CraftResource.Bloodwood,	typeof(BloodwoodLog),	typeof(BloodwoodBoard)),
            new CraftResourceInfo(0x47F, 1072539, "Frostwood", CraftAttributeInfo.Frostwood,	CraftResource.Frostwood,	typeof(FrostwoodLog),	typeof(FrostwoodBoard))
        };

        /// <summary>
        /// Returns true if '<paramref name="resource"/>' is None, Iron, RegularLeather or RegularWood. False if otherwise.
        /// </summary>
        public static bool IsStandard(CraftResource resource)
        {
            return (resource == CraftResource.None || resource == CraftResource.Iron || resource == CraftResource.RegularLeather || resource == CraftResource.RegularWood);
        }

        private static Hashtable m_TypeTable;

        /// <summary>
        /// Registers that '<paramref name="resourceType"/>' uses '<paramref name="resource"/>' so that it can later be queried by <see cref="CraftResources.GetFromType"/>
        /// </summary>
        public static void RegisterType(Type resourceType, CraftResource resource)
        {
            if (m_TypeTable == null)
                m_TypeTable = new Hashtable();

            m_TypeTable[resourceType] = resource;
        }

        /// <summary>
        /// Returns the <see cref="CraftResource"/> value for which '<paramref name="resourceType"/>' uses -or- CraftResource.None if an unregistered type was specified.
        /// </summary>
        public static CraftResource GetFromType(Type resourceType)
        {
            if (m_TypeTable == null)
                return CraftResource.None;

            object obj = m_TypeTable[resourceType];

            if (!(obj is CraftResource))
                return CraftResource.None;

            return (CraftResource)obj;
        }

        /// <summary>
        /// Returns a <see cref="CraftResourceInfo"/> instance describing '<paramref name="resource"/>' -or- null if an invalid resource was specified.
        /// </summary>
        public static CraftResourceInfo GetInfo(CraftResource resource)
        {
            CraftResourceInfo[] list = null;

            switch (GetType(resource))
            {
                case CraftResourceType.Metal:
                    list = m_MetalInfo;
                    break;
                case CraftResourceType.Leather:
                    list = Core.AOS ? m_AOSLeatherInfo : m_LeatherInfo;
                    break;
                case CraftResourceType.Scales:
                    list = m_ScaleInfo;
                    break;
                case CraftResourceType.Wood:
                    list = m_WoodInfo;
                    break;
            }

            if (list != null)
            {
                int index = GetIndex(resource);

                if (index >= 0 && index < list.Length)
                    return list[index];
            }

            return null;
        }

        /// <summary>
        /// Returns a <see cref="CraftResourceType"/> value indiciating the type of '<paramref name="resource"/>'.
        /// </summary>
        public static CraftResourceType GetType(CraftResource resource)
        {
            if (resource >= CraftResource.Iron && resource <= CraftResource.Valorite)
                return CraftResourceType.Metal;

            if (resource >= CraftResource.RegularLeather && resource <= CraftResource.BarbedLeather)
                return CraftResourceType.Leather;

            if (resource >= CraftResource.RedScales && resource <= CraftResource.BlueScales)
                return CraftResourceType.Scales;

            if (resource >= CraftResource.RegularWood && resource <= CraftResource.Frostwood)
                return CraftResourceType.Wood;

            return CraftResourceType.None;
        }

        /// <summary>
        /// Returns the first <see cref="CraftResource"/> in the series of resources for which '<paramref name="resource"/>' belongs.
        /// </summary>
        public static CraftResource GetStart(CraftResource resource)
        {
            switch (GetType(resource))
            {
                case CraftResourceType.Metal:
                    return CraftResource.Iron;
                case CraftResourceType.Leather:
                    return CraftResource.RegularLeather;
                case CraftResourceType.Scales:
                    return CraftResource.RedScales;
                case CraftResourceType.Wood:
                    return CraftResource.RegularWood;
            }

            return CraftResource.None;
        }

        /// <summary>
        /// Returns the index of '<paramref name="resource"/>' in the seriest of resources for which it belongs.
        /// </summary>
        public static int GetIndex(CraftResource resource)
        {
            CraftResource start = GetStart(resource);

            if (start == CraftResource.None)
                return 0;

            return (int)(resource - start);
        }

        /// <summary>
        /// Returns the <see cref="CraftResourceInfo.Number"/> property of '<paramref name="resource"/>' -or- 0 if an invalid resource was specified.
        /// </summary>
        public static int GetLocalizationNumber(CraftResource resource)
        {
            CraftResourceInfo info = GetInfo(resource);

            return (info == null ? 0 : info.Number);
        }

        /// <summary>
        /// Returns the <see cref="CraftResourceInfo.Hue"/> property of '<paramref name="resource"/>' -or- 0 if an invalid resource was specified.
        /// </summary>
        public static int GetHue(CraftResource resource)
        {
            CraftResourceInfo info = GetInfo(resource);

            return (info == null ? 0 : info.Hue);
        }

        /// <summary>
        /// Returns the <see cref="CraftResourceInfo.Name"/> property of '<paramref name="resource"/>' -or- an empty string if the resource specified was invalid.
        /// </summary>
        public static string GetName(CraftResource resource)
        {
            CraftResourceInfo info = GetInfo(resource);

            return (info == null ? String.Empty : info.Name);
        }

        /// <summary>
        /// Returns the <see cref="CraftResource"/> value which represents '<paramref name="info"/>' -or- CraftResource.None if unable to convert.
        /// </summary>
        public static CraftResource GetFromOreInfo(OreInfo info)
        {
            if (info.Name.IndexOf("Spined") >= 0)
                return CraftResource.SpinedLeather;
            else if (info.Name.IndexOf("Horned") >= 0)
                return CraftResource.HornedLeather;
            else if (info.Name.IndexOf("Barbed") >= 0)
                return CraftResource.BarbedLeather;
            else if (info.Name.IndexOf("Leather") >= 0)
                return CraftResource.RegularLeather;

            if (info.Level == 0)
                return CraftResource.Iron;
            else if (info.Level == 1)
                return CraftResource.DullCopper;
            else if (info.Level == 2)
                return CraftResource.ShadowIron;
            else if (info.Level == 3)
                return CraftResource.Copper;
            else if (info.Level == 4)
                return CraftResource.Bronze;
            else if (info.Level == 5)
                return CraftResource.Gold;
            else if (info.Level == 6)
                return CraftResource.Silver;
            else if (info.Level == 7)
                return CraftResource.Agapite;
            else if (info.Level == 8)
                return CraftResource.Verite;
            else if (info.Level == 9)
                return CraftResource.Valorite;
            else if (info.Level == 10)
                return CraftResource.Uridium;
            else if (info.Level == 11)
                return CraftResource.Trillium;
            else if (info.Level == 12)
                return CraftResource.Titanium;
            else if (info.Level == 13)
                return CraftResource.Platinum;
            else if (info.Level == 14)
                return CraftResource.Zenite;
            else if (info.Level == 15)
                return CraftResource.Naquinite;
            else if (info.Level == 16)
                return CraftResource.Galvinite;
            else if (info.Level == 17)
                return CraftResource.Trilamide;
            else if (info.Level == 18)
                return CraftResource.Veramide;
            else if (info.Level == 19)
                return CraftResource.Zenlamide;
            else if (info.Level == 20)
                return CraftResource.Guardians;

            return CraftResource.None;
        }

        /// <summary>
        /// Returns the <see cref="CraftResource"/> value which represents '<paramref name="info"/>', using '<paramref name="material"/>' to help resolve leather OreInfo instances.
        /// </summary>
        public static CraftResource GetFromOreInfo(OreInfo info, ArmorMaterialType material)
        {
            if (material == ArmorMaterialType.Studded || material == ArmorMaterialType.Leather || material == ArmorMaterialType.Spined ||
                material == ArmorMaterialType.Horned || material == ArmorMaterialType.Barbed)
            {
                if (info.Level == 0)
                    return CraftResource.RegularLeather;
                else if (info.Level == 1)
                    return CraftResource.SpinedLeather;
                else if (info.Level == 2)
                    return CraftResource.HornedLeather;
                else if (info.Level == 3)
                    return CraftResource.BarbedLeather;
                else if (info.Level == 4)
                    return CraftResource.DullLeather;
                else if (info.Level == 5)
                    return CraftResource.ShadowLeather;
                else if (info.Level == 6)
                    return CraftResource.CopperLeather;
                else if (info.Level == 7)
                    return CraftResource.BronzeLeather;
                else if (info.Level == 8)
                    return CraftResource.GoldenLeather;
                else if (info.Level == 9)
                    return CraftResource.SilverLeather;
                else if (info.Level == 10)
                    return CraftResource.AgapiteLeather;
                else if (info.Level == 11)
                    return CraftResource.VeriteLeather;
                else if (info.Level == 12)
                    return CraftResource.ValoriteLeather;
                else if (info.Level == 13)
                    return CraftResource.UridiumLeather;
                else if (info.Level == 14)
                    return CraftResource.AmberLeather;
                else if (info.Level == 15)
                    return CraftResource.AmethystLeather;
                else if (info.Level == 16)
                    return CraftResource.AragoniteLeather;
                else if (info.Level == 17)
                    return CraftResource.BixbiteLeather;
                else if (info.Level == 18)
                    return CraftResource.BloodLeather;
                else if (info.Level == 19)
                    return CraftResource.AmazonLeather;
                else if (info.Level == 20)
                    return CraftResource.GuardiansLeather;
                return CraftResource.None;
            }

            return GetFromOreInfo(info);
        }
    }

    // NOTE: This class is only for compatability with very old RunUO versions.
    // No changes to it should be required for custom resources.
    public class OreInfo
    {
        public static readonly OreInfo Iron = new OreInfo(0, 0x000, "Iron");
        public static readonly OreInfo DullCopper = new OreInfo(1, 0x973, "Dull Copper");
        public static readonly OreInfo ShadowIron = new OreInfo(2, 0x966, "Shadow Iron");
        public static readonly OreInfo Copper = new OreInfo(3, 0x96D, "Copper");
        public static readonly OreInfo Bronze = new OreInfo(4, 0x972, "Bronze");
        public static readonly OreInfo Gold = new OreInfo(5, 0x8A5, "Gold");
        public static readonly OreInfo Silver = new OreInfo(6, 0x8A5, "Silver");
        public static readonly OreInfo Agapite = new OreInfo(7, 0x979, "Agapite");
        public static readonly OreInfo Verite = new OreInfo(8, 0x89F, "Verite");
        public static readonly OreInfo Valorite = new OreInfo(9, 0x8AB, "Valorite");
        public static readonly OreInfo Uridium = new OreInfo(10, 0x000, "Uridium");
        public static readonly OreInfo Trillium = new OreInfo(11, 0x000, "Trillium");
        public static readonly OreInfo Titanium = new OreInfo(12, 0x000, "Titanium");
        public static readonly OreInfo Platinum = new OreInfo(13, 0x000, "Platinum");
        public static readonly OreInfo Zenite = new OreInfo(14, 0x000, "Zenite");
        public static readonly OreInfo Naquinite = new OreInfo(15, 0x000, "Naquinite");
        public static readonly OreInfo Galvinite = new OreInfo(16, 0x000, "Galvinite");
        public static readonly OreInfo Trilamide = new OreInfo(17, 0x000, "Trilamide");
        public static readonly OreInfo Veramide = new OreInfo(18, 0x000, "Veramide");
        public static readonly OreInfo Zenlamide = new OreInfo(19, 0x000, "Zenlamide");
        public static readonly OreInfo Guardians = new OreInfo(20, 0x000, "Guardians");

        private readonly int m_Level;
        private readonly int m_Hue;
        private readonly string m_Name;

        public OreInfo(int level, int hue, string name)
        {
            this.m_Level = level;
            this.m_Hue = hue;
            this.m_Name = name;
        }

        public int Level
        {
            get
            {
                return this.m_Level;
            }
        }

        public int Hue
        {
            get
            {
                return this.m_Hue;
            }
        }

        public string Name
        {
            get
            {
                return this.m_Name;
            }
        }
    }
}