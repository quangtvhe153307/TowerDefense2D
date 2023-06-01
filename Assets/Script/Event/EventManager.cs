using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Events;

public static class EventManager
{
    //static List<Bullet> invokers = new List<Bullet>();
    //static List<UnityAction<int>> listeners = new List<UnityAction<int>>();

    //public static void AddInvokers(Bullet bullet)
    //{
    //    invokers.Add(bullet);
    //    foreach (var item in listeners)
    //    {
    //        bullet.AddListener(item);
    //    }
    //}
    //public static void AddListeners(UnityAction<int> handler)
    //{
    //    listeners.Add(handler);
    //    foreach (var item in invokers)
    //    {
    //        item.AddListener(handler);
    //    }
    //}

    #region Fields
    static Dictionary<EventName, List<IntEventInvoker>> invokers = new();
    static Dictionary<EventName, List<UnityAction<int>>> listeners = new();

    #endregion

    #region Public methods

    /// <summary>
    /// Initializes the event manager
    /// </summary>
    public static void Initialize()
    {
        // create empty lists for all the dictionary entries
        foreach (EventName name in Enum.GetValues(typeof(EventName)))
        {
            if (!invokers.ContainsKey(name))
            {
                invokers.Add(name, new List<IntEventInvoker>());
                listeners.Add(name, new List<UnityAction<int>>());
            }
            else
            {
                invokers[name].Clear();
                listeners[name].Clear();
            }
        }
    }

    /// <summary>
    /// Adds the given invoker for the given event name
    /// </summary>
    /// <param name="eventName">event name</param>
    /// <param name="invoker">invoker</param>
    public static void AddInvoker(EventName eventName, IntEventInvoker invoker)
    {
        // add listeners to new invoker and add new invoker to dictionary
        foreach (UnityAction<int> listener in listeners[eventName])
        {
            invoker.AddListener(eventName, listener);
        }
        invokers[eventName].Add(invoker);
    }

    /// <summary>
    /// Adds the given listener for the given event name
    /// </summary>
    /// <param name="eventName">event name</param>
    /// <param name="listener">listener</param>
    public static void AddListener(EventName eventName, UnityAction<int> listener)
    {
        // add as listener to all invokers and add new listener to dictionary
        foreach (IntEventInvoker invoker in invokers[eventName])
        {
            invoker.AddListener(eventName, listener);
        }
        listeners[eventName].Add(listener);
    }

    /// <summary>
    /// Removes the given invoker for the given event name
    /// </summary>
    /// <param name="eventName">event name</param>
    /// <param name="invoker">invoker</param>
    public static void RemoveInvoker(EventName eventName, IntEventInvoker invoker)
    {
        // remove invoker from dictionary
        invokers[eventName].Remove(invoker);
    }

    #endregion

}

