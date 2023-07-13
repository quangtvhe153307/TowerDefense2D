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
    public List<WaveDetail> Waves;
    public List<string> listEnemies;
}
[System.Serializable]
public class WaveDetail
{
    public int[] enemies;
    public float timeBetweenEnemies;
}