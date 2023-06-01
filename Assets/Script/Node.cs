using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// Class represent for node in the path of the game
/// </summary>
public class Node
{
    /// <summary>
    /// squared distance to the next node in the path
    /// </summary>
    public float CostToTheEnd { get; set; }
    public Vector3 Position { get; set; }
}