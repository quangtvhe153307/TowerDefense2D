using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeToArcherTowerLv2ButtonController : ButtonInterface
{
    [SerializeField] TowerFactory[] factories;
    private TowerFactory factory;
    void Start()
    {
        factory = factories[0];
    }
    void OnMouseDown()
    {
        InstantiateTower();
        Invoke("onDestroy", 0);
    }
    private void InstantiateTower(){
        Vector3 cpos = SelectedTower.transform.position;
        ITower tower = factory.CreateTower("archer", 2, cpos);
    }
}
