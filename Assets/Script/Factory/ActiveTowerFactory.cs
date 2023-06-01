using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ActiveTowerFactory : TowerFactory
{
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
        GameObject prefab = (GameObject)Resources.Load("prefabs/Towers/ArcherTowerLv" + towerLevel);
        GameObject instance = Instantiate(prefab, position, Quaternion.identity);
        instance.transform.SetParent(GameObject.Find("ArcherTowers").transform);
        ArcherTower newTower = instance.GetComponent<ArcherTower>();
        newTower.Initialize();
        return newTower;
    }
}
