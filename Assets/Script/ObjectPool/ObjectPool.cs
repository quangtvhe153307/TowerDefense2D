using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool SharedInstance;

    private Dictionary<string, List<GameObject>> pooledObjectDictionary = new Dictionary<string, List<GameObject>>();

    //GreenBullet
    [SerializeField]
    public GameObject greenBulletToPool;
    [SerializeField]
    public int amountGreenBulletToPool;    
    
    //PinkBullet
    [SerializeField]
    public GameObject pinkBulletToPool;
    [SerializeField]
    public int amountPinkBulletToPool;
    
    //ArrowBullet
    [SerializeField]
    public GameObject arrowToPool;
    [SerializeField]
    public int amountArrowToPool;

    //Enemy Bo
    [SerializeField]
    public GameObject enemyBo;
    [SerializeField]
    public int amountBoEnemy;
    //Enemy Ga
    [SerializeField]
    public GameObject enemyGa;
    [SerializeField]
    public int amountGaEnemy;
    //Enemy Tho
    [SerializeField]
    public GameObject enemyTho;
    [SerializeField]
    public int amountThoEnemy;
    //Enemy Nam
    [SerializeField]
    public GameObject enemyNam;
    [SerializeField]
    public int amountNamEnemy;
    //Enemy Slime
    [SerializeField]
    public GameObject enemySlime;
    [SerializeField]
    public int amountSlimeEnemy;

    //Boss Dragon
    [SerializeField]
    public GameObject bossDragon;
    private void Awake()
    {
        SharedInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        List<GameObject> pooledEnemy = new List<GameObject>();
        GameObject tmp2;
        for (int i = 0; i < amountBoEnemy; i++)
        {
            tmp2 = Instantiate(enemyBo);
            tmp2.SetActive(false);
            pooledEnemy.Add(tmp2);
        }
        pooledObjectDictionary.Add("EnemyBo", pooledEnemy);

        pooledEnemy = new List<GameObject>();
        for (int i = 0; i < amountThoEnemy; i++)
        {
            tmp2 = Instantiate(enemyTho);
            tmp2.SetActive(false);
            pooledEnemy.Add(tmp2);
        }
        pooledObjectDictionary.Add("EnemyTho", pooledEnemy);

        pooledEnemy = new List<GameObject>();
        for (int i = 0; i < amountGaEnemy; i++)
        {
            tmp2 = Instantiate(enemyGa);
            tmp2.SetActive(false);
            pooledEnemy.Add(tmp2);
        }
        pooledObjectDictionary.Add("EnemyGa", pooledEnemy);

        pooledEnemy = new List<GameObject>();
        for (int i = 0; i < amountNamEnemy; i++)
        {
            tmp2 = Instantiate(enemyNam);
            tmp2.SetActive(false);
            pooledEnemy.Add(tmp2);
        }
        pooledObjectDictionary.Add("EnemyNam", pooledEnemy);

        pooledEnemy = new List<GameObject>();
        for (int i = 0; i < amountSlimeEnemy; i++)
        {
            tmp2 = Instantiate(enemySlime);
            tmp2.SetActive(false);
            pooledEnemy.Add(tmp2);
        }
        pooledObjectDictionary.Add("EnemySlime", pooledEnemy);

        pooledEnemy = new List<GameObject>();
        for (int i = 0; i < 1; i++)
        {
            tmp2 = Instantiate(bossDragon);
            tmp2.SetActive(false);
            pooledEnemy.Add(tmp2);
        }
        pooledObjectDictionary.Add("BossDragon", pooledEnemy);

        List<GameObject> pooledGreenBullets = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountGreenBulletToPool; i++)
        {
            tmp = Instantiate(greenBulletToPool);
            tmp.SetActive(false);
            pooledGreenBullets.Add(tmp);
        }
        pooledObjectDictionary.Add("GreenBullet", pooledGreenBullets);        
        
        pooledGreenBullets = new List<GameObject>();
        for (int i = 0; i < amountPinkBulletToPool; i++)
        {
            tmp = Instantiate(pinkBulletToPool);
            tmp.SetActive(false);
            pooledGreenBullets.Add(tmp);
        }
        pooledObjectDictionary.Add("PinkBullet", pooledGreenBullets);        
        
        pooledGreenBullets = new List<GameObject>();
        for (int i = 0; i < amountArrowToPool; i++)
        {
            tmp = Instantiate(arrowToPool);
            tmp.SetActive(false);
            pooledGreenBullets.Add(tmp);
        }
        pooledObjectDictionary.Add("ArrowBullet", pooledGreenBullets);
    }
    /// <summary>
    /// Get a single game object by key
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>

    public GameObject GetPooledObject(string key)
    {
        if (!pooledObjectDictionary.ContainsKey(key))
        {
            return null;
        }
        List<GameObject> gameObjects = pooledObjectDictionary[key];

        for (int i = 0; i < gameObjects.Count; i++)
        {
            if (!gameObjects[i].activeInHierarchy)
            {
                return gameObjects[i];
            }
        }
        return null;
    }
    /// <summary>
    /// Get List of Inactive Object base on key
    /// </summary>
    /// <param name="key"></param>
    /// <param name="amount"></param>
    /// <returns></returns>
    public List<GameObject> GetPooledObjects(string key, int amount)
    {
        if (!pooledObjectDictionary.ContainsKey(key))
        {
            return null;
        }
        List<GameObject> list = new List<GameObject>();
        List<GameObject> gameObjects = pooledObjectDictionary[key];
        for (int i = 0; i < gameObjects.Count && list.Count < amount; i++)
        {
            if (!gameObjects[i].activeInHierarchy)
            {
                list.Add(gameObjects[i]);
            }
        }
        return list;
    }
}
