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
    static KnightTower selectKnightTowerEventInvoker;
    static UnityAction<GameObject, int> selectKnightTowerEventListener;
    static MagicianTower selectMagicianTowerEventInvoker;
    static UnityAction<GameObject, int> selectMagicianTowerEventListener;
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
    // Archer Tower
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
    // Knight Tower
    public static void AddSelectKnightTowerEventInvoker(KnightTower invoker)
    {
        selectKnightTowerEventInvoker = invoker;
        if (selectKnightTowerEventListener != null)
        {
            selectKnightTowerEventInvoker.AddSelectCPEventListener(selectKnightTowerEventListener);
        }
    }
    public static void AddselectKnightTowerEventListener(UnityAction<GameObject, int> listener)
    {
        selectKnightTowerEventListener = listener;
        if (selectKnightTowerEventInvoker != null)
        {
            selectKnightTowerEventInvoker.AddSelectCPEventListener(listener);
        }
    }
    
    // Magician Tower
    public static void AddSelectMagicianTowerEventInvoker(MagicianTower invoker)
    {
        selectMagicianTowerEventInvoker = invoker;
        if (selectMagicianTowerEventListener != null)
        {
            selectMagicianTowerEventInvoker.AddSelectCPEventListener(selectMagicianTowerEventListener);
        }
    }
    public static void AddselectMagicianTowerEventListener(UnityAction<GameObject, int> listener)
    {
        selectMagicianTowerEventListener = listener;
        if (selectMagicianTowerEventInvoker != null)
        {
            selectMagicianTowerEventInvoker.AddSelectCPEventListener(listener);
        }
    }
}
