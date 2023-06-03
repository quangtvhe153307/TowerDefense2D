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
        if (towerLevel == 1)
        {
            cooldown = ConfigurationUtils.CooldownKnightLv1;
            range = ConfigurationUtils.RangeKnightLv1;
            Price = ConfigurationUtils.PriceKnightLv1;
            damage = ConfigurationUtils.DamageKnightLv1;
        }
        else if (towerLevel == 2)
        {
            cooldown = ConfigurationUtils.CooldownKnightLv2;
            range = ConfigurationUtils.RangeKnightLv2;
            Price = ConfigurationUtils.PriceKnightLv2;
            damage = ConfigurationUtils.DamageKnightLv2;
        }
        else if (towerLevel == 3)
        {
            cooldown = ConfigurationUtils.CooldownKnightLv3;
            range = ConfigurationUtils.RangeKnightLv3;
            Price = ConfigurationUtils.PriceKnightLv3;
            damage = ConfigurationUtils.DamageKnightLv3;
        }
    }
    protected override GameObject GetPooledBullet()
    {
        GameObject go = ObjectPool.SharedInstance.GetPooledObject("PinkBullet");
        return go;
    }
    protected override void PlaySound()
    {
        AudioManager.Play(AudioClipName.KnightTowerShoot);
    }
}

