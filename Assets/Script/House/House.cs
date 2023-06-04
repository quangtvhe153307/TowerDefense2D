using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class House : IntEventInvoker
{
    [SerializeField] public int maxHealth;
    [SerializeField] GameObject healthText;
    public int currentHealth;
    public HealthBar healthBar; 
    GameObject slider;
    //Scene game Over
    [SerializeField] private GameObject overScreen;
    private void Awake()
    {
        overScreen.SetActive(false);
    }
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        slider = GameObject.Find("HealthBar");
        DeactiveSliderHealthBar();
        EventManager.AddListener(EventName.HouseAttackedEvent, TakeDamage);
    }

    public void TakeDamage(int damage){
        currentHealth -= damage;
        Debug.Log("Max health: " + maxHealth + "Current health: " + currentHealth);

        healthBar.SetHealth(currentHealth);
        slider.SetActive(true);
        Invoke("DeactiveSliderHealthBar", 2f);
        if(currentHealth <= 0){
            Debug.Log("Game Over");
            // Invoke event game over here!
            Time.timeScale = 0;
            overScreen.SetActive(true);
        }
         // Update status health
        StatusHealth statusHealth = healthText.GetComponent<StatusHealth>();
        if (statusHealth != null)
        {
            statusHealth.SetStatusHealth(this);
        }
    }
    public void DeactiveSliderHealthBar(){
        slider.SetActive(false);
    }
    
}
