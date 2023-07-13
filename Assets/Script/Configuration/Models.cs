using System.Collections.Generic;

[System.Serializable]
public class WaveConfig {
    public LevelConfig EasyLevel;
    public LevelConfig MediumLevel;
    public LevelConfig HardLevel;
}
[System.Serializable]
public class LevelConfig
{
    public string Level;
    public List<SceenConfig> Screens;
}
[System.Serializable]
public class SceenConfig
{
    public int ScreenNumber;
    public float timeBetweenWaves;
    public List<Wave> Waves;
    public List<string> listEnemies;
}
[System.Serializable]
public class Wave
{
    public int enemyCount;
    public float timeBetweenEnemies;
    public int[] enemyType;
}