using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusHealth : MonoBehaviour
{
    public Text healthText;
    void Start()
    {
        healthText = GetComponent<Text>();
    }

    public void SetStatusHealth(House house)
    {
        healthText.text = house.currentHealth.ToString() + "/" + house.maxHealth.ToString();
    }
    
}
