using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellButtonController : ButtonInterface
{
    [SerializeField]
    private GameObject prefab;
    void OnMouseDown()
    {
        InstantiateCP();
        Invoke("onDestroy", 0);
    }
    private void InstantiateCP()
    {
        Vector3 cpos = SelectedTower.transform.position;
        GameObject instance = Instantiate(prefab, cpos, Quaternion.identity);
        instance.transform.SetParent(GameObject.Find("CPs").transform);
    }
}
