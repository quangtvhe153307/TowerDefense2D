using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class KnightTower : Tower
{
    SelectTowerEvent selectEvent = new SelectTowerEvent();
    protected override GameObject GetPooledBullet()
    {
        GameObject go = ObjectPool.SharedInstance.GetPooledObject("PinkBullet");
        return go;
    }

    protected override void Start()
    {
        gameObject.name = $"KnightLevel{towerLevel}";
        SelectEventManager.AddSelectKnightTowerEventInvoker(this);
        //cooldown = 0.4f;
        //range = 3;
        base.Start();
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

