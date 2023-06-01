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



    private void Awake()
    {
        SharedInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
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
