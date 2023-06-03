using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bo : Enemy
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        health = ConfigurationUtils.BoHealth;
        moveSpeed = ConfigurationUtils.BoSpeed;
        score = ConfigurationUtils.BoScore;
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}
