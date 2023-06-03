using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nam : Enemy
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        health = ConfigurationUtils.NamHealth;
        moveSpeed = ConfigurationUtils.NamSpeed;
        score = ConfigurationUtils.NamScore;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}
