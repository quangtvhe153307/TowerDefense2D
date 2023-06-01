using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class ArcherTower : Tower
{
    protected override GameObject GetPooledBullet()
    {
        GameObject go = ObjectPool.SharedInstance.GetPooledObject("ArrowBullet");
        return go;
    }

    protected override void Start()
    {
        //cooldown = 0.1f;
        //range = 7;
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }
    /// <summary>
    /// Rotate arrow to enemy's direction
    /// </summary>
    /// <param name="gameObject"></param>
    /// <param name="destination"></param>
    protected override void RotateBullet(GameObject gameObject, Vector3 towerPosition,Vector3 destination)
    {
        Vector3 direction = destination - towerPosition;
        //if (direction.y < 0) { angle *= -1; }
        //gameObject.transform.Rotate(Vector3.forward, angle);

        ArrowBullet arrowBullet = gameObject.gameObject.GetComponent<ArrowBullet>();
        float arrowDirection = arrowBullet.ArrowDirection;
        Vector3 arrowDirectionInVector = new Vector3(Mathf.Cos(Mathf.PI * arrowDirection / 180), Mathf.Sin(Mathf.PI * arrowDirection / 180), 0);
        float angle = Vector3.Angle(arrowDirectionInVector, direction);
        gameObject.transform.Rotate(Vector3.forward, angle);
        arrowBullet.ArrowDirection = Vector3.Angle(Vector3.up,direction);
    }
}
