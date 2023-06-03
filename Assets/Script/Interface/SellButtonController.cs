using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellButtonController : ButtonInterface
{
    [SerializeField]
    private GameObject prefab;
    void OnMouseDown()
    {
       
        int priceSell = 0; 
        if( SelectedTower.GetComponent<ArcherTower>() != null){
            int level = SelectedTower.GetComponent<ArcherTower>().towerLevel;
            switch(level){
                case 1:
                priceSell =  ConfigurationUtils.PriceArcherLv1 / 2;
                break;
                case 2:
                priceSell =  (ConfigurationUtils.PriceArcherLv2 + ConfigurationUtils.PriceArcherLv1) / 2;
                break;
                case 3:
                priceSell =  (ConfigurationUtils.PriceArcherLv3 + ConfigurationUtils.PriceArcherLv2 + ConfigurationUtils.PriceArcherLv1)/ 2;
                break;
            }
        }
        if( SelectedTower.GetComponent<KnightTower>() != null){
            int level = SelectedTower.GetComponent<KnightTower>().towerLevel;
            switch(level){
                case 1:
                priceSell =  ConfigurationUtils.PriceKnightLv1 / 2;
                break;
                case 2:
                priceSell =  (ConfigurationUtils.PriceKnightLv2 + ConfigurationUtils.PriceKnightLv1) / 2;
                break;
                case 3:
                priceSell =  (ConfigurationUtils.PriceKnightLv3 + ConfigurationUtils.PriceKnightLv2 + ConfigurationUtils.PriceKnightLv1)/ 2;
                break;
            }
        }
        if( SelectedTower.GetComponent<MagicianTower>() != null){
            int level = SelectedTower.GetComponent<MagicianTower>().towerLevel;
            switch(level){
                case 1:
                priceSell =  ConfigurationUtils.PriceMagicianLv1 / 2;
                break;
                case 2:
                priceSell =  (ConfigurationUtils.PriceMagicianLv2 + ConfigurationUtils.PriceMagicianLv1) / 2;
                break;
                case 3:
                priceSell =  (ConfigurationUtils.PriceMagicianLv3 + ConfigurationUtils.PriceMagicianLv2 + ConfigurationUtils.PriceMagicianLv1)/ 2;
                break;
            }
        }
        ScoreManager.AddScoreSellTower(priceSell);
        InstantiateCP();
        Invoke("onDestroy", 0);
        
    }
    private void InstantiateCP()
    {
        Vector3 cpos = SelectedTower.transform.position;
        GameObject instance = Instantiate(prefab, cpos, Quaternion.identity);
        instance.transform.SetParent(GameObject.Find("CPs").transform);
    }
}
