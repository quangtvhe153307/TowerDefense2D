using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class MagicianTower : Tower
{
    [SerializeField]
    private int price;
    [SerializeField]
    private int towerLevel;
    public int Price { get => price; set => price = value; }
    public int TowerLevel { get => towerLevel; set=> towerLevel = value; }
    SelectTowerEvent selectEvent = new SelectTowerEvent();
    protected override void Start()
    {
        gameObject.name = $"MagicianLevel{TowerLevel}";
        transform.Find("SelectCircle").gameObject.SetActive(false);
        SelectEventManager.AddSelectMagicianTowerEventInvoker(this);
        //cooldown = 0.4f;
        //range = 5;
        base.Start();
    }
    protected override GameObject GetPooledBullet()
    {
        GameObject go = ObjectPool.SharedInstance.GetPooledObject("GreenBullet");
        return go;
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

