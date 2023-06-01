using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;
    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private int health;


    private Transform target;
    private int pathIndex;

    //total number of change direction while travel along the path
    private int changedDirectionTimes;

    public int ChangedDirectionTimes
    {
        get { return changedDirectionTimes; }
    }
    private void Start()
    {
        target = PathFinding.main.path[pathIndex];
        rb = GetComponent<Rigidbody2D>();

        changedDirectionTimes = 0;

        EventManager.AddListener(EventName.EnemyAttackedEvent, SubtractHealth);
    }

    private void Update()
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
        //health -= points;
        Debug.Log("Subtract 10 points");
    }
}
