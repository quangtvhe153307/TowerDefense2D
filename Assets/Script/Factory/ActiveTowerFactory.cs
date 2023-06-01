using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ActiveTowerFactory : TowerFactory
{
    [SerializeField]
    private ArcherTower archerLv1Prefab;
    [SerializeField]
    private ArcherTower archerLv2Prefab;
    [SerializeField]
    private ArcherTower archerLv3Prefab;
    public override ITower CreateTower(string towerType, int towerLevel, Vector3 position)
    {
        switch (towerType)
        {
            case "archer":
                return CreateArcherTower(towerLevel, position);
            default:
                return null;
        }
        
    }
    private ITower CreateArcherTower(int towerLevel, Vector3 position)
    {
        GameObject instance;
        GameObject prefab;
        switch (towerLevel)
        {
            case 1:
                prefab = archerLv1Prefab.gameObject;
                break;
            case 2:
                prefab = archerLv2Prefab.gameObject;
                break;
            case 3:
                prefab = archerLv3Prefab.gameObject;
                break;
            default:
                return null;
        }
        instance = Instantiate(prefab, position, Quaternion.identity);
        instance.transform.SetParent(GameObject.Find("ArcherTowers").transform);
        ArcherTower newTower = instance.GetComponent<ArcherTower>();
        newTower.Initialize();
        return newTower;
    }
}
