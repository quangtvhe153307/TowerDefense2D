using Assets.Script.Event;
using Assets.Script.Manager;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WaveManager : IntEventInvoker
{
    //store information of wave
    static string[] listEnemy = {"Bo","Ga","Nam","Slime","Tho"};
    public List<Wave> waves;
    public float timeBetweenWaves;
    private Queue<Wave> waveQueue = new Queue<Wave>();
    private Wave currentWave;

    //store state of wave game
    private int currentWaveCount;
    private int totalWaveCount;
    private int aliveEnemy;
    //properties for get wave state information

    public static WaveManager main;
    public int CurrentWave
    {
        get { return currentWaveCount; }
    }    
    public int TotalWave
    {
        get { return totalWaveCount; }
    }
    public int AliveEnemy
    {
        get { return aliveEnemy; }
    }
    private void Start()
    {
        totalWaveCount = waves.Count;
        currentWaveCount = 0;

        timeBetweenWaves = ConfigurationUtils.TimeBetweenWaves;
        foreach (Wave wave in waves)
        {
            waveQueue.Enqueue(wave);
        }

        main = this;

        EventManager.AddListener(EventName.EnemyDiedEvent, EnemyDiedListener);
        unityEvents.Add(EventName.NewWaveStartedEvent, new NewWaveStartedEvent());
        EventManager.AddInvoker(EventName.NewWaveStartedEvent, this);

        StartNextWave();
    }
    private void Update()
    {
        Debug.Log("currentWaveCount: " + currentWaveCount);
        Debug.Log("totalWaveCount: "+totalWaveCount);
        Debug.Log("aliveEnemy: "+aliveEnemy);
    }
    public void StartNextWave()
    {
        if (waveQueue.Count > 0)
        {
            currentWave = waveQueue.Dequeue();
            Debug.Log("Start next wave!");
            StartCoroutine(SpawnEnemies(currentWave));

            aliveEnemy = currentWave.enemyCount;
            currentWaveCount++;

            //invoke new wave event
            unityEvents[EventName.NewWaveStartedEvent].Invoke(1);
        }
        else
        {
            Debug.Log("No more wave");
        }
    }

    private IEnumerator SpawnEnemies(Wave wave)
    {
        yield return new WaitForSeconds(10f);

        for (int i = 0; i < wave.enemyCount; i++)
        {
            int randomType = Random.Range(wave.enemyType[0] - 1, wave.enemyType[1]);
            GameObject enemy = ObjectPool.SharedInstance.GetPooledObject("Enemy" + listEnemy[randomType]);
            enemy.SetActive(true);
            enemy.transform.position = transform.position;
            yield return new WaitForSeconds(wave.timeBetweenEnemies);
        }
    }
    public void EnemyDiedListener(int number)
    {
        aliveEnemy--;
        if(aliveEnemy == 0)
        {
            StartNextWave();
        }
    }
    /// <summary>
    /// Get target for a specific tower
    /// </summary>
    /// <param name="tower">Tower</param>
    /// <returns></returns>
    public static GameObject GetTarget(Tower tower)
    {
        List<GameObject> targetsInRange = GetTargetsInRange(tower);
        if(targetsInRange == null || targetsInRange.Count == 0)
        {
            return null;
        }
        GameObject closestTargetToTheEnd = FindClosestTargetToTheEnd(targetsInRange);
        return closestTargetToTheEnd;
    }
    /// <summary>
    /// Get List of target in range of tower
    /// </summary>
    /// <param name="tower">tower</param>
    /// <returns></returns>
    private static List<GameObject> GetTargetsInRange(Tower tower)
    {
        //Get All active enemy in current scene
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Enemy");

        //Store all enemy in range
        List<GameObject> targetsInRange = new List<GameObject>();

        //Squared of tower range, used for comparision versus squaredDistance
        float squaredRange = tower.Range * tower.Range;

        foreach (var gameObject in gameObjects)
        {
            float squaredDistance = Vector3.SqrMagnitude(gameObject.transform.position - tower.transform.position);
            if (squaredDistance < squaredRange)
            {
                targetsInRange.Add(gameObject);
            }
        }
        return targetsInRange;
    }
    /// <summary>
    /// Choose a closest target to the end in the list of gameObject
    /// </summary>
    /// <param name="targets"></param>
    /// <returns></returns>
    private static GameObject FindClosestTargetToTheEnd(List<GameObject> targets)
    {
        if(targets is null || targets.Count == 0) { return null; }
        float shortestSqrDistance = float.MaxValue;
        GameObject closestTarget = null;
        foreach (var target in targets)
        {
            float sqrDistance = PathFinding.main.SqrDistanceToTheEnd(target);
            if(sqrDistance < shortestSqrDistance)
            {
                shortestSqrDistance = sqrDistance;
                closestTarget = target;
            }
        }
        return closestTarget;
    }
}
