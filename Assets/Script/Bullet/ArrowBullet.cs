using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBullet : Bullet
{
    public float ArrowDirection { get; set; } = 90;
    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        //speed = 20;
        base.Update();
    }
}
