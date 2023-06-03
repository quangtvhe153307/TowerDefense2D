using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeToMagicianTowerLv2ButtonController : ButtonInterface
{
    [SerializeField] TowerFactory[] factories;
    private TowerFactory factory;

    void Start()
    {
        factory = factories[0];
    }
    void OnMouseDown()
    {
         int  price = ConfigurationUtils.PriceMagicianLv2;
        if(ScoreManager.SubtractScoreUpgradeTower(price)){
            InstantiateTower();
            Invoke("onDestroy", 0);
        }
    }
    private void InstantiateTower(){
        Vector3 cpos = SelectedTower.transform.position;
        factory.CreateTower("Magician", 2, cpos);
    }
}
