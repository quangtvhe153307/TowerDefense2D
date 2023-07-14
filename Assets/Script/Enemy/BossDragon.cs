using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BossDragon : Enemy
{
    private Animator animator;
    // Start is called before the first frame update
    protected override void Start()
    {
        health = ConfigurationUtils.DragonHealth;
        maxHealth = health;
        moveSpeed = ConfigurationUtils.DragonSpeed;
        score = ConfigurationUtils.DragonScore;
        animator = GetComponent<Animator>();
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        Vector2 direction2 = (base.target.position - transform.position).normalized;
        float angle = Vector2.Angle(Vector2.right, direction2);
        Debug.Log(angle);
        if (89 <= angle && angle <= 91 && rb.velocity.y>0) {
            animator.Play("RongBayDocLen");
        }
        else if (-1 <= angle && angle <= 1)
        {
            animator.Play("RongBay");
        }
        else if (89 <= angle && angle <= 91 && rb.velocity.y<0){
            animator.Play("RongBayDoc");
        }
    }
}
