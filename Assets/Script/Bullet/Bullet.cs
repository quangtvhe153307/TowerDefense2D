using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : IntEventInvoker
{
    #region Fields
    [SerializeField]
    protected int damage = 1;
    [SerializeField]
    protected float speed = 1;

    protected GameObject target;
    private Vector3 targetPosition;
    #endregion


    #region Methods
    // Start is called before the first frame update
    protected virtual void Start()
    {
        //unityEvents.Add(EventName.EnemyAttackedEvent, new EnemyAttackedEvent());
        //EventManager.AddInvoker(EventName.EnemyAttackedEvent, this);
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
            //Invoke event when bullet hit target
            //unityEvents[EventName.EnemyAttackedEvent].Invoke(this.damage);

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
    #endregion
}
