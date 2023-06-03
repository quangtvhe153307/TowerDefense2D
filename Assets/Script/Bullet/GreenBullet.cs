using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBullet : Bullet
{
    protected override void Start()
    {
        speed = ConfigurationUtils.MagicianBulletSpeed;
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }
}
