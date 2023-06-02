using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ConfigurationData
{
    const string ConfigurationDataFileName = "ConfigurationData.csv";

    //default value of enemy
    static float BomoveSpeed = 2f;
    static int BohealthEnemy = 100;
    static int BoscoreEnemy = 100;
    //default value of tower

    //default wave enemy

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

            // set configuration data fields
            SetConfigurationDataFields(values);
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
    static void SetConfigurationDataFields(string csvValues)
    {
        string[] values = csvValues.Split(',');
        BomoveSpeed = float.Parse(values[0]);
        BohealthEnemy = int.Parse(values[1]);
        BoscoreEnemy = int.Parse(values[2]);
    }
}
