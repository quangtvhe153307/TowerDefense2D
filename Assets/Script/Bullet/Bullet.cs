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
    #endregion


    #region Methods
    // Start is called before the first frame update
    protected virtual void Start()
    {
        unityEvents.Add(EventName.EnemyAttackedEvent, new EnemyAttackedEvent());
        EventManager.AddInvoker(EventName.EnemyAttackedEvent, this);
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.transform.position;
            Vector3 direction = targetPosition - gameObject.transform.position;
            direction.Normalize();
            transform.position += speed * Time.deltaTime * direction;
        }
        else
        {
            Debug.Log("quang");
        }

    }
    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.Equals(target))
        {
            //Invoke event when bullet hit target
            unityEvents[EventName.EnemyAttackedEvent].Invoke(this.damage);
            gameObject.SetActive(false);
        }
    }
    public void SetTarget(GameObject target)
    {
        this.target = target;
    }
    #endregion
}
