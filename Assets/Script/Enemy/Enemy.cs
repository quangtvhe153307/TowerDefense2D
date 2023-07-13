using Assets.Script.Event;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : IntEventInvoker
{
    [Header("References")]
    [SerializeField] protected Rigidbody2D rb;
    [Header("Attributes")]
    [SerializeField] public float moveSpeed = 2f;
    [SerializeField] public int health;
    [SerializeField] public int score;

    protected Transform target;
    private int pathIndex;

    //total number of change direction while travel along the path
    private int changedDirectionTimes;

    private GameObject healthBarObject;
    private HealthBar healthBar;
    private Timer attackedTimer;
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

        unityEvents.Add(EventName.EnemyDiedEvent, new EnemyDiedEvent());
        EventManager.AddInvoker(EventName.EnemyDiedEvent, this);

        //get HealthBar
        GameObject enemyHealthBar = this.gameObject.transform.GetChild(0).gameObject;
        healthBarObject = enemyHealthBar.transform.GetChild(0).gameObject;
        healthBar = healthBarObject.GetComponent<HealthBar>();
        if(healthBar != null)
        {
            DeactiveSliderHealthBar();
            healthBar.SetMaxHealth(health);

            //initial timer
            attackedTimer = gameObject.AddComponent<Timer>();
            attackedTimer.Duration= 1;
        }
    }

    protected virtual void Update()
    {
        if (Vector2.Distance(target.position, transform.position) <= 0.1f)
        {
            pathIndex++;
            changedDirectionTimes++;
            if (pathIndex >= PathFinding.main.path.Length)
            {
                gameObject.SetActive(false);
                return;
            }
            else
            {
                target = PathFinding.main.path[pathIndex];
            }
        }

        if(attackedTimer.Finished)
        {
            DeactiveSliderHealthBar();
        }
    }

    protected virtual void FixedUpdate()
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
        //set health for health bar
        healthBar.SetHealth(health);
        healthBarObject.SetActive(true);

        //reset count time if timer is running
        if (attackedTimer.Running)
        {
            attackedTimer.ElapsedSeconds = 0;
        } else
        {
            attackedTimer.Run();
        }

        if (health <= 0){
            this.Death();
        }
    }

    private void Death(){
        //Instantiate death prefab and play sound
        this.gameObject.SetActive(false);
        //Destroy(gameObject);

        //Invoke event when enemy death
        unityEvents[EventName.ScoreAddedEvent].Invoke(this.score);
        unityEvents[EventName.EnemyDiedEvent].Invoke(1);
        AudioManager.Play(AudioClipName.Death);
    }

    protected void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("House")){
            // House house = collision.gameObject.GetComponent<House>();
            // house.TakeDamage(this.damage);
            Debug.Log("Test House collision");
            //Invoke event when enemy attack house
            unityEvents[EventName.HouseAttackedEvent].Invoke(1);
            unityEvents[EventName.EnemyDiedEvent].Invoke(1);

        }
    }
    public void ResetToStartPosition()
    {
        pathIndex = 0;
        target = PathFinding.main.path[pathIndex];
        changedDirectionTimes=0;
    }
    private void DeactiveSliderHealthBar()
    {
        healthBarObject.SetActive(false);
    }
}
