using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ga : Enemy
{
    // Start is called before the first frame update
    protected override void Start()
    {
        health = ConfigurationUtils.GaHealth;
        moveSpeed = ConfigurationUtils.GaSpeed;
        score = ConfigurationUtils.GaScore;
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}
