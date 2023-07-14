using Assets.Script.Manager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ConfigurationData
{
    const string ConfigurationDataFileName = "ConfigurationData.csv";

    //default value of bo enemy
    static float BomoveSpeed = 2f;
    static int BohealthEnemy = 100;
    static int BoscoreEnemy = 100;
    //default value of ga enemy
    static float GamoveSpeed = 2f;
    static int GahealthEnemy = 100;
    static int GascoreEnemy = 100;
    //default value of bo enemy
    static float NammoveSpeed = 2f;
    static int NamhealthEnemy = 100;
    static int NamscoreEnemy = 100;
    //default value of bo enemy
    static float SlimemoveSpeed = 2f;
    static int SlimehealthEnemy = 100;
    static int SlimescoreEnemy = 100;
    //default value of bo enemy
    static float ThomoveSpeed = 2f;
    static int ThohealthEnemy = 100;
    static int ThoscoreEnemy = 100;
    //default value of boss
    static float DragonmoveSpeed = 2f;
    static int DragonhealthEnemy = 100;
    static int DragonscoreEnemy = 100;
    //default value of tower
    //default wave enemy
    /*    static List<Wave> waves;*/
    static float timeBetweenWaves = 10f;
    //default object pooling count

    private static float arrowBulletSpeed = 1f;
    private static float knightBulletSpeed = 1f;
    private static float magicianBulletSpeed = 1f;
    //Get data

    public float boSpeed
    {
        get { return BomoveSpeed; }
    }
    public int boHealth
    {
        get { return BohealthEnemy; }
    }
    public int boScore
    {
        get { return BoscoreEnemy; }
    }

    public float gaSpeed
    {
        get { return GamoveSpeed; }
    }
    public int gaHealth
    {
        get { return GahealthEnemy; }
    }
    public int gaScore
    {
        get { return GascoreEnemy; }
    }
    public float namSpeed
    {
        get { return NammoveSpeed; }
    }
    public int namHealth
    {
        get { return NamhealthEnemy; }
    }
    public int namScore
    {
        get { return NamscoreEnemy; }
    }
    public float slimeSpeed
    {
        get { return SlimemoveSpeed; }
    }
    public int slimeHealth
    {
        get { return SlimehealthEnemy; }
    }
    public int slimeScore
    {
        get { return SlimescoreEnemy; }
    }
    public float thoSpeed
    {
        get { return ThomoveSpeed; }
    }
    public int thoHealth
    {
        get { return ThohealthEnemy; }
    }
    public int thoScore
    {
        get { return ThoscoreEnemy; }
    }
    public float dragonSpeed
    {
        get { return DragonmoveSpeed; }
    }
    public int dragonHealth
    {
        get { return DragonhealthEnemy; }
    }
    public int dragonScore
    {
        get { return DragonscoreEnemy; }
    }
    /*    public List<Wave> Waves
        {
            get { return waves; }
        }*/
    public float TimeBetweenWaves
    {
        get { return timeBetweenWaves; }
    }
    //default score
    static int DefaultScore = 500;
    public int defaultScore
    {
        get { return DefaultScore; }
    }
    //default value of archer tower
    static float CooldownArcherLv1;
    static float RangeArcherLv1;
    static int PriceAcherLv1;
    static int DamageArcherLv1;
    //default value of Knight tower
    static float CooldownKnightLv1;
    static float RangeKnightLv1;
    static int PriceKnightLv1;
    static int DamageKnightLv1;
    //default value of Magician tower
    static float CooldownMagicianLv1;
    static float RangeMagicianLv1;
    static int PriceMagicianLv1;
    static int DamageMagicianLv1;
    public float cooldownArcherLv1
    {
        get { return CooldownArcherLv1; }
    }
    public float rangeArcherLv1
    {
        get { return RangeArcherLv1; }
    }
    public int priceArcherLv1
    {
        get { return PriceAcherLv1; }
    }
    public float cooldownKnightLv1
    {
        get { return CooldownKnightLv1; }
    }
    public float rangeKnightLv1
    {
        get { return RangeKnightLv1; }
    }
    public int priceKnightLv1
    {
        get { return PriceKnightLv1; }
    }
    public float cooldownMagicianLv1
    {
        get { return CooldownMagicianLv1; }
    }
    public float rangeMagicianLv1
    {
        get { return RangeMagicianLv1; }
    }
    public int priceMagicianLv1
    {
        get { return PriceMagicianLv1; }
    }
    public int damageArcherLv1
    {
        get { return DamageArcherLv1; }
    }
    public int damageKnightLv1
    {
        get { return DamageKnightLv1; }
    }
    public int damageMagicianLv1
    {
        get { return DamageMagicianLv1; }
    }
    //default value of archer tower Lv2
    static float CooldownArcherLv2;
    static float RangeArcherLv2;
    static int PriceAcherLv2;
    static int DamageArcherLv2;
    //default value of Knight tower
    static float CooldownKnightLv2;
    static float RangeKnightLv2;
    static int PriceKnightLv2;
    static int DamageKnightLv2;
    //default value of Magician tower
    static float CooldownMagicianLv2;
    static float RangeMagicianLv2;
    static int PriceMagicianLv2;
    static int DamageMagicianLv2;
    public float cooldownArcherLv2
    {
        get { return CooldownArcherLv2; }
    }
    public float rangeArcherLv2
    {
        get { return RangeArcherLv2; }
    }
    public int priceArcherLv2
    {
        get { return PriceAcherLv2; }
    }
    public float cooldownKnightLv2
    {
        get { return CooldownKnightLv2; }
    }
    public float rangeKnightLv2
    {
        get { return RangeKnightLv2; }
    }
    public int priceKnightLv2
    {
        get { return PriceKnightLv2; }
    }
    public float cooldownMagicianLv2
    {
        get { return CooldownMagicianLv2; }
    }
    public float rangeMagicianLv2
    {
        get { return RangeMagicianLv2; }
    }
    public int priceMagicianLv2
    {
        get { return PriceMagicianLv2; }
    }
    public int damageArcherLv2
    {
        get { return DamageArcherLv2; }
    }
    public int damageKnightLv2
    {
        get { return DamageKnightLv2; }
    }
    public int damageMagicianLv2
    {
        get { return DamageMagicianLv2; }
    }
    //default value of archer tower Lv3
    static float CooldownArcherLv3;
    static float RangeArcherLv3;
    static int PriceAcherLv3;
    static int DamageArcherLv3;
    //default value of Knight tower Lv3
    static float CooldownKnightLv3;
    static float RangeKnightLv3;
    static int PriceKnightLv3;
    static int DamageKnightLv3;
    //default value of Magician tower
    static float CooldownMagicianLv3;
    static float RangeMagicianLv3;
    static int PriceMagicianLv3;
    static int DamageMagicianLv3;
    public float cooldownArcherLv3
    {
        get { return CooldownArcherLv3; }
    }
    public float rangeArcherLv3
    {
        get { return RangeArcherLv3; }
    }
    public int priceArcherLv3
    {
        get { return PriceAcherLv3; }
    }
    public float cooldownKnightLv3
    {
        get { return CooldownKnightLv3; }
    }
    public float rangeKnightLv3
    {
        get { return RangeKnightLv3; }
    }
    public int priceKnightLv3
    {
        get { return PriceKnightLv3; }
    }
    public float cooldownMagicianLv3
    {
        get { return CooldownMagicianLv3; }
    }
    public float rangeMagicianLv3
    {
        get { return RangeMagicianLv3; }
    }
    public int priceMagicianLv3
    {
        get { return PriceMagicianLv3; }
    }
    public int damageArcherLv3
    {
        get { return DamageArcherLv3; }
    }
    public int damageKnightLv3
    {
        get { return DamageKnightLv3; }
    }
    public int damageMagicianLv3
    {
        get { return DamageMagicianLv3; }
    }
    public float ArrowBulletSpeed
    {
        get { return arrowBulletSpeed; }
    }    
    public float KnightBulletSpeed
    {
        get { return knightBulletSpeed; }
    }    
    public float MagicianBulletSpeed
    {
        get { return magicianBulletSpeed; }
    }
    //Health of house
    static int FullHealthHouse = 500;
    public int fullHealthHouse
    {
        get { return FullHealthHouse; }
    }
    public ConfigurationData()
    {
        // read and save configuration data from file
        StreamReader input = null;
        try
        {
            // create stream reader object
            input = File.OpenText(Path.Combine(
                Application.streamingAssetsPath, ConfigurationDataFileName));

            // read in names and values
            string names = input.ReadLine();
            string values = input.ReadLine();
            string listvalue = input.ReadLine();
            string bulletName = input.ReadLine();
            string bulletSpeedValue = input.ReadLine();
            // set configuration data fields
            SetConfigurationDataFields(values/*, listvalue*/);
            SetBulletData(bulletSpeedValue);
        }
        catch (Exception e)
        {
        }
        finally
        {
            // always close input file
            if (input != null)
            {
                input.Close();
            }
        }

    }
    static void SetConfigurationDataFields(string csvValues/*, string listValue*/)
    {
        string[] values = csvValues.Split(',');
        try
        {
            BomoveSpeed = float.Parse(values[0]);
            BohealthEnemy = int.Parse(values[1]);
            BoscoreEnemy = int.Parse(values[2]);
            GamoveSpeed = float.Parse(values[3]);
            GahealthEnemy = int.Parse(values[4]);
            GascoreEnemy = int.Parse(values[5]);
            NammoveSpeed = float.Parse(values[6]);
            NamhealthEnemy = int.Parse(values[7]);
            NamscoreEnemy = int.Parse(values[8]);
            SlimemoveSpeed = float.Parse(values[9]);
            SlimehealthEnemy = int.Parse(values[10]);
            SlimescoreEnemy = int.Parse(values[11]);
            ThomoveSpeed = float.Parse(values[12]);
            ThohealthEnemy = int.Parse(values[13]);
            ThoscoreEnemy = int.Parse(values[14]);
            timeBetweenWaves = float.Parse(values[15]);
            //Lv1
            CooldownArcherLv1 = float.Parse(values[16]);
            RangeArcherLv1 = float.Parse(values[17]);
            PriceAcherLv1 = int.Parse(values[18]);
            DamageArcherLv1 = int.Parse(values[19]);
            CooldownKnightLv1 = float.Parse(values[20]);
            RangeKnightLv1 = float.Parse(values[21]);
            PriceKnightLv1 = int.Parse(values[22]);
            DamageKnightLv1 = int.Parse(values[23]);
            CooldownMagicianLv1 = float.Parse(values[24]);
            RangeMagicianLv1 = float.Parse(values[25]);
            PriceMagicianLv1 = int.Parse(values[26]);
            DamageMagicianLv1 = int.Parse(values[27]);
            //Lv2
            CooldownArcherLv2 = float.Parse(values[28]);
            RangeArcherLv2 = float.Parse(values[29]);
            PriceAcherLv2 = int.Parse(values[30]);
            DamageArcherLv2 = int.Parse(values[31]);
            CooldownKnightLv2 = float.Parse(values[32]);
            RangeKnightLv2 = float.Parse(values[33]);
            PriceKnightLv2 = int.Parse(values[34]);
            DamageKnightLv2 = int.Parse(values[35]);
            CooldownMagicianLv2 = float.Parse(values[36]);
            RangeMagicianLv2 = float.Parse(values[37]);
            PriceMagicianLv2 = int.Parse(values[38]);
            DamageMagicianLv2 = int.Parse(values[39]);
            //Lv3
            CooldownArcherLv3 = float.Parse(values[40]);
            RangeArcherLv3 = float.Parse(values[41]);
            PriceAcherLv3 = int.Parse(values[42]);
            DamageArcherLv3 = int.Parse(values[43]);
            CooldownKnightLv3 = float.Parse(values[44]);
            RangeKnightLv3 = float.Parse(values[45]);
            PriceKnightLv3 = int.Parse(values[46]);
            DamageKnightLv3 = int.Parse(values[47]);
            CooldownMagicianLv3 = float.Parse(values[48]);
            RangeMagicianLv3 = float.Parse(values[49]);
            PriceMagicianLv3 = int.Parse(values[50]);
            DamageMagicianLv3 = int.Parse(values[51]);
            DefaultScore = int.Parse(values[52]);
            FullHealthHouse = int.Parse(values[53]);

            DragonmoveSpeed = float.Parse(values[54]);
            DragonhealthEnemy = int.Parse(values[55]);
            DragonscoreEnemy = int.Parse(values[56]);
        } catch (Exception ex) {
            Debug.Log(ex.Message);
        }
        
        /* waves = AddListWave(listValue);*/
    }
    /*static List<Wave> AddListWave(string listvalue)
    {
        List<Wave> list = new List<Wave>();
        string[] values = listvalue.Split(",");
        for(int i = 0;i < values.Length; i+=3)
        {
            if (values[i] == null) {
                break;
            }
            Wave wave = new Wave();
            wave.enemyCount = int.Parse(values[i]);
            wave.timeBetweenEnemies = int.Parse(values[i+1]);
            wave.enemyName = values[i + 2];
            list.Add(wave);
        }
        return list;
    }*/
    private static void SetBulletData(string value)
    {
        string[] strings = value.Split(",");
        try
        {
            arrowBulletSpeed= float.Parse(strings[0]);
            magicianBulletSpeed= float.Parse(strings[1]);
            knightBulletSpeed= float.Parse(strings[2]);
        } catch(Exception ex)
        {

        } 
    }
}
