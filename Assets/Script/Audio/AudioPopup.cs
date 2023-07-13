using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioPopup : MonoBehaviour
{


    public void ClosePopup()
    {
        // Save Data
        Debug.Log("Save");

        GameObject.Find("AudioPopup").SetActive(false);
    }


    
    
}
