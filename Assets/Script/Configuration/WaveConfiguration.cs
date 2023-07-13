using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class WaveConfiguration
{
    public static WaveConfig config { get; set; }


    private static string ConfigPath = Application.streamingAssetsPath + "/config/wave.json";
    
    
    public static void Initialize (){
        string json = File.ReadAllText(ConfigPath);

        config = JsonUtility.FromJson<WaveConfig>(json);

        
    }
}
