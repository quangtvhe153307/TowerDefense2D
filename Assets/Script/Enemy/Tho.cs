using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tho : Enemy
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        health = ConfigurationUtils.ThoHealth;
        moveSpeed = ConfigurationUtils.ThoSpeed;
        score = ConfigurationUtils.ThoScore;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}
