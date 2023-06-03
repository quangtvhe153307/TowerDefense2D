using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeToKnightTowerLv2ButtonController : ButtonInterface
{
    [SerializeField] TowerFactory[] factories;
    private TowerFactory factory;
    void Start()
    {
        factory = factories[0];
    }
    void OnMouseDown()
    {
         int  price = ConfigurationUtils.PriceKnightLv2;
        if(ScoreManager.SubtractScoreUpgradeTower(price)){
            InstantiateTower();
            Invoke("onDestroy", 0);
        }
    }
    private void InstantiateTower(){
        Vector3 cpos = SelectedTower.transform.position;
        factory.CreateTower("Knight", 2, cpos);
    }
}
