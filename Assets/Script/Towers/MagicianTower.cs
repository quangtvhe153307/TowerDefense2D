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
        if (towerLevel == 1)
        {
            cooldown = ConfigurationUtils.CooldownMagicianLv1;
            range = ConfigurationUtils.RangeMagicianLv1;
            Price = ConfigurationUtils.PriceMagicianLv1;
            damage = ConfigurationUtils.DamageMagicianLv1;
        }
        else if (towerLevel == 2)
        {
            cooldown = ConfigurationUtils.CooldownMagicianLv2;
            range = ConfigurationUtils.RangeMagicianLv2;
            Price = ConfigurationUtils.PriceMagicianLv2;
            damage = ConfigurationUtils.DamageMagicianLv2;
        }
        else if (towerLevel == 3)
        {
            cooldown = ConfigurationUtils.CooldownMagicianLv3;
            range = ConfigurationUtils.RangeMagicianLv3;
            Price = ConfigurationUtils.PriceMagicianLv3;
            damage = ConfigurationUtils.DamageMagicianLv3;
        }
        base.Start();
        
    }
    protected override GameObject GetPooledBullet()
    {
        GameObject go = ObjectPool.SharedInstance.GetPooledObject("GreenBullet");
        return go;
    }
}

