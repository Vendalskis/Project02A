using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    
	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);

        }
	}

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void OnTriggerEnter(Collider hit)
    {
        if(hit.gameObject.tag == "Hazard")
        {
            currentHealth -= 10;
            healthBar.SetHealth(currentHealth);
        }
        
    }
}
