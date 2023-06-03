using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class ArcherTower : Tower
{
    protected override void Start()
    {
        gameObject.name = $"ArcherLevel{towerLevel}";
        SelectEventManager.AddSelectArcherTowerEventInvoker(this);
        //cooldown = 0.1f;
        //range = 7;
        base.Start();
    }
    protected override GameObject GetPooledBullet()
    {
        GameObject go = ObjectPool.SharedInstance.GetPooledObject("ArrowBullet");
        return go;
    }
    protected override void RotateBullet(GameObject gameObject, Vector3 towerPosition,Vector3 destination)
    {   
        //new direction of arrow
        Vector3 direction = destination - towerPosition;
        float directionInAngle = ConvertTo360DegreeSystem(direction);

        //Arrow component
        ArrowBullet arrowBullet = gameObject.gameObject.GetComponent<ArrowBullet>();
        float arrowDirection = arrowBullet.ArrowDirection;

        //Calculate relative angle to rotate
        float relativeAngle = directionInAngle - arrowDirection;

        //rotate
        gameObject.transform.Rotate(Vector3.forward, relativeAngle);

        //Set new angle to arrow object
        arrowBullet.ArrowDirection = directionInAngle;
    }
    private float ConvertTo360DegreeSystem(Vector3 vector)
    {
        float degree = Vector3.Angle(vector, Vector3.right);
        if(vector.y < 0)
        {
            return 360 - degree;
        }
        return degree;
    }
}
