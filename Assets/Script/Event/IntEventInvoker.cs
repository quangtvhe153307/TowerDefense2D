using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class IntEventInvoker : MonoBehaviour
{
    protected Dictionary<EventName, UnityEvent<int>> unityEvents =
        new Dictionary<EventName, UnityEvent<int>>();
    /// <summary>
    /// Adds the given listener for the given event name
    /// </summary>
    /// <param name="eventName"></param>
    /// <param name="listener"></param>
    public void AddListener(EventName eventName, UnityAction<int> listener)
    {
        // only add listeners for supported events
        if (unityEvents.ContainsKey(eventName))
        {
            unityEvents[eventName].AddListener(listener);
        }
    }
}
