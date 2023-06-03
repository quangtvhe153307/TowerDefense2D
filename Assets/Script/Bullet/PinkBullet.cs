using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkBullet : Bullet
{
    protected override void Start()
    {
        speed = ConfigurationUtils.KnightBulletSpeed;
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }
}
