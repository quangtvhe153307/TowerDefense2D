using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnClickCPInterface : MonoBehaviour
{
    [SerializeField] TowerFactory[] factories;
    [SerializeField] private string towerType;
    private TowerFactory factory;
    private GameObject selectedCP;

    public void Initialize(GameObject selected){
        selectedCP = selected;
    }
    void Start()
    {
        factory = factories[0];
    }
    void Update()
    {
    }
    void OnMouseDown()
    {
        int price = 0;
        switch(towerType){
           case "Archer":
                price = ConfigurationUtils.PriceArcherLv1;
                break;
            case "Knight":
                price = ConfigurationUtils.PriceKnightLv1;
            break;
            case "Magician":
                price = ConfigurationUtils.PriceMagicianLv1;
            break;
        }
        if(ScoreManager.SubtractScoreUpgradeTower(price)){
            createTowerLevel1();
        }
    }
    void createTowerLevel1()
    {
        InstantiateTower();
        Invoke("onDestroy", 0);
    }
    private void onDestroy()
    {
        Destroy(this.gameObject.transform.parent.gameObject);
        Destroy(selectedCP.gameObject);
    }
    private void InstantiateTower()
    {
        Vector3 cpos = selectedCP.transform.position;
        cpos.y = cpos.y + 0.1f;
        factory.CreateTower(towerType, 1, cpos);
    }

}
