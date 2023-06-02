using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : IntEventInvoker
{
    [SerializeField] public int maxHealth;
    public int currentHealth;
    public HealthBar healthBar; 
    GameObject slider; 
    // Start is called before the first frame update
    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        slider = GameObject.Find("HealthBar");
        DeactiveSliderHealthBar();
        EventManager.AddListener(EventName.HouseAttackedEvent, TakeDamage);

    }

    // Update is called once per frame
    // void Update()
    // {
    //    if(Input.GetKeyDown(KeyCode.Space)){
    //         TakeDamage(10);
    //         slider.SetActive(true);
    //         Invoke("DeactiveSliderHealthBar", 2f);
    //     }
    // }

    public void TakeDamage(int damage){
        currentHealth -= damage;
        Debug.Log("Current Health House: " + currentHealth);
        healthBar.SetHealth(currentHealth);
        slider.SetActive(true);
        Invoke("DeactiveSliderHealthBar", 2f);
        if(currentHealth <= 0){
            Debug.Log("Game Over");
            // Invoke event game over here!
            Time.timeScale = 0;
        }
    }
    public void DeactiveSliderHealthBar(){
        slider.SetActive(false);
    }
}
