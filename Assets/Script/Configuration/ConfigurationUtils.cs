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
    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
        configurationData = new ConfigurationData();
    }
}
