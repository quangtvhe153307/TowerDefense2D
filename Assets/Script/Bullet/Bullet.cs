using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : IntEventInvoker
{
    #region Fields
    protected int damage = 1;
    protected float speed = 1;

    protected GameObject target;
    private Vector3 targetPosition;
    #endregion


    #region Methods
    // Start is called before the first frame update
    protected virtual void Start()
    {
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if(target != null)
        {
            targetPosition = target.transform.position;
        }

        if (targetPosition != null)
        {
            Vector3 direction = targetPosition - gameObject.transform.position;
            if (target == null && Vector3.SqrMagnitude(direction) < 0.1)
            {
                gameObject.SetActive(false);
            }
            direction.Normalize();
            transform.position += speed * Time.deltaTime * direction;
        }
        else
        {
            Debug.Log("Target position is null");
        }
    }
    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.Equals(target))
        {

            //Subtract enemy health
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            enemy.SubtractHealth(damage);

            //set active false
            gameObject.SetActive(false);
        }
    }
    public void SetTarget(GameObject target)
    {
        this.target = target;
    }
    public void SetDamage(int damage)
    {
        this.damage = damage;
    }
    #endregion
}
