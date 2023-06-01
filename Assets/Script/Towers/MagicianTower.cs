using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class MagicianTower : Tower
{
    protected override void Start()
    {
        //cooldown = 0.4f;
        //range = 5;
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }
    protected override GameObject GetPooledBullet()
    {
        GameObject go = ObjectPool.SharedInstance.GetPooledObject("GreenBullet");
        return go;
    }
}

