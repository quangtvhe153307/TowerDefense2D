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
    //default value of tower

    //default wave enemy
/*    static List<Wave> waves;*/
    static float timeBetweenWaves = 10f;
    //default object pooling count

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
/*    public List<Wave> Waves
    {
        get { return waves; }
    }*/
    public float TimeBetweenWaves
    {
        get { return timeBetweenWaves; }
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
            // set configuration data fields
            SetConfigurationDataFields(values/*, listvalue*/);
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
}
