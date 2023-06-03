using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SelectEvent : UnityEvent<GameObject>
{
}
public class SelectTowerEvent : UnityEvent<GameObject, int>
{
}