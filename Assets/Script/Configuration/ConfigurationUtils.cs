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

    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
        configurationData = new ConfigurationData();
    }
}
