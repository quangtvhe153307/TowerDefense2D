using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinding : MonoBehaviour
{
    public static PathFinding main;

    public Transform startPoint;
    public Transform[] path;

    /// <summary>
    /// Contains array of node that make up the path
    /// </summary>
    private Node[] nodes;
    private void Awake()
    {
        main = this;
        InitialNodes();
    }
    /// <summary>
    /// Return sqrDistanceToTheEnd of a gameObject
    /// </summary>
    /// <param name="gameObject">GameObject</param>
    /// <returns>-1 if is not enemy or dont have enemy component</returns>
    public float SqrDistanceToTheEnd(GameObject gameObject)
    {
        if (!gameObject.tag.Equals("Enemy")) return -1;

        Enemy enemy = gameObject.GetComponent<Enemy>();
        if (enemy is null) return -1;

        int numberOfturned = enemy.ChangedDirectionTimes;

        float sqrDistance = nodes[numberOfturned + 1].CostToTheEnd + Vector3.SqrMagnitude(nodes[numberOfturned + 1].Position - gameObject.transform.position);
        return sqrDistance;
    }
    /// <summary>
    /// Initial Node list for and cost To the next node
    /// </summary>
    private void InitialNodes()
    {
        if (path is null || path.Length == 0) return;
        nodes = new Node[path.Length];

        //Assign position for each node in nodes
        for (int i = 0; i < path.Length; i++)
        {
            nodes[i] = new Node
            {
                Position = path[i].position
            };
        }

        // Reverse traversal to calculate cost to the end of each node
        // Cost the the end of current node = cost to the end of previous node + sqrMagnitude between 2 nodes
        nodes[nodes.Length - 1].CostToTheEnd = 0;
        for (int i = nodes.Length - 2; i >= 0; i--)
        {
            nodes[i].CostToTheEnd = nodes[i + 1].CostToTheEnd + Vector3.SqrMagnitude(nodes[i].Position - nodes[i + 1].Position);
        }
    }
}
