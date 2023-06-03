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
        int  price = ConfigurationUtils.PriceArcherLv2;
        if(ScoreManager.SubtractScoreUpgradeTower(price)){
            InstantiateTower();
            Invoke("onDestroy", 0);
        }

    }
    private void InstantiateTower(){
        Vector3 cpos = SelectedTower.transform.position;
        factory.CreateTower("Archer", 2, cpos);
    }
}
