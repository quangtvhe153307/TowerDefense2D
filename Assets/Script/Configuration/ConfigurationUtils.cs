using Assets.Script.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ConfigurationUtils
{
    static ConfigurationData configurationData;

    //get data
    public static float BoSpeed
    {
        get { return configurationData.boSpeed; }
    }
    public static int BoHealth
    {
        get { return configurationData.boHealth; }
    }
    public static int BoScore
    {
        get { return configurationData.boScore; }
    }
    public static float GaSpeed
    {
        get { return configurationData.gaSpeed; }
    }
    public static int GaHealth
    {
        get { return configurationData.gaHealth; }
    }
    public static int GaScore
    {
        get { return configurationData.gaScore; }
    }
    public static float NamSpeed
    {
        get { return configurationData.namSpeed; }
    }
    public static int NamHealth
    {
        get { return configurationData.namHealth; }
    }
    public static int NamScore
    {
        get { return configurationData.namScore; }
    }
    public static float SLimeSpeed
    {
        get { return configurationData.slimeSpeed; }
    }
    public static int SlimeHealth
    {
        get { return configurationData.slimeHealth; }
    }
    public static int SlimeScore
    {
        get { return configurationData.slimeScore; }
    }
    public static float ThoSpeed
    {
        get { return configurationData.thoSpeed; }
    }
    public static int ThoHealth
    {
        get { return configurationData.thoHealth; }
    }
    public static int ThoScore
    {
        get { return configurationData.thoScore; }
    }
/*    public static List<Wave> Waves
    {
        get { return configurationData.Waves; }
    }*/
    public static float TimeBetweenWaves
    {
        get { return configurationData.TimeBetweenWaves; }
    }

    //------Tower LV1 ------
    public static float CooldownArcherLv1
    {
        get { return configurationData.cooldownArcherLv1; }
    }
    public static float RangeArcherLv1
    {
        get { return configurationData.rangeArcherLv1; }
    }
    public static int PriceArcherLv1
    {
        get { return configurationData.priceArcherLv1; }
    }
    public static float CooldownKnightLv1
    {
        get { return configurationData.cooldownKnightLv1; }
    }
    public static float RangeKnightLv1
    {
        get { return configurationData.rangeKnightLv1; }
    }
    public static int PriceKnightLv1
    {
        get { return configurationData.priceKnightLv1; }
    }
    public static float CooldownMagicianLv1
    {
        get { return configurationData.cooldownMagicianLv1; }
    }
    public static float RangeMagicianLv1
    {
        get { return configurationData.rangeMagicianLv1; }
    }
    public static int PriceMagicianLv1
    {
        get { return configurationData.priceMagicianLv1; }
    }
    public static int DamageArcherLv1
    {
        get { return configurationData.damageArcherLv1; }
    }
    public static int DamageKnightLv1
    {
        get { return configurationData.damageKnightLv1; }
    }
    public static int DamageMagicianLv1
    {
        get { return configurationData.damageMagicianLv1; }
    }
    //-----Tower Lv2 -----
    public static float CooldownArcherLv2
    {
        get { return configurationData.cooldownArcherLv2; }
    }
    public static float RangeArcherLv2
    {
        get { return configurationData.rangeArcherLv2; }
    }
    public static int PriceArcherLv2
    {
        get { return configurationData.priceArcherLv2; }
    }
    public static float CooldownKnightLv2
    {
        get { return configurationData.cooldownKnightLv2; }
    }
    public static float RangeKnightLv2
    {
        get { return configurationData.rangeKnightLv2; }
    }
    public static int PriceKnightLv2
    {
        get { return configurationData.priceKnightLv2; }
    }
    public static float CooldownMagicianLv2
    {
        get { return configurationData.cooldownMagicianLv2; }
    }
    public static float RangeMagicianLv2
    {
        get { return configurationData.rangeMagicianLv2; }
    }
    public static int PriceMagicianLv2
    {
        get { return configurationData.priceMagicianLv2; }
    }
    public static int DamageArcherLv2
    {
        get { return configurationData.damageArcherLv2; }
    }
    public static int DamageKnightLv2
    {
        get { return configurationData.damageKnightLv2; }
    }
    public static int DamageMagicianLv2
    {
        get { return configurationData.damageMagicianLv2; }
    }
    //-----Tower Lv3 -----
    public static float CooldownArcherLv3
    {
        get { return configurationData.cooldownArcherLv3; }
    }
    public static float RangeArcherLv3
    {
        get { return configurationData.rangeArcherLv3; }
    }
    public static int PriceArcherLv3
    {
        get { return configurationData.priceArcherLv3; }
    }
    public static float CooldownKnightLv3
    {
        get { return configurationData.cooldownKnightLv3; }
    }
    public static float RangeKnightLv3
    {
        get { return configurationData.rangeKnightLv3; }
    }
    public static int PriceKnightLv3
    {
        get { return configurationData.priceKnightLv3; }
    }
    public static float CooldownMagicianLv3
    {
        get { return configurationData.cooldownMagicianLv3; }
    }
    public static float RangeMagicianLv3
    {
        get { return configurationData.rangeMagicianLv3; }
    }
    public static int PriceMagicianLv3
    {
        get { return configurationData.priceMagicianLv3; }
    }
    public static int DamageArcherLv3
    {
        get { return configurationData.damageArcherLv3; }
    }
    public static int DamageKnightLv3
    {
        get { return configurationData.damageKnightLv3; }
    }
    public static int DamageMagicianLv3
    {
        get { return configurationData.damageMagicianLv3; }
    }
    public static float ArrowBulletSpeed
    {
        get { return configurationData.ArrowBulletSpeed; }
    }    
    public static float MagicianBulletSpeed
    {
        get { return configurationData.MagicianBulletSpeed; }
    }    
    public static float KnightBulletSpeed
    {
        get { return configurationData.KnightBulletSpeed; }
    }
    public static int DefaultScore
    {
        get { return configurationData.defaultScore; }
    }
    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
        configurationData = new ConfigurationData();
    }
}
