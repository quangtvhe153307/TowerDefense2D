using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Tower : MonoBehaviour, ITower
{
    public int damage;
    public float cooldown;
    public float range;
    protected Timer shootCoolDownTimer;
    protected GameObject _target;
    public float Range
    {
        get { return range; }
    }
    [SerializeField]
    public int Price;
    [SerializeField]
    public int towerLevel;
    protected SelectTowerEvent selectEvent = new SelectTowerEvent();
    protected virtual void Start()
    {
        shootCoolDownTimer= gameObject.AddComponent<Timer>();
        shootCoolDownTimer.Duration = cooldown;
        shootCoolDownTimer.Run();
        transform.Find("SelectCircle").gameObject.SetActive(false);
    }
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
            bullet.SetDamage(this.damage);
            RotateBullet(go, this.gameObject.transform.position, _target.transform.position);
            go.transform.position = this.gameObject.transform.position;
            shootCoolDownTimer.Run();
            PlaySound();
        }
    }
    public void AddSelectCPEventListener(UnityAction<GameObject, int> listener)
    {
        selectEvent.AddListener(listener);
    }
    private bool CheckInRange(GameObject target)
    {
        if (!target.activeInHierarchy) return false;
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
        selectEvent.Invoke(this.gameObject, towerLevel);
    }

    protected virtual void RotateBullet(GameObject gameObject, Vector3 towerPosition ,Vector3 destination)
    {
    }
    protected virtual void PlaySound()
    {

    }
}
