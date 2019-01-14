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
        public static readonly CraftAttributeInfo OakWood, AshWood, YewWood, Heartwood, Bloodwood, Frostwood, Calcitewood, Goldwood, Labradoritewood, Moldavitewood, Morganitewood, Quartzwood, Rhodonitewood, Rubywood, Sapphirewood, Sugilitewood, Tanzanitewood, TurquoisewoodVarisitewood, Guardianswood;

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

            CraftAttributeInfo OakWood = OakWood = new CraftAttributeInfo();

            OakWood.m_ArmorColdResist = 3;
            OakWood.m_ArmorEnergyResist = 3;
            OakWood.m_ArmorFireResist = 3;
            OakWood.m_ArmorPhysicalResist = 98;
            OakWood.m_ArmorPoisonResist = 3;
            OakWood.m_ArmorDamage = 3;
            OakWood.m_ArmorDurability = 12;
            OakWood.m_ArmorGoldIncrease = 12;
            OakWood.m_ArmorHitChance = 1;
            OakWood.m_ArmorLowerRequirements = 0;
            OakWood.m_ArmorMage = 0;
            OakWood.m_ArmorLuck = 1;
            OakWood.m_RunicMinAttributes = 1;
            OakWood.m_RunicMaxAttributes = 2;
            OakWood.m_RunicMinIntensity = 4;
            OakWood.m_RunicMaxIntensity = 8;
            OakWood.m_ShieldColdResist = 3;
            OakWood.m_ShieldEnergyResist = 3;
            OakWood.m_ShieldFireResist = 3;
            OakWood.m_ShieldPhysicalResist = 98;
            OakWood.m_ShieldPoisonResist = 3;
            OakWood.m_WeaponChaosDamage = 3;
            OakWood.m_WeaponColdDamage = 3;
            OakWood.m_WeaponEnergyDamage = 3;
            OakWood.m_WeaponFireDamage = 3;
            OakWood.m_WeaponPoisonDamage = 3;
            OakWood.m_WeaponDirectDamage = 3;
            OakWood.m_WeaponDamage = 3;
            OakWood.m_WeaponDurability = 12;
            OakWood.m_WeaponGoldIncrease = 12;
            OakWood.m_WeaponHitChance = 0;
            OakWood.m_WeaponHitLifeLeech = 1;
            OakWood.m_WeaponLowerRequirements = 0;
            OakWood.m_WeaponLuck = 25;
            OakWood.m_WeaponSwingSpeed = 0;
            OakWood.m_ArmorRegenHits = 0;
            OakWood.m_WeaponRegenHits = 0;
            OakWood.AttackChance = 0;
            OakWood.BonusDex = 0;
            OakWood.BonusHits = 0;
            OakWood.BonusInt = 0;
            OakWood.BonusMana = 0;
            OakWood.BonusStam = 0;
            OakWood.BonusStr = 0;
            OakWood.CastRecovery = 0;
            OakWood.CastSpeed = 0;
            OakWood.Cold = 0;
            OakWood.DefendChance = 0;
            OakWood.DurabilityBonus = 5;
            OakWood.Energy = 0;
            OakWood.EnhancePotions = 1;
            OakWood.Fire = 0;
            OakWood.HitColdArea = 2;
            OakWood.HitDispel = 2;
            OakWood.HitEnergyArea = 2;
            OakWood.HitFireArea = 2;
            OakWood.HitFireball = 2;
            OakWood.HitHarm = 2;
            OakWood.HitLeechHits = 2;
            OakWood.HitLeechMana = 2;
            OakWood.HitLeechStam = 2;
            OakWood.HitLightning = 2;
            OakWood.HitLowerAttack = 2;
            OakWood.HitLowerDefend = 2;
            OakWood.HitMagicArrow = 2;
            OakWood.HitPhysicalArea = 2;
            OakWood.HitPoisonArea = 2;
            OakWood.LowerManaCost = 0;
            OakWood.LowerRegCost = 1;
            OakWood.LowerStatReq = 0;
            OakWood.LowerStatReq = 0;
            OakWood.Luck = 0;
            OakWood.MageArmor = 0;
            OakWood.MageWeapon = 0;
            OakWood.NightSight = 0;
            OakWood.Physical = 0;
            OakWood.Poison = 0;
            OakWood.ReflectPhysical = 0;
            OakWood.RegenHits = 0;
            OakWood.RegenMana = 0;
            OakWood.RegenStam = 0;
            OakWood.ResistColdBonus = 0;
            OakWood.ResistEnergyBonus = 0;
            OakWood.ResistFireBonus = 0;
            OakWood.ResistPhysicalBonus = 0;
            OakWood.ResistPoisonBonus = 0;
            OakWood.SelfRepair = 0;
            OakWood.SpellChanneling = 0;
            OakWood.SpellDamage = 0;
            OakWood.UseBestSkill = 0;
            OakWood.WeaponDamage = 1;
            OakWood.WeaponSpeed = 0;

            CraftAttributeInfo AshWood = AshWood = new CraftAttributeInfo();

            AshWood.m_ArmorColdResist = 6;
            AshWood.m_ArmorEnergyResist = 6;
            AshWood.m_ArmorFireResist = 6;
            AshWood.m_ArmorPhysicalResist = 96;
            AshWood.m_ArmorPoisonResist = 6;
            AshWood.m_ArmorDamage = 6;
            AshWood.m_ArmorDurability = 24;
            AshWood.m_ArmorGoldIncrease = 24;
            AshWood.m_ArmorHitChance = 2;
            AshWood.m_ArmorLowerRequirements = 0;
            AshWood.m_ArmorMage = 0;
            AshWood.m_ArmorLuck = 2;
            AshWood.m_RunicMinAttributes = 3;
            AshWood.m_RunicMaxAttributes = 3;
            AshWood.m_RunicMinIntensity = 11;
            AshWood.m_RunicMaxIntensity = 11;
            AshWood.m_ShieldColdResist = 6;
            AshWood.m_ShieldEnergyResist = 6;
            AshWood.m_ShieldFireResist = 6;
            AshWood.m_ShieldPhysicalResist = 96;
            AshWood.m_ShieldPoisonResist = 6;
            AshWood.m_WeaponChaosDamage = 6;
            AshWood.m_WeaponColdDamage = 6;
            AshWood.m_WeaponEnergyDamage = 6;
            AshWood.m_WeaponFireDamage = 6;
            AshWood.m_WeaponPoisonDamage = 6;
            AshWood.m_WeaponDirectDamage = 6;
            AshWood.m_WeaponDamage = 6;
            AshWood.m_WeaponDurability = 24;
            AshWood.m_WeaponGoldIncrease = 24;
            AshWood.m_WeaponHitChance = 0;
            AshWood.m_WeaponHitLifeLeech = 2;
            AshWood.m_WeaponLowerRequirements = 0;
            AshWood.m_WeaponLuck = 50;
            AshWood.m_WeaponSwingSpeed = 0;
            AshWood.m_ArmorRegenHits = 0;
            AshWood.m_WeaponRegenHits = 0;
            AshWood.AttackChance = 1;
            AshWood.BonusDex = 0;
            AshWood.BonusHits = 0;
            AshWood.BonusInt = 0;
            AshWood.BonusMana = 0;
            AshWood.BonusStam = 0;
            AshWood.BonusStr = 0;
            AshWood.CastRecovery = 0;
            AshWood.CastSpeed = 0;
            AshWood.Cold = 1;
            AshWood.DefendChance = 1;
            AshWood.DurabilityBonus = 10;
            AshWood.Energy = 1;
            AshWood.EnhancePotions = 2;
            AshWood.Fire = 1;
            AshWood.HitColdArea = 5;
            AshWood.HitDispel = 5;
            AshWood.HitEnergyArea = 5;
            AshWood.HitFireArea = 5;
            AshWood.HitFireball = 5;
            AshWood.HitHarm = 5;
            AshWood.HitLeechHits = 5;
            AshWood.HitLeechMana = 5;
            AshWood.HitLeechStam = 5;
            AshWood.HitLightning = 5;
            AshWood.HitLowerAttack = 5;
            AshWood.HitLowerDefend = 5;
            AshWood.HitMagicArrow = 5;
            AshWood.HitPhysicalArea = 5;
            AshWood.HitPoisonArea = 5;
            AshWood.LowerManaCost = 0;
            AshWood.LowerRegCost = 2;
            AshWood.LowerStatReq = 0;
            AshWood.LowerStatReq = 0;
            AshWood.Luck = 0;
            AshWood.MageArmor = 0;
            AshWood.MageWeapon = 1;
            AshWood.NightSight = 0;
            AshWood.Physical = 1;
            AshWood.Poison = 1;
            AshWood.ReflectPhysical = 1;
            AshWood.RegenHits = 0;
            AshWood.RegenMana = 0;
            AshWood.RegenStam = 0;
            AshWood.ResistColdBonus = 1;
            AshWood.ResistEnergyBonus = 1;
            AshWood.ResistFireBonus = 1;
            AshWood.ResistPhysicalBonus = 1;
            AshWood.ResistPoisonBonus = 1;
            AshWood.SelfRepair = 0;
            AshWood.SpellChanneling = 0;
            AshWood.SpellDamage = 1;
            AshWood.UseBestSkill = 0;
            AshWood.WeaponDamage = 2;
            AshWood.WeaponSpeed = 0;

            CraftAttributeInfo YewWood = YewWood = new CraftAttributeInfo();

            YewWood.m_ArmorColdResist = 9;
            YewWood.m_ArmorEnergyResist = 9;
            YewWood.m_ArmorFireResist = 9;
            YewWood.m_ArmorPhysicalResist = 94;
            YewWood.m_ArmorPoisonResist = 9;
            YewWood.m_ArmorDamage = 9;
            YewWood.m_ArmorDurability = 36;
            YewWood.m_ArmorGoldIncrease = 36;
            YewWood.m_ArmorHitChance = 3;
            YewWood.m_ArmorLowerRequirements = 0;
            YewWood.m_ArmorMage = 0;
            YewWood.m_ArmorLuck = 3;
            YewWood.m_RunicMinAttributes = 4;
            YewWood.m_RunicMaxAttributes = 5;
            YewWood.m_RunicMinIntensity = 14;
            YewWood.m_RunicMaxIntensity = 18;
            YewWood.m_ShieldColdResist = 9;
            YewWood.m_ShieldEnergyResist = 9;
            YewWood.m_ShieldFireResist = 9;
            YewWood.m_ShieldPhysicalResist = 94;
            YewWood.m_ShieldPoisonResist = 9;
            YewWood.m_WeaponChaosDamage = 9;
            YewWood.m_WeaponColdDamage = 9;
            YewWood.m_WeaponEnergyDamage = 9;
            YewWood.m_WeaponFireDamage = 9;
            YewWood.m_WeaponPoisonDamage = 9;
            YewWood.m_WeaponDirectDamage = 9;
            YewWood.m_WeaponDamage = 9;
            YewWood.m_WeaponDurability = 36;
            YewWood.m_WeaponGoldIncrease = 36;
            YewWood.m_WeaponHitChance = 0;
            YewWood.m_WeaponHitLifeLeech = 3;
            YewWood.m_WeaponLowerRequirements = 0;
            YewWood.m_WeaponLuck = 75;
            YewWood.m_WeaponSwingSpeed = 0;
            YewWood.m_ArmorRegenHits = 0;
            YewWood.m_WeaponRegenHits = 0;
            YewWood.AttackChance = 2;
            YewWood.BonusDex = 1;
            YewWood.BonusHits = 0;
            YewWood.BonusInt = 1;
            YewWood.BonusMana = 1;
            YewWood.BonusStam = 1;
            YewWood.BonusStr = 1;
            YewWood.CastRecovery = 0;
            YewWood.CastSpeed = 0;
            YewWood.Cold = 2;
            YewWood.DefendChance = 2;
            YewWood.DurabilityBonus = 15;
            YewWood.Energy = 2;
            YewWood.EnhancePotions = 3;
            YewWood.Fire = 2;
            YewWood.HitColdArea = 7;
            YewWood.HitDispel = 7;
            YewWood.HitEnergyArea = 7;
            YewWood.HitFireArea = 7;
            YewWood.HitFireball = 7;
            YewWood.HitHarm = 7;
            YewWood.HitLeechHits = 7;
            YewWood.HitLeechMana = 7;
            YewWood.HitLeechStam = 7;
            YewWood.HitLightning = 7;
            YewWood.HitLowerAttack = 7;
            YewWood.HitLowerDefend = 7;
            YewWood.HitMagicArrow = 7;
            YewWood.HitPhysicalArea = 7;
            YewWood.HitPoisonArea = 7;
            YewWood.LowerManaCost = 1;
            YewWood.LowerRegCost = 3;
            YewWood.LowerStatReq = 0;
            YewWood.LowerStatReq = 0;
            YewWood.Luck = 0;
            YewWood.MageArmor = 0;
            YewWood.MageWeapon = 1;
            YewWood.NightSight = 0;
            YewWood.Physical = 2;
            YewWood.Poison = 2;
            YewWood.ReflectPhysical = 2;
            YewWood.RegenHits = 0;
            YewWood.RegenMana = 0;
            YewWood.RegenStam = 0;
            YewWood.ResistColdBonus = 2;
            YewWood.ResistEnergyBonus = 2;
            YewWood.ResistFireBonus = 2;
            YewWood.ResistPhysicalBonus = 2;
            YewWood.ResistPoisonBonus = 2;
            YewWood.SelfRepair = 0;
            YewWood.SpellChanneling = 0;
            YewWood.SpellDamage = 1;
            YewWood.UseBestSkill = 0;
            YewWood.WeaponDamage = 3;
            YewWood.WeaponSpeed = 0;

            CraftAttributeInfo Heartwood = Heartwood = new CraftAttributeInfo();

            Heartwood.m_ArmorColdResist = 12;
            Heartwood.m_ArmorEnergyResist = 12;
            Heartwood.m_ArmorFireResist = 12;
            Heartwood.m_ArmorPhysicalResist = 92;
            Heartwood.m_ArmorPoisonResist = 12;
            Heartwood.m_ArmorDamage = 12;
            Heartwood.m_ArmorDurability = 48;
            Heartwood.m_ArmorGoldIncrease = 48;
            Heartwood.m_ArmorHitChance = 5;
            Heartwood.m_ArmorLowerRequirements = 0;
            Heartwood.m_ArmorMage = 0;
            Heartwood.m_ArmorLuck = 5;
            Heartwood.m_RunicMinAttributes = 6;
            Heartwood.m_RunicMaxAttributes = 6;
            Heartwood.m_RunicMinIntensity = 21;
            Heartwood.m_RunicMaxIntensity = 21;
            Heartwood.m_ShieldColdResist = 12;
            Heartwood.m_ShieldEnergyResist = 12;
            Heartwood.m_ShieldFireResist = 12;
            Heartwood.m_ShieldPhysicalResist = 92;
            Heartwood.m_ShieldPoisonResist = 12;
            Heartwood.m_WeaponChaosDamage = 12;
            Heartwood.m_WeaponColdDamage = 12;
            Heartwood.m_WeaponEnergyDamage = 12;
            Heartwood.m_WeaponFireDamage = 12;
            Heartwood.m_WeaponPoisonDamage = 12;
            Heartwood.m_WeaponDirectDamage = 12;
            Heartwood.m_WeaponDamage = 12;
            Heartwood.m_WeaponDurability = 48;
            Heartwood.m_WeaponGoldIncrease = 48;
            Heartwood.m_WeaponHitChance = 1;
            Heartwood.m_WeaponHitLifeLeech = 5;
            Heartwood.m_WeaponLowerRequirements = 0;
            Heartwood.m_WeaponLuck = 100;
            Heartwood.m_WeaponSwingSpeed = 0;
            Heartwood.m_ArmorRegenHits = 0;
            Heartwood.m_WeaponRegenHits = 0;
            Heartwood.AttackChance = 3;
            Heartwood.BonusDex = 1;
            Heartwood.BonusHits = 1;
            Heartwood.BonusInt = 1;
            Heartwood.BonusMana = 1;
            Heartwood.BonusStam = 1;
            Heartwood.BonusStr = 1;
            Heartwood.CastRecovery = 0;
            Heartwood.CastSpeed = 0;
            Heartwood.Cold = 3;
            Heartwood.DefendChance = 3;
            Heartwood.DurabilityBonus = 20;
            Heartwood.Energy = 3;
            Heartwood.EnhancePotions = 5;
            Heartwood.Fire = 3;
            Heartwood.HitColdArea = 10;
            Heartwood.HitDispel = 10;
            Heartwood.HitEnergyArea = 10;
            Heartwood.HitFireArea = 10;
            Heartwood.HitFireball = 10;
            Heartwood.HitHarm = 10;
            Heartwood.HitLeechHits = 10;
            Heartwood.HitLeechMana = 10;
            Heartwood.HitLeechStam = 10;
            Heartwood.HitLightning = 10;
            Heartwood.HitLowerAttack = 10;
            Heartwood.HitLowerDefend = 10;
            Heartwood.HitMagicArrow = 10;
            Heartwood.HitPhysicalArea = 10;
            Heartwood.HitPoisonArea = 10;
            Heartwood.LowerManaCost = 1;
            Heartwood.LowerRegCost = 4;
            Heartwood.LowerStatReq = 0;
            Heartwood.LowerStatReq = 0;
            Heartwood.Luck = 0;
            Heartwood.MageArmor = 0;
            Heartwood.MageWeapon = 2;
            Heartwood.NightSight = 0;
            Heartwood.Physical = 3;
            Heartwood.Poison = 3;
            Heartwood.ReflectPhysical = 3;
            Heartwood.RegenHits = 0;
            Heartwood.RegenMana = 0;
            Heartwood.RegenStam = 0;
            Heartwood.ResistColdBonus = 3;
            Heartwood.ResistEnergyBonus = 3;
            Heartwood.ResistFireBonus = 3;
            Heartwood.ResistPhysicalBonus = 3;
            Heartwood.ResistPoisonBonus = 3;
            Heartwood.SelfRepair = 1;
            Heartwood.SpellChanneling = 0;
            Heartwood.SpellDamage = 2;
            Heartwood.UseBestSkill = 0;
            Heartwood.WeaponDamage = 5;
            Heartwood.WeaponSpeed = 0;

            CraftAttributeInfo Bloodwood = Bloodwood = new CraftAttributeInfo();

            Bloodwood.m_ArmorColdResist = 15;
            Bloodwood.m_ArmorEnergyResist = 15;
            Bloodwood.m_ArmorFireResist = 15;
            Bloodwood.m_ArmorPhysicalResist = 90;
            Bloodwood.m_ArmorPoisonResist = 15;
            Bloodwood.m_ArmorDamage = 15;
            Bloodwood.m_ArmorDurability = 60;
            Bloodwood.m_ArmorGoldIncrease = 60;
            Bloodwood.m_ArmorHitChance = 6;
            Bloodwood.m_ArmorLowerRequirements = 0;
            Bloodwood.m_ArmorMage = 0;
            Bloodwood.m_ArmorLuck = 6;
            Bloodwood.m_RunicMinAttributes = 7;
            Bloodwood.m_RunicMaxAttributes = 8;
            Bloodwood.m_RunicMinIntensity = 24;
            Bloodwood.m_RunicMaxIntensity = 27;
            Bloodwood.m_ShieldColdResist = 15;
            Bloodwood.m_ShieldEnergyResist = 15;
            Bloodwood.m_ShieldFireResist = 15;
            Bloodwood.m_ShieldPhysicalResist = 90;
            Bloodwood.m_ShieldPoisonResist = 15;
            Bloodwood.m_WeaponChaosDamage = 15;
            Bloodwood.m_WeaponColdDamage = 15;
            Bloodwood.m_WeaponEnergyDamage = 15;
            Bloodwood.m_WeaponFireDamage = 15;
            Bloodwood.m_WeaponPoisonDamage = 15;
            Bloodwood.m_WeaponDirectDamage = 15;
            Bloodwood.m_WeaponDamage = 15;
            Bloodwood.m_WeaponDurability = 60;
            Bloodwood.m_WeaponGoldIncrease = 60;
            Bloodwood.m_WeaponHitChance = 1;
            Bloodwood.m_WeaponHitLifeLeech = 6;
            Bloodwood.m_WeaponLowerRequirements = 0;
            Bloodwood.m_WeaponLuck = 124;
            Bloodwood.m_WeaponSwingSpeed = 0;
            Bloodwood.m_ArmorRegenHits = 0;
            Bloodwood.m_WeaponRegenHits = 0;
            Bloodwood.AttackChance = 3;
            Bloodwood.BonusDex = 2;
            Bloodwood.BonusHits = 1;
            Bloodwood.BonusInt = 2;
            Bloodwood.BonusMana = 2;
            Bloodwood.BonusStam = 2;
            Bloodwood.BonusStr = 2;
            Bloodwood.CastRecovery = 0;
            Bloodwood.CastSpeed = 0;
            Bloodwood.Cold = 3;
            Bloodwood.DefendChance = 3;
            Bloodwood.DurabilityBonus = 25;
            Bloodwood.Energy = 3;
            Bloodwood.EnhancePotions = 6;
            Bloodwood.Fire = 3;
            Bloodwood.HitColdArea = 12;
            Bloodwood.HitDispel = 12;
            Bloodwood.HitEnergyArea = 12;
            Bloodwood.HitFireArea = 12;
            Bloodwood.HitFireball = 12;
            Bloodwood.HitHarm = 12;
            Bloodwood.HitLeechHits = 12;
            Bloodwood.HitLeechMana = 12;
            Bloodwood.HitLeechStam = 12;
            Bloodwood.HitLightning = 12;
            Bloodwood.HitLowerAttack = 12;
            Bloodwood.HitLowerDefend = 12;
            Bloodwood.HitMagicArrow = 12;
            Bloodwood.HitPhysicalArea = 12;
            Bloodwood.HitPoisonArea = 12;
            Bloodwood.LowerManaCost = 2;
            Bloodwood.LowerRegCost = 5;
            Bloodwood.LowerStatReq = 0;
            Bloodwood.LowerStatReq = 0;
            Bloodwood.Luck = 0;
            Bloodwood.MageArmor = 0;
            Bloodwood.MageWeapon = 2;
            Bloodwood.NightSight = 0;
            Bloodwood.Physical = 3;
            Bloodwood.Poison = 3;
            Bloodwood.ReflectPhysical = 3;
            Bloodwood.RegenHits = 0;
            Bloodwood.RegenMana = 0;
            Bloodwood.RegenStam = 0;
            Bloodwood.ResistColdBonus = 3;
            Bloodwood.ResistEnergyBonus = 3;
            Bloodwood.ResistFireBonus = 3;
            Bloodwood.ResistPhysicalBonus = 3;
            Bloodwood.ResistPoisonBonus = 3;
            Bloodwood.SelfRepair = 1;
            Bloodwood.SpellChanneling = 0;
            Bloodwood.SpellDamage = 3;
            Bloodwood.UseBestSkill = 0;
            Bloodwood.WeaponDamage = 6;
            Bloodwood.WeaponSpeed = 0;

            CraftAttributeInfo Frostwood = Frostwood = new CraftAttributeInfo();

            Frostwood.m_ArmorColdResist = 18;
            Frostwood.m_ArmorEnergyResist = 18;
            Frostwood.m_ArmorFireResist = 18;
            Frostwood.m_ArmorPhysicalResist = 88;
            Frostwood.m_ArmorPoisonResist = 18;
            Frostwood.m_ArmorDamage = 18;
            Frostwood.m_ArmorDurability = 72;
            Frostwood.m_ArmorGoldIncrease = 72;
            Frostwood.m_ArmorHitChance = 7;
            Frostwood.m_ArmorLowerRequirements = 0;
            Frostwood.m_ArmorMage = 0;
            Frostwood.m_ArmorLuck = 7;
            Frostwood.m_RunicMinAttributes = 9;
            Frostwood.m_RunicMaxAttributes = 9;
            Frostwood.m_RunicMinIntensity = 31;
            Frostwood.m_RunicMaxIntensity = 31;
            Frostwood.m_ShieldColdResist = 18;
            Frostwood.m_ShieldEnergyResist = 18;
            Frostwood.m_ShieldFireResist = 18;
            Frostwood.m_ShieldPhysicalResist = 88;
            Frostwood.m_ShieldPoisonResist = 18;
            Frostwood.m_WeaponChaosDamage = 18;
            Frostwood.m_WeaponColdDamage = 18;
            Frostwood.m_WeaponEnergyDamage = 18;
            Frostwood.m_WeaponFireDamage = 18;
            Frostwood.m_WeaponPoisonDamage = 18;
            Frostwood.m_WeaponDirectDamage = 18;
            Frostwood.m_WeaponDamage = 18;
            Frostwood.m_WeaponDurability = 72;
            Frostwood.m_WeaponGoldIncrease = 72;
            Frostwood.m_WeaponHitChance = 1;
            Frostwood.m_WeaponHitLifeLeech = 7;
            Frostwood.m_WeaponLowerRequirements = 0;
            Frostwood.m_WeaponLuck = 149;
            Frostwood.m_WeaponSwingSpeed = 0;
            Frostwood.m_ArmorRegenHits = 0;
            Frostwood.m_WeaponRegenHits = 0;
            Frostwood.AttackChance = 4;
            Frostwood.BonusDex = 2;
            Frostwood.BonusHits = 1;
            Frostwood.BonusInt = 2;
            Frostwood.BonusMana = 2;
            Frostwood.BonusStam = 2;
            Frostwood.BonusStr = 2;
            Frostwood.CastRecovery = 0;
            Frostwood.CastSpeed = 0;
            Frostwood.Cold = 4;
            Frostwood.DefendChance = 4;
            Frostwood.DurabilityBonus = 30;
            Frostwood.Energy = 4;
            Frostwood.EnhancePotions = 7;
            Frostwood.Fire = 4;
            Frostwood.HitColdArea = 15;
            Frostwood.HitDispel = 15;
            Frostwood.HitEnergyArea = 15;
            Frostwood.HitFireArea = 15;
            Frostwood.HitFireball = 15;
            Frostwood.HitHarm = 15;
            Frostwood.HitLeechHits = 15;
            Frostwood.HitLeechMana = 15;
            Frostwood.HitLeechStam = 15;
            Frostwood.HitLightning = 15;
            Frostwood.HitLowerAttack = 15;
            Frostwood.HitLowerDefend = 15;
            Frostwood.HitMagicArrow = 15;
            Frostwood.HitPhysicalArea = 15;
            Frostwood.HitPoisonArea = 15;
            Frostwood.LowerManaCost = 2;
            Frostwood.LowerRegCost = 6;
            Frostwood.LowerStatReq = 0;
            Frostwood.LowerStatReq = 0;
            Frostwood.Luck = 0;
            Frostwood.MageArmor = 0;
            Frostwood.MageWeapon = 3;
            Frostwood.NightSight = 0;
            Frostwood.Physical = 4;
            Frostwood.Poison = 4;
            Frostwood.ReflectPhysical = 4;
            Frostwood.RegenHits = 0;
            Frostwood.RegenMana = 0;
            Frostwood.RegenStam = 0;
            Frostwood.ResistColdBonus = 4;
            Frostwood.ResistEnergyBonus = 4;
            Frostwood.ResistFireBonus = 4;
            Frostwood.ResistPhysicalBonus = 4;
            Frostwood.ResistPoisonBonus = 4;
            Frostwood.SelfRepair = 1;
            Frostwood.SpellChanneling = 0;
            Frostwood.SpellDamage = 3;
            Frostwood.UseBestSkill = 0;
            Frostwood.WeaponDamage = 7;
            Frostwood.WeaponSpeed = 0;

            CraftAttributeInfo Calcitewood = Calcitewood = new CraftAttributeInfo();

            Calcitewood.m_ArmorColdResist = 21;
            Calcitewood.m_ArmorEnergyResist = 21;
            Calcitewood.m_ArmorFireResist = 21;
            Calcitewood.m_ArmorPhysicalResist = 86;
            Calcitewood.m_ArmorPoisonResist = 21;
            Calcitewood.m_ArmorDamage = 21;
            Calcitewood.m_ArmorDurability = 84;
            Calcitewood.m_ArmorGoldIncrease = 84;
            Calcitewood.m_ArmorHitChance = 8;
            Calcitewood.m_ArmorLowerRequirements = 0;
            Calcitewood.m_ArmorMage = 0;
            Calcitewood.m_ArmorLuck = 8;
            Calcitewood.m_RunicMinAttributes = 10;
            Calcitewood.m_RunicMaxAttributes = 11;
            Calcitewood.m_RunicMinIntensity = 34;
            Calcitewood.m_RunicMaxIntensity = 37;
            Calcitewood.m_ShieldColdResist = 21;
            Calcitewood.m_ShieldEnergyResist = 21;
            Calcitewood.m_ShieldFireResist = 21;
            Calcitewood.m_ShieldPhysicalResist = 86;
            Calcitewood.m_ShieldPoisonResist = 21;
            Calcitewood.m_WeaponChaosDamage = 21;
            Calcitewood.m_WeaponColdDamage = 21;
            Calcitewood.m_WeaponEnergyDamage = 21;
            Calcitewood.m_WeaponFireDamage = 21;
            Calcitewood.m_WeaponPoisonDamage = 21;
            Calcitewood.m_WeaponDirectDamage = 21;
            Calcitewood.m_WeaponDamage = 21;
            Calcitewood.m_WeaponDurability = 84;
            Calcitewood.m_WeaponGoldIncrease = 84;
            Calcitewood.m_WeaponHitChance = 2;
            Calcitewood.m_WeaponHitLifeLeech = 8;
            Calcitewood.m_WeaponLowerRequirements = 0;
            Calcitewood.m_WeaponLuck = 174;
            Calcitewood.m_WeaponSwingSpeed = 0;
            Calcitewood.m_ArmorRegenHits = 0;
            Calcitewood.m_WeaponRegenHits = 0;
            Calcitewood.AttackChance = 5;
            Calcitewood.BonusDex = 2;
            Calcitewood.BonusHits = 1;
            Calcitewood.BonusInt = 2;
            Calcitewood.BonusMana = 2;
            Calcitewood.BonusStam = 2;
            Calcitewood.BonusStr = 2;
            Calcitewood.CastRecovery = 1;
            Calcitewood.CastSpeed = 0;
            Calcitewood.Cold = 5;
            Calcitewood.DefendChance = 5;
            Calcitewood.DurabilityBonus = 35;
            Calcitewood.Energy = 5;
            Calcitewood.EnhancePotions = 8;
            Calcitewood.Fire = 5;
            Calcitewood.HitColdArea = 17;
            Calcitewood.HitDispel = 17;
            Calcitewood.HitEnergyArea = 17;
            Calcitewood.HitFireArea = 17;
            Calcitewood.HitFireball = 17;
            Calcitewood.HitHarm = 17;
            Calcitewood.HitLeechHits = 17;
            Calcitewood.HitLeechMana = 17;
            Calcitewood.HitLeechStam = 17;
            Calcitewood.HitLightning = 17;
            Calcitewood.HitLowerAttack = 17;
            Calcitewood.HitLowerDefend = 17;
            Calcitewood.HitMagicArrow = 17;
            Calcitewood.HitPhysicalArea = 17;
            Calcitewood.HitPoisonArea = 17;
            Calcitewood.LowerManaCost = 2;
            Calcitewood.LowerRegCost = 7;
            Calcitewood.LowerStatReq = 0;
            Calcitewood.LowerStatReq = 0;
            Calcitewood.Luck = 0;
            Calcitewood.MageArmor = 0;
            Calcitewood.MageWeapon = 3;
            Calcitewood.NightSight = 0;
            Calcitewood.Physical = 5;
            Calcitewood.Poison = 5;
            Calcitewood.ReflectPhysical = 5;
            Calcitewood.RegenHits = 0;
            Calcitewood.RegenMana = 0;
            Calcitewood.RegenStam = 1;
            Calcitewood.ResistColdBonus = 5;
            Calcitewood.ResistEnergyBonus = 5;
            Calcitewood.ResistFireBonus = 5;
            Calcitewood.ResistPhysicalBonus = 5;
            Calcitewood.ResistPoisonBonus = 5;
            Calcitewood.SelfRepair = 1;
            Calcitewood.SpellChanneling = 0;
            Calcitewood.SpellDamage = 4;
            Calcitewood.UseBestSkill = 0;
            Calcitewood.WeaponDamage = 8;
            Calcitewood.WeaponSpeed = 0;

            CraftAttributeInfo Goldwood = Goldwood = new CraftAttributeInfo();

            Goldwood.m_ArmorColdResist = 24;
            Goldwood.m_ArmorEnergyResist = 24;
            Goldwood.m_ArmorFireResist = 24;
            Goldwood.m_ArmorPhysicalResist = 84;
            Goldwood.m_ArmorPoisonResist = 24;
            Goldwood.m_ArmorDamage = 24;
            Goldwood.m_ArmorDurability = 96;
            Goldwood.m_ArmorGoldIncrease = 96;
            Goldwood.m_ArmorHitChance = 10;
            Goldwood.m_ArmorLowerRequirements = 0;
            Goldwood.m_ArmorMage = 0;
            Goldwood.m_ArmorLuck = 10;
            Goldwood.m_RunicMinAttributes = 12;
            Goldwood.m_RunicMaxAttributes = 12;
            Goldwood.m_RunicMinIntensity = 41;
            Goldwood.m_RunicMaxIntensity = 41;
            Goldwood.m_ShieldColdResist = 24;
            Goldwood.m_ShieldEnergyResist = 24;
            Goldwood.m_ShieldFireResist = 24;
            Goldwood.m_ShieldPhysicalResist = 84;
            Goldwood.m_ShieldPoisonResist = 24;
            Goldwood.m_WeaponChaosDamage = 24;
            Goldwood.m_WeaponColdDamage = 24;
            Goldwood.m_WeaponEnergyDamage = 24;
            Goldwood.m_WeaponFireDamage = 24;
            Goldwood.m_WeaponPoisonDamage = 24;
            Goldwood.m_WeaponDirectDamage = 24;
            Goldwood.m_WeaponDamage = 24;
            Goldwood.m_WeaponDurability = 96;
            Goldwood.m_WeaponGoldIncrease = 96;
            Goldwood.m_WeaponHitChance = 2;
            Goldwood.m_WeaponHitLifeLeech = 10;
            Goldwood.m_WeaponLowerRequirements = 0;
            Goldwood.m_WeaponLuck = 199;
            Goldwood.m_WeaponSwingSpeed = 0;
            Goldwood.m_ArmorRegenHits = 0;
            Goldwood.m_WeaponRegenHits = 0;
            Goldwood.AttackChance = 6;
            Goldwood.BonusDex = 3;
            Goldwood.BonusHits = 2;
            Goldwood.BonusInt = 3;
            Goldwood.BonusMana = 3;
            Goldwood.BonusStam = 3;
            Goldwood.BonusStr = 3;
            Goldwood.CastRecovery = 1;
            Goldwood.CastSpeed = 0;
            Goldwood.Cold = 6;
            Goldwood.DefendChance = 6;
            Goldwood.DurabilityBonus = 40;
            Goldwood.Energy = 6;
            Goldwood.EnhancePotions = 10;
            Goldwood.Fire = 6;
            Goldwood.HitColdArea = 20;
            Goldwood.HitDispel = 20;
            Goldwood.HitEnergyArea = 20;
            Goldwood.HitFireArea = 20;
            Goldwood.HitFireball = 20;
            Goldwood.HitHarm = 20;
            Goldwood.HitLeechHits = 20;
            Goldwood.HitLeechMana = 20;
            Goldwood.HitLeechStam = 20;
            Goldwood.HitLightning = 20;
            Goldwood.HitLowerAttack = 20;
            Goldwood.HitLowerDefend = 20;
            Goldwood.HitMagicArrow = 20;
            Goldwood.HitPhysicalArea = 20;
            Goldwood.HitPoisonArea = 20;
            Goldwood.LowerManaCost = 3;
            Goldwood.LowerRegCost = 8;
            Goldwood.LowerStatReq = 0;
            Goldwood.LowerStatReq = 0;
            Goldwood.Luck = 0;
            Goldwood.MageArmor = 0;
            Goldwood.MageWeapon = 4;
            Goldwood.NightSight = 0;
            Goldwood.Physical = 6;
            Goldwood.Poison = 6;
            Goldwood.ReflectPhysical = 6;
            Goldwood.RegenHits = 0;
            Goldwood.RegenMana = 0;
            Goldwood.RegenStam = 1;
            Goldwood.ResistColdBonus = 6;
            Goldwood.ResistEnergyBonus = 6;
            Goldwood.ResistFireBonus = 6;
            Goldwood.ResistPhysicalBonus = 6;
            Goldwood.ResistPoisonBonus = 6;
            Goldwood.SelfRepair = 2;
            Goldwood.SpellChanneling = 0;
            Goldwood.SpellDamage = 4;
            Goldwood.UseBestSkill = 0;
            Goldwood.WeaponDamage = 10;
            Goldwood.WeaponSpeed = 0;

            CraftAttributeInfo Labradoritewood = Labradoritewood = new CraftAttributeInfo();

            Labradoritewood.m_ArmorColdResist = 27;
            Labradoritewood.m_ArmorEnergyResist = 27;
            Labradoritewood.m_ArmorFireResist = 27;
            Labradoritewood.m_ArmorPhysicalResist = 82;
            Labradoritewood.m_ArmorPoisonResist = 27;
            Labradoritewood.m_ArmorDamage = 27;
            Labradoritewood.m_ArmorDurability = 108;
            Labradoritewood.m_ArmorGoldIncrease = 108;
            Labradoritewood.m_ArmorHitChance = 11;
            Labradoritewood.m_ArmorLowerRequirements = 0;
            Labradoritewood.m_ArmorMage = 0;
            Labradoritewood.m_ArmorLuck = 11;
            Labradoritewood.m_RunicMinAttributes = 13;
            Labradoritewood.m_RunicMaxAttributes = 14;
            Labradoritewood.m_RunicMinIntensity = 44;
            Labradoritewood.m_RunicMaxIntensity = 47;
            Labradoritewood.m_ShieldColdResist = 27;
            Labradoritewood.m_ShieldEnergyResist = 27;
            Labradoritewood.m_ShieldFireResist = 27;
            Labradoritewood.m_ShieldPhysicalResist = 82;
            Labradoritewood.m_ShieldPoisonResist = 27;
            Labradoritewood.m_WeaponChaosDamage = 27;
            Labradoritewood.m_WeaponColdDamage = 27;
            Labradoritewood.m_WeaponEnergyDamage = 27;
            Labradoritewood.m_WeaponFireDamage = 27;
            Labradoritewood.m_WeaponPoisonDamage = 27;
            Labradoritewood.m_WeaponDirectDamage = 27;
            Labradoritewood.m_WeaponDamage = 27;
            Labradoritewood.m_WeaponDurability = 108;
            Labradoritewood.m_WeaponGoldIncrease = 108;
            Labradoritewood.m_WeaponHitChance = 2;
            Labradoritewood.m_WeaponHitLifeLeech = 11;
            Labradoritewood.m_WeaponLowerRequirements = 0;
            Labradoritewood.m_WeaponLuck = 224;
            Labradoritewood.m_WeaponSwingSpeed = 0;
            Labradoritewood.m_ArmorRegenHits = 0;
            Labradoritewood.m_WeaponRegenHits = 0;
            Labradoritewood.AttackChance = 6;
            Labradoritewood.BonusDex = 3;
            Labradoritewood.BonusHits = 2;
            Labradoritewood.BonusInt = 3;
            Labradoritewood.BonusMana = 3;
            Labradoritewood.BonusStam = 3;
            Labradoritewood.BonusStr = 3;
            Labradoritewood.CastRecovery = 1;
            Labradoritewood.CastSpeed = 0;
            Labradoritewood.Cold = 6;
            Labradoritewood.DefendChance = 6;
            Labradoritewood.DurabilityBonus = 45;
            Labradoritewood.Energy = 6;
            Labradoritewood.EnhancePotions = 11;
            Labradoritewood.Fire = 6;
            Labradoritewood.HitColdArea = 22;
            Labradoritewood.HitDispel = 22;
            Labradoritewood.HitEnergyArea = 22;
            Labradoritewood.HitFireArea = 22;
            Labradoritewood.HitFireball = 22;
            Labradoritewood.HitHarm = 22;
            Labradoritewood.HitLeechHits = 22;
            Labradoritewood.HitLeechMana = 22;
            Labradoritewood.HitLeechStam = 22;
            Labradoritewood.HitLightning = 22;
            Labradoritewood.HitLowerAttack = 22;
            Labradoritewood.HitLowerDefend = 22;
            Labradoritewood.HitMagicArrow = 22;
            Labradoritewood.HitPhysicalArea = 22;
            Labradoritewood.HitPoisonArea = 22;
            Labradoritewood.LowerManaCost = 3;
            Labradoritewood.LowerRegCost = 9;
            Labradoritewood.LowerStatReq = 0;
            Labradoritewood.LowerStatReq = 0;
            Labradoritewood.Luck = 0;
            Labradoritewood.MageArmor = 0;
            Labradoritewood.MageWeapon = 4;
            Labradoritewood.NightSight = 0;
            Labradoritewood.Physical = 6;
            Labradoritewood.Poison = 6;
            Labradoritewood.ReflectPhysical = 6;
            Labradoritewood.RegenHits = 0;
            Labradoritewood.RegenMana = 0;
            Labradoritewood.RegenStam = 1;
            Labradoritewood.ResistColdBonus = 6;
            Labradoritewood.ResistEnergyBonus = 6;
            Labradoritewood.ResistFireBonus = 6;
            Labradoritewood.ResistPhysicalBonus = 6;
            Labradoritewood.ResistPoisonBonus = 6;
            Labradoritewood.SelfRepair = 2;
            Labradoritewood.SpellChanneling = 0;
            Labradoritewood.SpellDamage = 5;
            Labradoritewood.UseBestSkill = 0;
            Labradoritewood.WeaponDamage = 11;
            Labradoritewood.WeaponSpeed = 0;

            CraftAttributeInfo Moldavitewood = Moldavitewood = new CraftAttributeInfo();

            Moldavitewood.m_ArmorColdResist = 30;
            Moldavitewood.m_ArmorEnergyResist = 30;
            Moldavitewood.m_ArmorFireResist = 30;
            Moldavitewood.m_ArmorPhysicalResist = 80;
            Moldavitewood.m_ArmorPoisonResist = 30;
            Moldavitewood.m_ArmorDamage = 30;
            Moldavitewood.m_ArmorDurability = 120;
            Moldavitewood.m_ArmorGoldIncrease = 120;
            Moldavitewood.m_ArmorHitChance = 12;
            Moldavitewood.m_ArmorLowerRequirements = 0;
            Moldavitewood.m_ArmorMage = 0;
            Moldavitewood.m_ArmorLuck = 12;
            Moldavitewood.m_RunicMinAttributes = 15;
            Moldavitewood.m_RunicMaxAttributes = 15;
            Moldavitewood.m_RunicMinIntensity = 51;
            Moldavitewood.m_RunicMaxIntensity = 51;
            Moldavitewood.m_ShieldColdResist = 30;
            Moldavitewood.m_ShieldEnergyResist = 30;
            Moldavitewood.m_ShieldFireResist = 30;
            Moldavitewood.m_ShieldPhysicalResist = 80;
            Moldavitewood.m_ShieldPoisonResist = 30;
            Moldavitewood.m_WeaponChaosDamage = 30;
            Moldavitewood.m_WeaponColdDamage = 30;
            Moldavitewood.m_WeaponEnergyDamage = 30;
            Moldavitewood.m_WeaponFireDamage = 30;
            Moldavitewood.m_WeaponPoisonDamage = 30;
            Moldavitewood.m_WeaponDirectDamage = 30;
            Moldavitewood.m_WeaponDamage = 30;
            Moldavitewood.m_WeaponDurability = 120;
            Moldavitewood.m_WeaponGoldIncrease = 120;
            Moldavitewood.m_WeaponHitChance = 3;
            Moldavitewood.m_WeaponHitLifeLeech = 12;
            Moldavitewood.m_WeaponLowerRequirements = 0;
            Moldavitewood.m_WeaponLuck = 249;
            Moldavitewood.m_WeaponSwingSpeed = 0;
            Moldavitewood.m_ArmorRegenHits = 0;
            Moldavitewood.m_WeaponRegenHits = 0;
            Moldavitewood.AttackChance = 7;
            Moldavitewood.BonusDex = 4;
            Moldavitewood.BonusHits = 2;
            Moldavitewood.BonusInt = 4;
            Moldavitewood.BonusMana = 4;
            Moldavitewood.BonusStam = 4;
            Moldavitewood.BonusStr = 4;
            Moldavitewood.CastRecovery = 1;
            Moldavitewood.CastSpeed = 0;
            Moldavitewood.Cold = 7;
            Moldavitewood.DefendChance = 7;
            Moldavitewood.DurabilityBonus = 50;
            Moldavitewood.Energy = 7;
            Moldavitewood.EnhancePotions = 12;
            Moldavitewood.Fire = 7;
            Moldavitewood.HitColdArea = 25;
            Moldavitewood.HitDispel = 25;
            Moldavitewood.HitEnergyArea = 25;
            Moldavitewood.HitFireArea = 25;
            Moldavitewood.HitFireball = 25;
            Moldavitewood.HitHarm = 25;
            Moldavitewood.HitLeechHits = 25;
            Moldavitewood.HitLeechMana = 25;
            Moldavitewood.HitLeechStam = 25;
            Moldavitewood.HitLightning = 25;
            Moldavitewood.HitLowerAttack = 25;
            Moldavitewood.HitLowerDefend = 25;
            Moldavitewood.HitMagicArrow = 25;
            Moldavitewood.HitPhysicalArea = 25;
            Moldavitewood.HitPoisonArea = 25;
            Moldavitewood.LowerManaCost = 4;
            Moldavitewood.LowerRegCost = 10;
            Moldavitewood.LowerStatReq = 0;
            Moldavitewood.LowerStatReq = 0;
            Moldavitewood.Luck = 0;
            Moldavitewood.MageArmor = 0;
            Moldavitewood.MageWeapon = 5;
            Moldavitewood.NightSight = 0;
            Moldavitewood.Physical = 7;
            Moldavitewood.Poison = 7;
            Moldavitewood.ReflectPhysical = 7;
            Moldavitewood.RegenHits = 1;
            Moldavitewood.RegenMana = 1;
            Moldavitewood.RegenStam = 1;
            Moldavitewood.ResistColdBonus = 7;
            Moldavitewood.ResistEnergyBonus = 7;
            Moldavitewood.ResistFireBonus = 7;
            Moldavitewood.ResistPhysicalBonus = 7;
            Moldavitewood.ResistPoisonBonus = 7;
            Moldavitewood.SelfRepair = 2;
            Moldavitewood.SpellChanneling = 0;
            Moldavitewood.SpellDamage = 6;
            Moldavitewood.UseBestSkill = 0;
            Moldavitewood.WeaponDamage = 12;
            Moldavitewood.WeaponSpeed = 0;

            CraftAttributeInfo Morganitewood = Morganitewood = new CraftAttributeInfo();

            Morganitewood.m_ArmorColdResist = 33;
            Morganitewood.m_ArmorEnergyResist = 33;
            Morganitewood.m_ArmorFireResist = 33;
            Morganitewood.m_ArmorPhysicalResist = 78;
            Morganitewood.m_ArmorPoisonResist = 33;
            Morganitewood.m_ArmorDamage = 33;
            Morganitewood.m_ArmorDurability = 132;
            Morganitewood.m_ArmorGoldIncrease = 132;
            Morganitewood.m_ArmorHitChance = 13;
            Morganitewood.m_ArmorLowerRequirements = 0;
            Morganitewood.m_ArmorMage = 0;
            Morganitewood.m_ArmorLuck = 13;
            Morganitewood.m_RunicMinAttributes = 16;
            Morganitewood.m_RunicMaxAttributes = 17;
            Morganitewood.m_RunicMinIntensity = 54;
            Morganitewood.m_RunicMaxIntensity = 57;
            Morganitewood.m_ShieldColdResist = 33;
            Morganitewood.m_ShieldEnergyResist = 33;
            Morganitewood.m_ShieldFireResist = 33;
            Morganitewood.m_ShieldPhysicalResist = 78;
            Morganitewood.m_ShieldPoisonResist = 33;
            Morganitewood.m_WeaponChaosDamage = 33;
            Morganitewood.m_WeaponColdDamage = 33;
            Morganitewood.m_WeaponEnergyDamage = 33;
            Morganitewood.m_WeaponFireDamage = 33;
            Morganitewood.m_WeaponPoisonDamage = 33;
            Morganitewood.m_WeaponDirectDamage = 33;
            Morganitewood.m_WeaponDamage = 33;
            Morganitewood.m_WeaponDurability = 132;
            Morganitewood.m_WeaponGoldIncrease = 132;
            Morganitewood.m_WeaponHitChance = 3;
            Morganitewood.m_WeaponHitLifeLeech = 13;
            Morganitewood.m_WeaponLowerRequirements = 0;
            Morganitewood.m_WeaponLuck = 274;
            Morganitewood.m_WeaponSwingSpeed = 0;
            Morganitewood.m_ArmorRegenHits = 0;
            Morganitewood.m_WeaponRegenHits = 0;
            Morganitewood.AttackChance = 8;
            Morganitewood.BonusDex = 4;
            Morganitewood.BonusHits = 2;
            Morganitewood.BonusInt = 4;
            Morganitewood.BonusMana = 4;
            Morganitewood.BonusStam = 4;
            Morganitewood.BonusStr = 4;
            Morganitewood.CastRecovery = 1;
            Morganitewood.CastSpeed = 0;
            Morganitewood.Cold = 8;
            Morganitewood.DefendChance = 8;
            Morganitewood.DurabilityBonus = 55;
            Morganitewood.Energy = 8;
            Morganitewood.EnhancePotions = 13;
            Morganitewood.Fire = 8;
            Morganitewood.HitColdArea = 27;
            Morganitewood.HitDispel = 27;
            Morganitewood.HitEnergyArea = 27;
            Morganitewood.HitFireArea = 27;
            Morganitewood.HitFireball = 27;
            Morganitewood.HitHarm = 27;
            Morganitewood.HitLeechHits = 27;
            Morganitewood.HitLeechMana = 27;
            Morganitewood.HitLeechStam = 27;
            Morganitewood.HitLightning = 27;
            Morganitewood.HitLowerAttack = 27;
            Morganitewood.HitLowerDefend = 27;
            Morganitewood.HitMagicArrow = 27;
            Morganitewood.HitPhysicalArea = 27;
            Morganitewood.HitPoisonArea = 27;
            Morganitewood.LowerManaCost = 4;
            Morganitewood.LowerRegCost = 11;
            Morganitewood.LowerStatReq = 0;
            Morganitewood.LowerStatReq = 0;
            Morganitewood.Luck = 0;
            Morganitewood.MageArmor = 0;
            Morganitewood.MageWeapon = 5;
            Morganitewood.NightSight = 0;
            Morganitewood.Physical = 8;
            Morganitewood.Poison = 8;
            Morganitewood.ReflectPhysical = 8;
            Morganitewood.RegenHits = 1;
            Morganitewood.RegenMana = 1;
            Morganitewood.RegenStam = 1;
            Morganitewood.ResistColdBonus = 8;
            Morganitewood.ResistEnergyBonus = 8;
            Morganitewood.ResistFireBonus = 8;
            Morganitewood.ResistPhysicalBonus = 8;
            Morganitewood.ResistPoisonBonus = 8;
            Morganitewood.SelfRepair = 2;
            Morganitewood.SpellChanneling = 0;
            Morganitewood.SpellDamage = 6;
            Morganitewood.UseBestSkill = 0;
            Morganitewood.WeaponDamage = 13;
            Morganitewood.WeaponSpeed = 0;

            CraftAttributeInfo Quartzwood = Quartzwood = new CraftAttributeInfo();

            Quartzwood.m_ArmorColdResist = 36;
            Quartzwood.m_ArmorEnergyResist = 36;
            Quartzwood.m_ArmorFireResist = 36;
            Quartzwood.m_ArmorPhysicalResist = 76;
            Quartzwood.m_ArmorPoisonResist = 36;
            Quartzwood.m_ArmorDamage = 36;
            Quartzwood.m_ArmorDurability = 144;
            Quartzwood.m_ArmorGoldIncrease = 144;
            Quartzwood.m_ArmorHitChance = 15;
            Quartzwood.m_ArmorLowerRequirements = 0;
            Quartzwood.m_ArmorMage = 0;
            Quartzwood.m_ArmorLuck = 15;
            Quartzwood.m_RunicMinAttributes = 18;
            Quartzwood.m_RunicMaxAttributes = 18;
            Quartzwood.m_RunicMinIntensity = 60;
            Quartzwood.m_RunicMaxIntensity = 60;
            Quartzwood.m_ShieldColdResist = 36;
            Quartzwood.m_ShieldEnergyResist = 36;
            Quartzwood.m_ShieldFireResist = 36;
            Quartzwood.m_ShieldPhysicalResist = 76;
            Quartzwood.m_ShieldPoisonResist = 36;
            Quartzwood.m_WeaponChaosDamage = 36;
            Quartzwood.m_WeaponColdDamage = 36;
            Quartzwood.m_WeaponEnergyDamage = 36;
            Quartzwood.m_WeaponFireDamage = 36;
            Quartzwood.m_WeaponPoisonDamage = 36;
            Quartzwood.m_WeaponDirectDamage = 36;
            Quartzwood.m_WeaponDamage = 36;
            Quartzwood.m_WeaponDurability = 144;
            Quartzwood.m_WeaponGoldIncrease = 144;
            Quartzwood.m_WeaponHitChance = 3;
            Quartzwood.m_WeaponHitLifeLeech = 15;
            Quartzwood.m_WeaponLowerRequirements = 0;
            Quartzwood.m_WeaponLuck = 299;
            Quartzwood.m_WeaponSwingSpeed = 0;
            Quartzwood.m_ArmorRegenHits = 0;
            Quartzwood.m_WeaponRegenHits = 0;
            Quartzwood.AttackChance = 9;
            Quartzwood.BonusDex = 4;
            Quartzwood.BonusHits = 3;
            Quartzwood.BonusInt = 4;
            Quartzwood.BonusMana = 4;
            Quartzwood.BonusStam = 4;
            Quartzwood.BonusStr = 4;
            Quartzwood.CastRecovery = 1;
            Quartzwood.CastSpeed = 0;
            Quartzwood.Cold = 9;
            Quartzwood.DefendChance = 9;
            Quartzwood.DurabilityBonus = 60;
            Quartzwood.Energy = 9;
            Quartzwood.EnhancePotions = 15;
            Quartzwood.Fire = 9;
            Quartzwood.HitColdArea = 30;
            Quartzwood.HitDispel = 30;
            Quartzwood.HitEnergyArea = 30;
            Quartzwood.HitFireArea = 30;
            Quartzwood.HitFireball = 30;
            Quartzwood.HitHarm = 30;
            Quartzwood.HitLeechHits = 30;
            Quartzwood.HitLeechMana = 30;
            Quartzwood.HitLeechStam = 30;
            Quartzwood.HitLightning = 30;
            Quartzwood.HitLowerAttack = 30;
            Quartzwood.HitLowerDefend = 30;
            Quartzwood.HitMagicArrow = 30;
            Quartzwood.HitPhysicalArea = 30;
            Quartzwood.HitPoisonArea = 30;
            Quartzwood.LowerManaCost = 4;
            Quartzwood.LowerRegCost = 12;
            Quartzwood.LowerStatReq = 0;
            Quartzwood.LowerStatReq = 0;
            Quartzwood.Luck = 0;
            Quartzwood.MageArmor = 0;
            Quartzwood.MageWeapon = 6;
            Quartzwood.NightSight = 0;
            Quartzwood.Physical = 9;
            Quartzwood.Poison = 9;
            Quartzwood.ReflectPhysical = 9;
            Quartzwood.RegenHits = 1;
            Quartzwood.RegenMana = 1;
            Quartzwood.RegenStam = 1;
            Quartzwood.ResistColdBonus = 9;
            Quartzwood.ResistEnergyBonus = 9;
            Quartzwood.ResistFireBonus = 9;
            Quartzwood.ResistPhysicalBonus = 9;
            Quartzwood.ResistPoisonBonus = 9;
            Quartzwood.SelfRepair = 3;
            Quartzwood.SpellChanneling = 0;
            Quartzwood.SpellDamage = 7;
            Quartzwood.UseBestSkill = 0;
            Quartzwood.WeaponDamage = 15;
            Quartzwood.WeaponSpeed = 0;

            CraftAttributeInfo Rhodonitewood = Rhodonitewood = new CraftAttributeInfo();

            Rhodonitewood.m_ArmorColdResist = 39;
            Rhodonitewood.m_ArmorEnergyResist = 39;
            Rhodonitewood.m_ArmorFireResist = 39;
            Rhodonitewood.m_ArmorPhysicalResist = 74;
            Rhodonitewood.m_ArmorPoisonResist = 39;
            Rhodonitewood.m_ArmorDamage = 39;
            Rhodonitewood.m_ArmorDurability = 156;
            Rhodonitewood.m_ArmorGoldIncrease = 156;
            Rhodonitewood.m_ArmorHitChance = 16;
            Rhodonitewood.m_ArmorLowerRequirements = 0;
            Rhodonitewood.m_ArmorMage = 0;
            Rhodonitewood.m_ArmorLuck = 16;
            Rhodonitewood.m_RunicMinAttributes = 19;
            Rhodonitewood.m_RunicMaxAttributes = 20;
            Rhodonitewood.m_RunicMinIntensity = 64;
            Rhodonitewood.m_RunicMaxIntensity = 67;
            Rhodonitewood.m_ShieldColdResist = 39;
            Rhodonitewood.m_ShieldEnergyResist = 39;
            Rhodonitewood.m_ShieldFireResist = 39;
            Rhodonitewood.m_ShieldPhysicalResist = 74;
            Rhodonitewood.m_ShieldPoisonResist = 39;
            Rhodonitewood.m_WeaponChaosDamage = 39;
            Rhodonitewood.m_WeaponColdDamage = 39;
            Rhodonitewood.m_WeaponEnergyDamage = 39;
            Rhodonitewood.m_WeaponFireDamage = 39;
            Rhodonitewood.m_WeaponPoisonDamage = 39;
            Rhodonitewood.m_WeaponDirectDamage = 39;
            Rhodonitewood.m_WeaponDamage = 39;
            Rhodonitewood.m_WeaponDurability = 156;
            Rhodonitewood.m_WeaponGoldIncrease = 156;
            Rhodonitewood.m_WeaponHitChance = 3;
            Rhodonitewood.m_WeaponHitLifeLeech = 16;
            Rhodonitewood.m_WeaponLowerRequirements = 0;
            Rhodonitewood.m_WeaponLuck = 324;
            Rhodonitewood.m_WeaponSwingSpeed = 0;
            Rhodonitewood.m_ArmorRegenHits = 0;
            Rhodonitewood.m_WeaponRegenHits = 0;
            Rhodonitewood.AttackChance = 9;
            Rhodonitewood.BonusDex = 5;
            Rhodonitewood.BonusHits = 3;
            Rhodonitewood.BonusInt = 5;
            Rhodonitewood.BonusMana = 5;
            Rhodonitewood.BonusStam = 5;
            Rhodonitewood.BonusStr = 5;
            Rhodonitewood.CastRecovery = 1;
            Rhodonitewood.CastSpeed = 0;
            Rhodonitewood.Cold = 9;
            Rhodonitewood.DefendChance = 9;
            Rhodonitewood.DurabilityBonus = 65;
            Rhodonitewood.Energy = 9;
            Rhodonitewood.EnhancePotions = 16;
            Rhodonitewood.Fire = 9;
            Rhodonitewood.HitColdArea = 32;
            Rhodonitewood.HitDispel = 32;
            Rhodonitewood.HitEnergyArea = 32;
            Rhodonitewood.HitFireArea = 32;
            Rhodonitewood.HitFireball = 32;
            Rhodonitewood.HitHarm = 32;
            Rhodonitewood.HitLeechHits = 32;
            Rhodonitewood.HitLeechMana = 32;
            Rhodonitewood.HitLeechStam = 32;
            Rhodonitewood.HitLightning = 32;
            Rhodonitewood.HitLowerAttack = 32;
            Rhodonitewood.HitLowerDefend = 32;
            Rhodonitewood.HitMagicArrow = 32;
            Rhodonitewood.HitPhysicalArea = 32;
            Rhodonitewood.HitPoisonArea = 32;
            Rhodonitewood.LowerManaCost = 5;
            Rhodonitewood.LowerRegCost = 13;
            Rhodonitewood.LowerStatReq = 0;
            Rhodonitewood.LowerStatReq = 0;
            Rhodonitewood.Luck = 0;
            Rhodonitewood.MageArmor = 0;
            Rhodonitewood.MageWeapon = 6;
            Rhodonitewood.NightSight = 0;
            Rhodonitewood.Physical = 9;
            Rhodonitewood.Poison = 9;
            Rhodonitewood.ReflectPhysical = 9;
            Rhodonitewood.RegenHits = 1;
            Rhodonitewood.RegenMana = 1;
            Rhodonitewood.RegenStam = 1;
            Rhodonitewood.ResistColdBonus = 9;
            Rhodonitewood.ResistEnergyBonus = 9;
            Rhodonitewood.ResistFireBonus = 9;
            Rhodonitewood.ResistPhysicalBonus = 9;
            Rhodonitewood.ResistPoisonBonus = 9;
            Rhodonitewood.SelfRepair = 3;
            Rhodonitewood.SpellChanneling = 0;
            Rhodonitewood.SpellDamage = 7;
            Rhodonitewood.UseBestSkill = 0;
            Rhodonitewood.WeaponDamage = 16;
            Rhodonitewood.WeaponSpeed = 0;

            CraftAttributeInfo Rubywood = Rubywood = new CraftAttributeInfo();

            Rubywood.m_ArmorColdResist = 42;
            Rubywood.m_ArmorEnergyResist = 42;
            Rubywood.m_ArmorFireResist = 42;
            Rubywood.m_ArmorPhysicalResist = 72;
            Rubywood.m_ArmorPoisonResist = 42;
            Rubywood.m_ArmorDamage = 42;
            Rubywood.m_ArmorDurability = 168;
            Rubywood.m_ArmorGoldIncrease = 168;
            Rubywood.m_ArmorHitChance = 17;
            Rubywood.m_ArmorLowerRequirements = 0;
            Rubywood.m_ArmorMage = 0;
            Rubywood.m_ArmorLuck = 17;
            Rubywood.m_RunicMinAttributes = 21;
            Rubywood.m_RunicMaxAttributes = 21;
            Rubywood.m_RunicMinIntensity = 70;
            Rubywood.m_RunicMaxIntensity = 70;
            Rubywood.m_ShieldColdResist = 42;
            Rubywood.m_ShieldEnergyResist = 42;
            Rubywood.m_ShieldFireResist = 42;
            Rubywood.m_ShieldPhysicalResist = 72;
            Rubywood.m_ShieldPoisonResist = 42;
            Rubywood.m_WeaponChaosDamage = 42;
            Rubywood.m_WeaponColdDamage = 42;
            Rubywood.m_WeaponEnergyDamage = 42;
            Rubywood.m_WeaponFireDamage = 42;
            Rubywood.m_WeaponPoisonDamage = 42;
            Rubywood.m_WeaponDirectDamage = 42;
            Rubywood.m_WeaponDamage = 42;
            Rubywood.m_WeaponDurability = 168;
            Rubywood.m_WeaponGoldIncrease = 168;
            Rubywood.m_WeaponHitChance = 4;
            Rubywood.m_WeaponHitLifeLeech = 17;
            Rubywood.m_WeaponLowerRequirements = 0;
            Rubywood.m_WeaponLuck = 348;
            Rubywood.m_WeaponSwingSpeed = 0;
            Rubywood.m_ArmorRegenHits = 0;
            Rubywood.m_WeaponRegenHits = 0;
            Rubywood.AttackChance = 10;
            Rubywood.BonusDex = 5;
            Rubywood.BonusHits = 3;
            Rubywood.BonusInt = 5;
            Rubywood.BonusMana = 5;
            Rubywood.BonusStam = 5;
            Rubywood.BonusStr = 5;
            Rubywood.CastRecovery = 2;
            Rubywood.CastSpeed = 0;
            Rubywood.Cold = 10;
            Rubywood.DefendChance = 10;
            Rubywood.DurabilityBonus = 70;
            Rubywood.Energy = 10;
            Rubywood.EnhancePotions = 17;
            Rubywood.Fire = 10;
            Rubywood.HitColdArea = 35;
            Rubywood.HitDispel = 35;
            Rubywood.HitEnergyArea = 35;
            Rubywood.HitFireArea = 35;
            Rubywood.HitFireball = 35;
            Rubywood.HitHarm = 35;
            Rubywood.HitLeechHits = 35;
            Rubywood.HitLeechMana = 35;
            Rubywood.HitLeechStam = 35;
            Rubywood.HitLightning = 35;
            Rubywood.HitLowerAttack = 35;
            Rubywood.HitLowerDefend = 35;
            Rubywood.HitMagicArrow = 35;
            Rubywood.HitPhysicalArea = 35;
            Rubywood.HitPoisonArea = 35;
            Rubywood.LowerManaCost = 5;
            Rubywood.LowerRegCost = 14;
            Rubywood.LowerStatReq = 0;
            Rubywood.LowerStatReq = 0;
            Rubywood.Luck = 0;
            Rubywood.MageArmor = 0;
            Rubywood.MageWeapon = 7;
            Rubywood.NightSight = 0;
            Rubywood.Physical = 10;
            Rubywood.Poison = 10;
            Rubywood.ReflectPhysical = 10;
            Rubywood.RegenHits = 1;
            Rubywood.RegenMana = 1;
            Rubywood.RegenStam = 2;
            Rubywood.ResistColdBonus = 10;
            Rubywood.ResistEnergyBonus = 10;
            Rubywood.ResistFireBonus = 10;
            Rubywood.ResistPhysicalBonus = 10;
            Rubywood.ResistPoisonBonus = 10;
            Rubywood.SelfRepair = 3;
            Rubywood.SpellChanneling = 0;
            Rubywood.SpellDamage = 8;
            Rubywood.UseBestSkill = 0;
            Rubywood.WeaponDamage = 17;
            Rubywood.WeaponSpeed = 0;

            CraftAttributeInfo Sapphirewood = Sapphirewood = new CraftAttributeInfo();

            Sapphirewood.m_ArmorColdResist = 45;
            Sapphirewood.m_ArmorEnergyResist = 45;
            Sapphirewood.m_ArmorFireResist = 45;
            Sapphirewood.m_ArmorPhysicalResist = 70;
            Sapphirewood.m_ArmorPoisonResist = 45;
            Sapphirewood.m_ArmorDamage = 45;
            Sapphirewood.m_ArmorDurability = 180;
            Sapphirewood.m_ArmorGoldIncrease = 180;
            Sapphirewood.m_ArmorHitChance = 18;
            Sapphirewood.m_ArmorLowerRequirements = 0;
            Sapphirewood.m_ArmorMage = 0;
            Sapphirewood.m_ArmorLuck = 18;
            Sapphirewood.m_RunicMinAttributes = 22;
            Sapphirewood.m_RunicMaxAttributes = 23;
            Sapphirewood.m_RunicMinIntensity = 74;
            Sapphirewood.m_RunicMaxIntensity = 77;
            Sapphirewood.m_ShieldColdResist = 45;
            Sapphirewood.m_ShieldEnergyResist = 45;
            Sapphirewood.m_ShieldFireResist = 45;
            Sapphirewood.m_ShieldPhysicalResist = 70;
            Sapphirewood.m_ShieldPoisonResist = 45;
            Sapphirewood.m_WeaponChaosDamage = 45;
            Sapphirewood.m_WeaponColdDamage = 45;
            Sapphirewood.m_WeaponEnergyDamage = 45;
            Sapphirewood.m_WeaponFireDamage = 45;
            Sapphirewood.m_WeaponPoisonDamage = 45;
            Sapphirewood.m_WeaponDirectDamage = 45;
            Sapphirewood.m_WeaponDamage = 45;
            Sapphirewood.m_WeaponDurability = 180;
            Sapphirewood.m_WeaponGoldIncrease = 180;
            Sapphirewood.m_WeaponHitChance = 4;
            Sapphirewood.m_WeaponHitLifeLeech = 18;
            Sapphirewood.m_WeaponLowerRequirements = 0;
            Sapphirewood.m_WeaponLuck = 373;
            Sapphirewood.m_WeaponSwingSpeed = 0;
            Sapphirewood.m_ArmorRegenHits = 0;
            Sapphirewood.m_WeaponRegenHits = 0;
            Sapphirewood.AttackChance = 11;
            Sapphirewood.BonusDex = 6;
            Sapphirewood.BonusHits = 3;
            Sapphirewood.BonusInt = 6;
            Sapphirewood.BonusMana = 6;
            Sapphirewood.BonusStam = 6;
            Sapphirewood.BonusStr = 6;
            Sapphirewood.CastRecovery = 2;
            Sapphirewood.CastSpeed = 0;
            Sapphirewood.Cold = 11;
            Sapphirewood.DefendChance = 11;
            Sapphirewood.DurabilityBonus = 75;
            Sapphirewood.Energy = 11;
            Sapphirewood.EnhancePotions = 18;
            Sapphirewood.Fire = 11;
            Sapphirewood.HitColdArea = 37;
            Sapphirewood.HitDispel = 37;
            Sapphirewood.HitEnergyArea = 37;
            Sapphirewood.HitFireArea = 37;
            Sapphirewood.HitFireball = 37;
            Sapphirewood.HitHarm = 37;
            Sapphirewood.HitLeechHits = 37;
            Sapphirewood.HitLeechMana = 37;
            Sapphirewood.HitLeechStam = 37;
            Sapphirewood.HitLightning = 37;
            Sapphirewood.HitLowerAttack = 37;
            Sapphirewood.HitLowerDefend = 37;
            Sapphirewood.HitMagicArrow = 37;
            Sapphirewood.HitPhysicalArea = 37;
            Sapphirewood.HitPoisonArea = 37;
            Sapphirewood.LowerManaCost = 6;
            Sapphirewood.LowerRegCost = 15;
            Sapphirewood.LowerStatReq = 0;
            Sapphirewood.LowerStatReq = 0;
            Sapphirewood.Luck = 0;
            Sapphirewood.MageArmor = 0;
            Sapphirewood.MageWeapon = 7;
            Sapphirewood.NightSight = 0;
            Sapphirewood.Physical = 11;
            Sapphirewood.Poison = 11;
            Sapphirewood.ReflectPhysical = 11;
            Sapphirewood.RegenHits = 1;
            Sapphirewood.RegenMana = 1;
            Sapphirewood.RegenStam = 2;
            Sapphirewood.ResistColdBonus = 11;
            Sapphirewood.ResistEnergyBonus = 11;
            Sapphirewood.ResistFireBonus = 11;
            Sapphirewood.ResistPhysicalBonus = 11;
            Sapphirewood.ResistPoisonBonus = 11;
            Sapphirewood.SelfRepair = 3;
            Sapphirewood.SpellChanneling = 0;
            Sapphirewood.SpellDamage = 9;
            Sapphirewood.UseBestSkill = 0;
            Sapphirewood.WeaponDamage = 18;
            Sapphirewood.WeaponSpeed = 0;

            CraftAttributeInfo Sugilitewood = Sugilitewood = new CraftAttributeInfo();

            Sugilitewood.m_ArmorColdResist = 48;
            Sugilitewood.m_ArmorEnergyResist = 48;
            Sugilitewood.m_ArmorFireResist = 48;
            Sugilitewood.m_ArmorPhysicalResist = 68;
            Sugilitewood.m_ArmorPoisonResist = 48;
            Sugilitewood.m_ArmorDamage = 48;
            Sugilitewood.m_ArmorDurability = 192;
            Sugilitewood.m_ArmorGoldIncrease = 192;
            Sugilitewood.m_ArmorHitChance = 20;
            Sugilitewood.m_ArmorLowerRequirements = 0;
            Sugilitewood.m_ArmorMage = 0;
            Sugilitewood.m_ArmorLuck = 20;
            Sugilitewood.m_RunicMinAttributes = 24;
            Sugilitewood.m_RunicMaxAttributes = 24;
            Sugilitewood.m_RunicMinIntensity = 80;
            Sugilitewood.m_RunicMaxIntensity = 80;
            Sugilitewood.m_ShieldColdResist = 48;
            Sugilitewood.m_ShieldEnergyResist = 48;
            Sugilitewood.m_ShieldFireResist = 48;
            Sugilitewood.m_ShieldPhysicalResist = 68;
            Sugilitewood.m_ShieldPoisonResist = 48;
            Sugilitewood.m_WeaponChaosDamage = 48;
            Sugilitewood.m_WeaponColdDamage = 48;
            Sugilitewood.m_WeaponEnergyDamage = 48;
            Sugilitewood.m_WeaponFireDamage = 48;
            Sugilitewood.m_WeaponPoisonDamage = 48;
            Sugilitewood.m_WeaponDirectDamage = 48;
            Sugilitewood.m_WeaponDamage = 48;
            Sugilitewood.m_WeaponDurability = 192;
            Sugilitewood.m_WeaponGoldIncrease = 192;
            Sugilitewood.m_WeaponHitChance = 4;
            Sugilitewood.m_WeaponHitLifeLeech = 20;
            Sugilitewood.m_WeaponLowerRequirements = 0;
            Sugilitewood.m_WeaponLuck = 398;
            Sugilitewood.m_WeaponSwingSpeed = 0;
            Sugilitewood.m_ArmorRegenHits = 0;
            Sugilitewood.m_WeaponRegenHits = 0;
            Sugilitewood.AttackChance = 12;
            Sugilitewood.BonusDex = 6;
            Sugilitewood.BonusHits = 4;
            Sugilitewood.BonusInt = 6;
            Sugilitewood.BonusMana = 6;
            Sugilitewood.BonusStam = 6;
            Sugilitewood.BonusStr = 6;
            Sugilitewood.CastRecovery = 2;
            Sugilitewood.CastSpeed = 0;
            Sugilitewood.Cold = 12;
            Sugilitewood.DefendChance = 12;
            Sugilitewood.DurabilityBonus = 80;
            Sugilitewood.Energy = 12;
            Sugilitewood.EnhancePotions = 20;
            Sugilitewood.Fire = 12;
            Sugilitewood.HitColdArea = 40;
            Sugilitewood.HitDispel = 40;
            Sugilitewood.HitEnergyArea = 40;
            Sugilitewood.HitFireArea = 40;
            Sugilitewood.HitFireball = 40;
            Sugilitewood.HitHarm = 40;
            Sugilitewood.HitLeechHits = 40;
            Sugilitewood.HitLeechMana = 40;
            Sugilitewood.HitLeechStam = 40;
            Sugilitewood.HitLightning = 40;
            Sugilitewood.HitLowerAttack = 40;
            Sugilitewood.HitLowerDefend = 40;
            Sugilitewood.HitMagicArrow = 40;
            Sugilitewood.HitPhysicalArea = 40;
            Sugilitewood.HitPoisonArea = 40;
            Sugilitewood.LowerManaCost = 6;
            Sugilitewood.LowerRegCost = 16;
            Sugilitewood.LowerStatReq = 0;
            Sugilitewood.LowerStatReq = 0;
            Sugilitewood.Luck = 0;
            Sugilitewood.MageArmor = 0;
            Sugilitewood.MageWeapon = 8;
            Sugilitewood.NightSight = 0;
            Sugilitewood.Physical = 12;
            Sugilitewood.Poison = 12;
            Sugilitewood.ReflectPhysical = 12;
            Sugilitewood.RegenHits = 1;
            Sugilitewood.RegenMana = 1;
            Sugilitewood.RegenStam = 2;
            Sugilitewood.ResistColdBonus = 12;
            Sugilitewood.ResistEnergyBonus = 12;
            Sugilitewood.ResistFireBonus = 12;
            Sugilitewood.ResistPhysicalBonus = 12;
            Sugilitewood.ResistPoisonBonus = 12;
            Sugilitewood.SelfRepair = 4;
            Sugilitewood.SpellChanneling = 0;
            Sugilitewood.SpellDamage = 9;
            Sugilitewood.UseBestSkill = 0;
            Sugilitewood.WeaponDamage = 20;
            Sugilitewood.WeaponSpeed = 0;

            CraftAttributeInfo Tanzanitewood = Tanzanitewood = new CraftAttributeInfo();

            Tanzanitewood.m_ArmorColdResist = 51;
            Tanzanitewood.m_ArmorEnergyResist = 51;
            Tanzanitewood.m_ArmorFireResist = 51;
            Tanzanitewood.m_ArmorPhysicalResist = 66;
            Tanzanitewood.m_ArmorPoisonResist = 51;
            Tanzanitewood.m_ArmorDamage = 51;
            Tanzanitewood.m_ArmorDurability = 204;
            Tanzanitewood.m_ArmorGoldIncrease = 204;
            Tanzanitewood.m_ArmorHitChance = 21;
            Tanzanitewood.m_ArmorLowerRequirements = 0;
            Tanzanitewood.m_ArmorMage = 0;
            Tanzanitewood.m_ArmorLuck = 21;
            Tanzanitewood.m_RunicMinAttributes = 25;
            Tanzanitewood.m_RunicMaxAttributes = 26;
            Tanzanitewood.m_RunicMinIntensity = 84;
            Tanzanitewood.m_RunicMaxIntensity = 87;
            Tanzanitewood.m_ShieldColdResist = 51;
            Tanzanitewood.m_ShieldEnergyResist = 51;
            Tanzanitewood.m_ShieldFireResist = 51;
            Tanzanitewood.m_ShieldPhysicalResist = 66;
            Tanzanitewood.m_ShieldPoisonResist = 51;
            Tanzanitewood.m_WeaponChaosDamage = 51;
            Tanzanitewood.m_WeaponColdDamage = 51;
            Tanzanitewood.m_WeaponEnergyDamage = 51;
            Tanzanitewood.m_WeaponFireDamage = 51;
            Tanzanitewood.m_WeaponPoisonDamage = 51;
            Tanzanitewood.m_WeaponDirectDamage = 51;
            Tanzanitewood.m_WeaponDamage = 51;
            Tanzanitewood.m_WeaponDurability = 204;
            Tanzanitewood.m_WeaponGoldIncrease = 204;
            Tanzanitewood.m_WeaponHitChance = 5;
            Tanzanitewood.m_WeaponHitLifeLeech = 21;
            Tanzanitewood.m_WeaponLowerRequirements = 0;
            Tanzanitewood.m_WeaponLuck = 423;
            Tanzanitewood.m_WeaponSwingSpeed = 0;
            Tanzanitewood.m_ArmorRegenHits = 0;
            Tanzanitewood.m_WeaponRegenHits = 0;
            Tanzanitewood.AttackChance = 12;
            Tanzanitewood.BonusDex = 6;
            Tanzanitewood.BonusHits = 4;
            Tanzanitewood.BonusInt = 6;
            Tanzanitewood.BonusMana = 6;
            Tanzanitewood.BonusStam = 6;
            Tanzanitewood.BonusStr = 6;
            Tanzanitewood.CastRecovery = 2;
            Tanzanitewood.CastSpeed = 0;
            Tanzanitewood.Cold = 12;
            Tanzanitewood.DefendChance = 12;
            Tanzanitewood.DurabilityBonus = 85;
            Tanzanitewood.Energy = 12;
            Tanzanitewood.EnhancePotions = 21;
            Tanzanitewood.Fire = 12;
            Tanzanitewood.HitColdArea = 42;
            Tanzanitewood.HitDispel = 42;
            Tanzanitewood.HitEnergyArea = 42;
            Tanzanitewood.HitFireArea = 42;
            Tanzanitewood.HitFireball = 42;
            Tanzanitewood.HitHarm = 42;
            Tanzanitewood.HitLeechHits = 42;
            Tanzanitewood.HitLeechMana = 42;
            Tanzanitewood.HitLeechStam = 42;
            Tanzanitewood.HitLightning = 42;
            Tanzanitewood.HitLowerAttack = 42;
            Tanzanitewood.HitLowerDefend = 42;
            Tanzanitewood.HitMagicArrow = 42;
            Tanzanitewood.HitPhysicalArea = 42;
            Tanzanitewood.HitPoisonArea = 42;
            Tanzanitewood.LowerManaCost = 6;
            Tanzanitewood.LowerRegCost = 17;
            Tanzanitewood.LowerStatReq = 0;
            Tanzanitewood.LowerStatReq = 0;
            Tanzanitewood.Luck = 0;
            Tanzanitewood.MageArmor = 0;
            Tanzanitewood.MageWeapon = 8;
            Tanzanitewood.NightSight = 0;
            Tanzanitewood.Physical = 12;
            Tanzanitewood.Poison = 12;
            Tanzanitewood.ReflectPhysical = 12;
            Tanzanitewood.RegenHits = 1;
            Tanzanitewood.RegenMana = 1;
            Tanzanitewood.RegenStam = 2;
            Tanzanitewood.ResistColdBonus = 12;
            Tanzanitewood.ResistEnergyBonus = 12;
            Tanzanitewood.ResistFireBonus = 12;
            Tanzanitewood.ResistPhysicalBonus = 12;
            Tanzanitewood.ResistPoisonBonus = 12;
            Tanzanitewood.SelfRepair = 4;
            Tanzanitewood.SpellChanneling = 0;
            Tanzanitewood.SpellDamage = 10;
            Tanzanitewood.UseBestSkill = 0;
            Tanzanitewood.WeaponDamage = 21;
            Tanzanitewood.WeaponSpeed = 0;

            CraftAttributeInfo Turquoisewood = Turquoisewood = new CraftAttributeInfo();

            Turquoisewood.m_ArmorColdResist = 54;
            Turquoisewood.m_ArmorEnergyResist = 54;
            Turquoisewood.m_ArmorFireResist = 54;
            Turquoisewood.m_ArmorPhysicalResist = 64;
            Turquoisewood.m_ArmorPoisonResist = 54;
            Turquoisewood.m_ArmorDamage = 54;
            Turquoisewood.m_ArmorDurability = 216;
            Turquoisewood.m_ArmorGoldIncrease = 216;
            Turquoisewood.m_ArmorHitChance = 22;
            Turquoisewood.m_ArmorLowerRequirements = 0;
            Turquoisewood.m_ArmorMage = 0;
            Turquoisewood.m_ArmorLuck = 22;
            Turquoisewood.m_RunicMinAttributes = 27;
            Turquoisewood.m_RunicMaxAttributes = 27;
            Turquoisewood.m_RunicMinIntensity = 90;
            Turquoisewood.m_RunicMaxIntensity = 90;
            Turquoisewood.m_ShieldColdResist = 54;
            Turquoisewood.m_ShieldEnergyResist = 54;
            Turquoisewood.m_ShieldFireResist = 54;
            Turquoisewood.m_ShieldPhysicalResist = 64;
            Turquoisewood.m_ShieldPoisonResist = 54;
            Turquoisewood.m_WeaponChaosDamage = 54;
            Turquoisewood.m_WeaponColdDamage = 54;
            Turquoisewood.m_WeaponEnergyDamage = 54;
            Turquoisewood.m_WeaponFireDamage = 54;
            Turquoisewood.m_WeaponPoisonDamage = 54;
            Turquoisewood.m_WeaponDirectDamage = 54;
            Turquoisewood.m_WeaponDamage = 54;
            Turquoisewood.m_WeaponDurability = 216;
            Turquoisewood.m_WeaponGoldIncrease = 216;
            Turquoisewood.m_WeaponHitChance = 5;
            Turquoisewood.m_WeaponHitLifeLeech = 22;
            Turquoisewood.m_WeaponLowerRequirements = 0;
            Turquoisewood.m_WeaponLuck = 448;
            Turquoisewood.m_WeaponSwingSpeed = 0;
            Turquoisewood.m_ArmorRegenHits = 0;
            Turquoisewood.m_WeaponRegenHits = 0;
            Turquoisewood.AttackChance = 13;
            Turquoisewood.BonusDex = 7;
            Turquoisewood.BonusHits = 4;
            Turquoisewood.BonusInt = 7;
            Turquoisewood.BonusMana = 7;
            Turquoisewood.BonusStam = 7;
            Turquoisewood.BonusStr = 7;
            Turquoisewood.CastRecovery = 2;
            Turquoisewood.CastSpeed = 0;
            Turquoisewood.Cold = 13;
            Turquoisewood.DefendChance = 13;
            Turquoisewood.DurabilityBonus = 90;
            Turquoisewood.Energy = 13;
            Turquoisewood.EnhancePotions = 22;
            Turquoisewood.Fire = 13;
            Turquoisewood.HitColdArea = 45;
            Turquoisewood.HitDispel = 45;
            Turquoisewood.HitEnergyArea = 45;
            Turquoisewood.HitFireArea = 45;
            Turquoisewood.HitFireball = 45;
            Turquoisewood.HitHarm = 45;
            Turquoisewood.HitLeechHits = 45;
            Turquoisewood.HitLeechMana = 45;
            Turquoisewood.HitLeechStam = 45;
            Turquoisewood.HitLightning = 45;
            Turquoisewood.HitLowerAttack = 45;
            Turquoisewood.HitLowerDefend = 45;
            Turquoisewood.HitMagicArrow = 45;
            Turquoisewood.HitPhysicalArea = 45;
            Turquoisewood.HitPoisonArea = 45;
            Turquoisewood.LowerManaCost = 7;
            Turquoisewood.LowerRegCost = 18;
            Turquoisewood.LowerStatReq = 0;
            Turquoisewood.LowerStatReq = 0;
            Turquoisewood.Luck = 0;
            Turquoisewood.MageArmor = 0;
            Turquoisewood.MageWeapon = 9;
            Turquoisewood.NightSight = 0;
            Turquoisewood.Physical = 13;
            Turquoisewood.Poison = 13;
            Turquoisewood.ReflectPhysical = 13;
            Turquoisewood.RegenHits = 1;
            Turquoisewood.RegenMana = 1;
            Turquoisewood.RegenStam = 2;
            Turquoisewood.ResistColdBonus = 13;
            Turquoisewood.ResistEnergyBonus = 13;
            Turquoisewood.ResistFireBonus = 13;
            Turquoisewood.ResistPhysicalBonus = 13;
            Turquoisewood.ResistPoisonBonus = 13;
            Turquoisewood.SelfRepair = 4;
            Turquoisewood.SpellChanneling = 0;
            Turquoisewood.SpellDamage = 10;
            Turquoisewood.UseBestSkill = 0;
            Turquoisewood.WeaponDamage = 22;
            Turquoisewood.WeaponSpeed = 0;

            CraftAttributeInfo Varisitewood = Varisitewood = new CraftAttributeInfo();

            Varisitewood.m_ArmorColdResist = 57;
            Varisitewood.m_ArmorEnergyResist = 57;
            Varisitewood.m_ArmorFireResist = 57;
            Varisitewood.m_ArmorPhysicalResist = 62;
            Varisitewood.m_ArmorPoisonResist = 57;
            Varisitewood.m_ArmorDamage = 57;
            Varisitewood.m_ArmorDurability = 228;
            Varisitewood.m_ArmorGoldIncrease = 228;
            Varisitewood.m_ArmorHitChance = 23;
            Varisitewood.m_ArmorLowerRequirements = 0;
            Varisitewood.m_ArmorMage = 0;
            Varisitewood.m_ArmorLuck = 23;
            Varisitewood.m_RunicMinAttributes = 28;
            Varisitewood.m_RunicMaxAttributes = 29;
            Varisitewood.m_RunicMinIntensity = 93;
            Varisitewood.m_RunicMaxIntensity = 97;
            Varisitewood.m_ShieldColdResist = 57;
            Varisitewood.m_ShieldEnergyResist = 57;
            Varisitewood.m_ShieldFireResist = 57;
            Varisitewood.m_ShieldPhysicalResist = 62;
            Varisitewood.m_ShieldPoisonResist = 57;
            Varisitewood.m_WeaponChaosDamage = 57;
            Varisitewood.m_WeaponColdDamage = 57;
            Varisitewood.m_WeaponEnergyDamage = 57;
            Varisitewood.m_WeaponFireDamage = 57;
            Varisitewood.m_WeaponPoisonDamage = 57;
            Varisitewood.m_WeaponDirectDamage = 57;
            Varisitewood.m_WeaponDamage = 57;
            Varisitewood.m_WeaponDurability = 228;
            Varisitewood.m_WeaponGoldIncrease = 228;
            Varisitewood.m_WeaponHitChance = 5;
            Varisitewood.m_WeaponHitLifeLeech = 23;
            Varisitewood.m_WeaponLowerRequirements = 0;
            Varisitewood.m_WeaponLuck = 473;
            Varisitewood.m_WeaponSwingSpeed = 0;
            Varisitewood.m_ArmorRegenHits = 0;
            Varisitewood.m_WeaponRegenHits = 0;
            Varisitewood.AttackChance = 14;
            Varisitewood.BonusDex = 7;
            Varisitewood.BonusHits = 4;
            Varisitewood.BonusInt = 7;
            Varisitewood.BonusMana = 7;
            Varisitewood.BonusStam = 7;
            Varisitewood.BonusStr = 7;
            Varisitewood.CastRecovery = 2;
            Varisitewood.CastSpeed = 0;
            Varisitewood.Cold = 14;
            Varisitewood.DefendChance = 14;
            Varisitewood.DurabilityBonus = 95;
            Varisitewood.Energy = 14;
            Varisitewood.EnhancePotions = 23;
            Varisitewood.Fire = 14;
            Varisitewood.HitColdArea = 47;
            Varisitewood.HitDispel = 47;
            Varisitewood.HitEnergyArea = 47;
            Varisitewood.HitFireArea = 47;
            Varisitewood.HitFireball = 47;
            Varisitewood.HitHarm = 47;
            Varisitewood.HitLeechHits = 47;
            Varisitewood.HitLeechMana = 47;
            Varisitewood.HitLeechStam = 47;
            Varisitewood.HitLightning = 47;
            Varisitewood.HitLowerAttack = 47;
            Varisitewood.HitLowerDefend = 47;
            Varisitewood.HitMagicArrow = 47;
            Varisitewood.HitPhysicalArea = 47;
            Varisitewood.HitPoisonArea = 47;
            Varisitewood.LowerManaCost = 7;
            Varisitewood.LowerRegCost = 19;
            Varisitewood.LowerStatReq = 0;
            Varisitewood.LowerStatReq = 0;
            Varisitewood.Luck = 0;
            Varisitewood.MageArmor = 0;
            Varisitewood.MageWeapon = 9;
            Varisitewood.NightSight = 0;
            Varisitewood.Physical = 14;
            Varisitewood.Poison = 14;
            Varisitewood.ReflectPhysical = 14;
            Varisitewood.RegenHits = 1;
            Varisitewood.RegenMana = 1;
            Varisitewood.RegenStam = 2;
            Varisitewood.ResistColdBonus = 14;
            Varisitewood.ResistEnergyBonus = 14;
            Varisitewood.ResistFireBonus = 14;
            Varisitewood.ResistPhysicalBonus = 14;
            Varisitewood.ResistPoisonBonus = 14;
            Varisitewood.SelfRepair = 4;
            Varisitewood.SpellChanneling = 0;
            Varisitewood.SpellDamage = 11;
            Varisitewood.UseBestSkill = 0;
            Varisitewood.WeaponDamage = 23;
            Varisitewood.WeaponSpeed = 0;

            CraftAttributeInfo Guardianswood = Guardianswood = new CraftAttributeInfo();

            Guardianswood.m_ArmorColdResist = 60;
            Guardianswood.m_ArmorEnergyResist = 60;
            Guardianswood.m_ArmorFireResist = 60;
            Guardianswood.m_ArmorPhysicalResist = 60;
            Guardianswood.m_ArmorPoisonResist = 60;
            Guardianswood.m_ArmorDamage = 60;
            Guardianswood.m_ArmorDurability = 240;
            Guardianswood.m_ArmorGoldIncrease = 240;
            Guardianswood.m_ArmorHitChance = 25;
            Guardianswood.m_ArmorLowerRequirements = 0;
            Guardianswood.m_ArmorMage = 0;
            Guardianswood.m_ArmorLuck = 25;
            Guardianswood.m_RunicMinAttributes = 30;
            Guardianswood.m_RunicMaxAttributes = 30;
            Guardianswood.m_RunicMinIntensity = 100;
            Guardianswood.m_RunicMaxIntensity = 100;
            Guardianswood.m_ShieldColdResist = 60;
            Guardianswood.m_ShieldEnergyResist = 60;
            Guardianswood.m_ShieldFireResist = 60;
            Guardianswood.m_ShieldPhysicalResist = 60;
            Guardianswood.m_ShieldPoisonResist = 60;
            Guardianswood.m_WeaponChaosDamage = 60;
            Guardianswood.m_WeaponColdDamage = 60;
            Guardianswood.m_WeaponEnergyDamage = 60;
            Guardianswood.m_WeaponFireDamage = 60;
            Guardianswood.m_WeaponPoisonDamage = 60;
            Guardianswood.m_WeaponDirectDamage = 60;
            Guardianswood.m_WeaponDamage = 60;
            Guardianswood.m_WeaponDurability = 240;
            Guardianswood.m_WeaponGoldIncrease = 240;
            Guardianswood.m_WeaponHitChance = 6;
            Guardianswood.m_WeaponHitLifeLeech = 25;
            Guardianswood.m_WeaponLowerRequirements = 0;
            Guardianswood.m_WeaponLuck = 498;
            Guardianswood.m_WeaponSwingSpeed = 0;
            Guardianswood.m_ArmorRegenHits = 0;
            Guardianswood.m_WeaponRegenHits = 0;
            Guardianswood.AttackChance = 15;
            Guardianswood.BonusDex = 8;
            Guardianswood.BonusHits = 5;
            Guardianswood.BonusInt = 8;
            Guardianswood.BonusMana = 8;
            Guardianswood.BonusStam = 8;
            Guardianswood.BonusStr = 8;
            Guardianswood.CastRecovery = 3;
            Guardianswood.CastSpeed = 1;
            Guardianswood.Cold = 15;
            Guardianswood.DefendChance = 15;
            Guardianswood.DurabilityBonus = 100;
            Guardianswood.Energy = 15;
            Guardianswood.EnhancePotions = 25;
            Guardianswood.Fire = 15;
            Guardianswood.HitColdArea = 50;
            Guardianswood.HitDispel = 50;
            Guardianswood.HitEnergyArea = 50;
            Guardianswood.HitFireArea = 50;
            Guardianswood.HitFireball = 50;
            Guardianswood.HitHarm = 50;
            Guardianswood.HitLeechHits = 50;
            Guardianswood.HitLeechMana = 50;
            Guardianswood.HitLeechStam = 50;
            Guardianswood.HitLightning = 50;
            Guardianswood.HitLowerAttack = 50;
            Guardianswood.HitLowerDefend = 50;
            Guardianswood.HitMagicArrow = 50;
            Guardianswood.HitPhysicalArea = 50;
            Guardianswood.HitPoisonArea = 50;
            Guardianswood.LowerManaCost = 8;
            Guardianswood.LowerRegCost = 20;
            Guardianswood.LowerStatReq = 0;
            Guardianswood.LowerStatReq = 0;
            Guardianswood.Luck = 0;
            Guardianswood.MageArmor = 1;
            Guardianswood.MageWeapon = 10;
            Guardianswood.NightSight = 0;
            Guardianswood.Physical = 15;
            Guardianswood.Poison = 15;
            Guardianswood.ReflectPhysical = 15;
            Guardianswood.RegenHits = 2;
            Guardianswood.RegenMana = 2;
            Guardianswood.RegenStam = 3;
            Guardianswood.ResistColdBonus = 15;
            Guardianswood.ResistEnergyBonus = 15;
            Guardianswood.ResistFireBonus = 15;
            Guardianswood.ResistPhysicalBonus = 15;
            Guardianswood.ResistPoisonBonus = 15;
            Guardianswood.SelfRepair = 5;
            Guardianswood.SpellChanneling = 0;
            Guardianswood.SpellDamage = 12;
            Guardianswood.UseBestSkill = 0;
            Guardianswood.WeaponDamage = 25;
            Guardianswood.WeaponSpeed = 0;
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