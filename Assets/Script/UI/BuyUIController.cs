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
        SelectEventManager.AddselectKnightTowerEventListener(HandleSelectKnightTowerEvent);
        SelectEventManager.AddselectMagicianTowerEventListener(HandleSelectMagicianTowerEvent);
    }


    void HandleSelectCPEvent(GameObject gameObject)
    {
        Common.showCPInterface("CP", GameObject.Find("UI/BuyUI"), gameObject);
    }
    void HandleSelectArcherTowerEvent(GameObject gameObject, int level)
    {
        HandleShowInterface("Archer", gameObject, level);
    }
    void HandleSelectKnightTowerEvent(GameObject gameObject, int level)
    {
        HandleShowInterface("Knight", gameObject, level);
    }
    void HandleSelectMagicianTowerEvent(GameObject gameObject, int level)
    {
        HandleShowInterface("Magician", gameObject, level);
    }
    void HandleShowInterface(string towerType, GameObject gameObject, int level)
    {
        Common.showCPInterface($"{towerType}Level{level}", GameObject.Find("UI/BuyUI"), gameObject);
    }
}
