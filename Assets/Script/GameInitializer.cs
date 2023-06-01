using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    //void Start()
    //{
    //    EventManager.Initialize();
    //    //ConfigurationUtils.Initialize();
    //    //DifficultyUtils.Initialize();
    //}
    private void Awake()
    {
        EventManager.Initialize();
    }
}

