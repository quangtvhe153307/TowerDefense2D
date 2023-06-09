using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Enemy : IntEventInvoker
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;
    [Header("Attributes")]
     public float moveSpeed;
     public int health;
     public int score;

    private Transform target;
    private int pathIndex;

    //total number of change direction while travel along the path
    private int changedDirectionTimes;

    public int ChangedDirectionTimes
    {
        get { return changedDirectionTimes; }
    }
    protected virtual void Start()
    {
        target = PathFinding.main.path[pathIndex];
        rb = GetComponent<Rigidbody2D>();

        changedDirectionTimes = 0;

        unityEvents.Add(EventName.ScoreAddedEvent, new ScoreAddedEvent());
        EventManager.AddInvoker(EventName.ScoreAddedEvent, this);

        unityEvents.Add(EventName.HouseAttackedEvent, new HouseAttackedEvent());
        EventManager.AddInvoker(EventName.HouseAttackedEvent, this);

        //EventManager.AddListener(EventName.EnemyAttackedEvent, SubtractHealth);
    }

    protected virtual void Update()
    {
        if (Vector2.Distance(target.position, transform.position) <= 0.1f)
        {
            pathIndex++;
            changedDirectionTimes++;
            if (pathIndex >= PathFinding.main.path.Length)
            {
                Destroy(gameObject);
                return;
            }
            else
            {
                target = PathFinding.main.path[pathIndex];
            }
        }
    }

    private void FixedUpdate()
    {
        Vector2 direction = (target.position - transform.position).normalized;
        rb.velocity = direction * moveSpeed;
    }
    /// <summary>
    /// Subtract enemy's healthy when bullet reached
    /// </summary>
    /// <param name="points">points to add</param>
    public void SubtractHealth(int points)
    {
        health -= points;
        //Debug.Log("Subtract 10 points");
        if(health <= 0){
            this.Death();
        }
    }

    private void Death(){
        //Instantiate death prefab and play sound
        //this.gameObject.SetActive(false);
        Destroy(gameObject);

        //Invoke event when enemy death
        unityEvents[EventName.ScoreAddedEvent].Invoke(this.score);
        AudioManager.Play(AudioClipName.Death);
    }

    protected void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("House")){
            // House house = collision.gameObject.GetComponent<House>();
            // house.TakeDamage(this.damage);

            //Invoke event when enemy attack house
            unityEvents[EventName.HouseAttackedEvent].Invoke(1);

        }
    }

}
