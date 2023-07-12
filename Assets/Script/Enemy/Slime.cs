using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy
{
    // Start is called before the first frame update
    protected override void Start()
    {
        health = ConfigurationUtils.NamHealth;
        moveSpeed = ConfigurationUtils.NamSpeed;
        score = ConfigurationUtils.NamScore;
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}
