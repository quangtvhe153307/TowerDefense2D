using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class KnightTower : Tower
{
    protected override void Start()
    {
        gameObject.name = $"KnightLevel{towerLevel}";
        SelectEventManager.AddSelectKnightTowerEventInvoker(this);
        //cooldown = 0.4f;
        //range = 3;
        base.Start();
        cooldown = ConfigurationUtils.CooldownKnight;
        range = ConfigurationUtils.RangeKnight;
        Price = ConfigurationUtils.PriceKnight;
    }
    protected override GameObject GetPooledBullet()
    {
        GameObject go = ObjectPool.SharedInstance.GetPooledObject("PinkBullet");
        return go;
    }
}

