using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusHealth : MonoBehaviour
{
    [SerializeField]
    private GameObject houseGameObject;
    private Text healthText;
    void Start()
    {
        healthText = GetComponent<Text>();

        //Get House Object
        House house = houseGameObject.GetComponent<House>();
        healthText.text = house.currentHealth.ToString() + "/" + house.maxHealth.ToString();
    }

    public void SetStatusHealth(House house)
    {
        healthText.text = house.currentHealth.ToString() + "/" + house.maxHealth.ToString();
    }
    
}
