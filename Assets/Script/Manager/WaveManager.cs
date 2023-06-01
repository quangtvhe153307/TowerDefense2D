using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// Get target for a specific tower
    /// </summary>
    /// <param name="tower">Tower</param>
    /// <returns></returns>
    public static GameObject GetTarget(Tower tower)
    {
        List<GameObject> targetsInRange = GetTargetsInRange(tower);
        if(targetsInRange == null || targetsInRange.Count == 0)
        {
            return null;
        }
        GameObject closestTargetToTheEnd = FindClosestTargetToTheEnd(targetsInRange);
        return closestTargetToTheEnd;
    }
    /// <summary>
    /// Get List of target in range of tower
    /// </summary>
    /// <param name="tower">tower</param>
    /// <returns></returns>
    private static List<GameObject> GetTargetsInRange(Tower tower)
    {
        //Get All active enemy in current scene
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Enemy");

        //Store all enemy in range
        List<GameObject> targetsInRange = new List<GameObject>();

        //Squared of tower range, used for comparision versus squaredDistance
        float squaredRange = tower.Range * tower.Range;

        foreach (var gameObject in gameObjects)
        {
            float squaredDistance = Vector3.SqrMagnitude(gameObject.transform.position - tower.transform.position);
            if (squaredDistance < squaredRange)
            {
                targetsInRange.Add(gameObject);
            }
        }
        return targetsInRange;
    }
    /// <summary>
    /// Choose a closest target to the end in the list of gameObject
    /// </summary>
    /// <param name="targets"></param>
    /// <returns></returns>
    private static GameObject FindClosestTargetToTheEnd(List<GameObject> targets)
    {
        if(targets is null || targets.Count == 0) { return null; }
        float shortestSqrDistance = float.MaxValue;
        GameObject closestTarget = null;
        foreach (var target in targets)
        {
            float sqrDistance = PathFinding.main.SqrDistanceToTheEnd(target);
            if(sqrDistance < shortestSqrDistance)
            {
                shortestSqrDistance = sqrDistance;
                closestTarget = target;
            }
        }
        return closestTarget;
    }
}
