using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tower : MonoBehaviour, ITower
{
    [SerializeField]
    protected float cooldown;
    [SerializeField]
    protected float range;

    protected Timer shootCoolDownTimer;
    protected GameObject _target;

    public float Range
    {
        get { return range; }
    }
    [SerializeField]
    protected int Price;
    [SerializeField]
    protected int towerLevel;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        shootCoolDownTimer= gameObject.AddComponent<Timer>();
        shootCoolDownTimer.Duration = cooldown;
        shootCoolDownTimer.Run();
        transform.Find("SelectCircle").gameObject.SetActive(false);
    }

    // Update is called once per frame
    protected virtual void Update()
    {   
        if(_target != null)
        {
            if (!CheckInRange(_target))
            {
                _target = null;
            }
        }
        if(_target == null)
        {
            _target = WaveManager.GetTarget(this);
        }
        if (shootCoolDownTimer.Finished && _target != null)
        {
            GameObject go = GetPooledBullet();
            go.SetActive(true);
            Bullet bullet = go.GetComponent<Bullet>();
            bullet.SetTarget(_target);
            RotateBullet(go, this.gameObject.transform.position, _target.transform.position);
            go.transform.position = this.gameObject.transform.position;
            shootCoolDownTimer.Run();
        }
    }
    /// <summary>
    /// Check if target is in range of a tower
    /// </summary>
    /// <param name="target"></param>
    /// <returns></returns>
    private bool CheckInRange(GameObject target)
    {
        if(Vector3.SqrMagnitude(transform.position - target.transform.position) <= range * range)
        {
            return true;
        }
        return false;
    }
    protected abstract GameObject GetPooledBullet();
    protected virtual void OnMouseDown(){
        if (GameObject.Find("SelectCircle"))
        {
            GameObject.Find("SelectCircle").gameObject.SetActive(false);
        }
        transform.Find("SelectCircle").gameObject.SetActive(true);
    }

    protected virtual void RotateBullet(GameObject gameObject, Vector3 towerPosition ,Vector3 destination)
    {
    }
}
