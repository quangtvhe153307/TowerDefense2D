using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class SelectEventManager 
{
    static CPController selectCPEventInvoker;
    static UnityAction<GameObject> selectCPEventListener;
    static ArcherTower selectArcherTowerEventInvoker;
    static UnityAction<GameObject, int> selectArcherTowerEventListener;
    public static void AddSelectCPEventInvoker(CPController invoker)
    {
        selectCPEventInvoker = invoker;
        if (selectCPEventListener != null)
        {
            selectCPEventInvoker.AddSelectCPEventListener(selectCPEventListener);
        }
    }
    public static void AddSelectCPEventListener(UnityAction<GameObject> listener)
    {
        selectCPEventListener = listener;
        if (selectCPEventInvoker != null)
        {
            selectCPEventInvoker.AddSelectCPEventListener(listener);
        }
    }

    public static void AddSelectArcherTowerEventInvoker(ArcherTower invoker)
    {
        selectArcherTowerEventInvoker = invoker;
        if (selectArcherTowerEventListener != null)
        {
            selectArcherTowerEventInvoker.AddSelectCPEventListener(selectArcherTowerEventListener);
        }
    }
    public static void AddselectArcherTowerEventListener(UnityAction<GameObject, int> listener)
    {
        selectArcherTowerEventListener = listener;
        if (selectArcherTowerEventInvoker != null)
        {
            selectArcherTowerEventInvoker.AddSelectCPEventListener(listener);
        }
    }
}
