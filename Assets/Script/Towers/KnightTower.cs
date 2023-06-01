using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class KnightTower : Tower
{
    protected override GameObject GetPooledBullet()
    {
        GameObject go = ObjectPool.SharedInstance.GetPooledObject("PinkBullet");
        return go;
    }

    protected override void Start()
    {
        //cooldown = 0.4f;
        //range = 3;
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }
}

