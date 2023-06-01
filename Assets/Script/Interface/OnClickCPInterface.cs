using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnClickCPInterface : MonoBehaviour
{
    [SerializeField] TowerFactory[] factories;
    private TowerFactory factory;
    private GameObject selectedCP;
    public void Initialize(GameObject selected){
        selectedCP = selected;
    }
    void Start()
    {
        factory = factories[0];
    }
    void Update()
    {
    }
    void OnMouseDown()
    {
        createTowerLevel1();
    }
    void createTowerLevel1()
    {
        InstantiateTower();
        Invoke("onDestroy", 0);
    }
    private void onDestroy()
    {
        Destroy(this.gameObject.transform.parent.gameObject);
        Destroy(selectedCP.gameObject);
    }
    private void InstantiateTower()
    {
        Vector3 cpos = selectedCP.transform.position;
        cpos.y = cpos.y + 0.1f;
        ITower tower = factory.CreateTower("archer", 1, cpos);
    }
}
