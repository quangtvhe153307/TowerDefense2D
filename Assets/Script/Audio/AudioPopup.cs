using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioPopup : MonoBehaviour
{
    public Button btnSaveVolume;
    public GameObject menuGameObject;
    public GameObject popupObject;
    void Start()
    {

        btnSaveVolume.onClick.AddListener(ClosePopup);
    }

    public void ClosePopup()
    {
        popupObject.SetActive(false);
        menuGameObject.SetActive(true);
    }
}
