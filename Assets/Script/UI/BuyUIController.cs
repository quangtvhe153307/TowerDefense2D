using System.Collections;
using System.Collections.Generic;
using Assets.Script.Common;
using UnityEngine;

public class BuyUIController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SelectEventManager.AddSelectCPEventListener(HandleSelectCPEvent);
        SelectEventManager.AddselectArcherTowerEventListener(HandleSelectArcherTowerEvent);
    }


    void HandleSelectCPEvent(GameObject gameObject)
    {
        Common.showCPInterface("CP", GameObject.Find("UI/BuyUI"), gameObject);
    }
    void HandleSelectArcherTowerEvent(GameObject gameObject, int level)
    {
        Common.showCPInterface("ArcherLevel" + level, GameObject.Find("UI/BuyUI"), gameObject);
    }
}
