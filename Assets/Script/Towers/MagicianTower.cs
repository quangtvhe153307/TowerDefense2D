using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class MagicianTower : Tower
{
    SelectTowerEvent selectEvent = new SelectTowerEvent();
    protected override void Start()
    {
        gameObject.name = $"MagicianLevel{towerLevel}";
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
    protected override void OnMouseDown()
    {
        base.OnMouseDown();
        selectEvent.Invoke(this.gameObject, towerLevel);
    }
}

