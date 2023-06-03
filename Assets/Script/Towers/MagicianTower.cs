using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class MagicianTower : Tower
{
    protected override void Start()
    {
        gameObject.name = $"MagicianLevel{towerLevel}";
        SelectEventManager.AddSelectMagicianTowerEventInvoker(this);
        //cooldown = 0.4f;
        //range = 5;
        base.Start();
        cooldown = ConfigurationUtils.CooldownMagician;
        range = ConfigurationUtils.RangeMagician;
        Price = ConfigurationUtils.PriceMagician;
    }
    protected override GameObject GetPooledBullet()
    {
        GameObject go = ObjectPool.SharedInstance.GetPooledObject("GreenBullet");
        return go;
    }
}

