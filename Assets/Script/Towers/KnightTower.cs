using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class KnightTower : Tower
{
    [SerializeField]
    private int price;
    [SerializeField]
    private int towerLevel;
    public int Price { get => price; set => price = value; }
    public int TowerLevel { get => towerLevel; set=> towerLevel = value; }
    SelectTowerEvent selectEvent = new SelectTowerEvent();
    protected override GameObject GetPooledBullet()
    {
        GameObject go = ObjectPool.SharedInstance.GetPooledObject("PinkBullet");
        return go;
    }

    protected override void Start()
    {
        gameObject.name = $"KnightLevel{TowerLevel}";
        transform.Find("SelectCircle").gameObject.SetActive(false);
        SelectEventManager.AddSelectKnightTowerEventInvoker(this);
        //cooldown = 0.4f;
        //range = 3;
        base.Start();
    }
    public void AddSelectCPEventListener(UnityAction<GameObject, int> listener)
    {
        selectEvent.AddListener(listener);
    }
    void OnMouseDown()
    {
        if (GameObject.Find("SelectCircle"))
        {
            GameObject.Find("SelectCircle").gameObject.SetActive(false);
        }
        transform.Find("SelectCircle").gameObject.SetActive(true);
        selectEvent.Invoke(this.gameObject, TowerLevel);
    }
}

