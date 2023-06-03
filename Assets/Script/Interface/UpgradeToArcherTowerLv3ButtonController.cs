using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeToArcherTowerLv3ButtonController : ButtonInterface
{
    [SerializeField] TowerFactory[] factories;
    private TowerFactory factory;
    void Start()
    {
        factory = factories[0];
    }
    void OnMouseDown()
    {
       
         int  price = ConfigurationUtils.PriceArcherLv3;
        if(ScoreManager.SubtractScoreUpgradeTower(price)){
            InstantiateTower();
            Invoke("onDestroy", 0);
        }
    }
    private void InstantiateTower(){
        Vector3 cpos = SelectedTower.transform.position;
        factory.CreateTower("Archer", 3, cpos);
    }
}
