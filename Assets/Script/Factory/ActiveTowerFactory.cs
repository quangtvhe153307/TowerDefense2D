using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ActiveTowerFactory : TowerFactory
{
    public override void CreateTower(string towerType, int towerLevel, Vector3 position)
    {
        GameObject prefab = (GameObject)Resources.Load($"prefabs/Towers/{towerType}TowerLv{towerLevel}");
        GameObject instance = Instantiate(prefab, position, Quaternion.identity);
        instance.transform.SetParent(GameObject.Find($"{towerType}Towers").transform);
    }
}
