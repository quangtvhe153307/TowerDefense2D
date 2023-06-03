using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBullet : Bullet
{
    public float ArrowDirection { get; set; } = 180;
    protected override void Start()
    {
        speed = ConfigurationUtils.ArrowBulletSpeed;
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }
}
