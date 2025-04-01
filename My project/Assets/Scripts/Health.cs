using System;
using UnityEngine;

public class Health : MonoBehaviour
{
   [SerializeField] private float maxHealth;

   public GameObject player;

   private float currentHealth;

   public HealthBar healthbar;

   public bool PlayerIsDead;

   public GameObject DeathScreen;

   public GameObject ActiveUI;

   

   private void Start()
    {
         if (maxHealth <= 0)
        {
             Debug.LogError("maxHealth is not set or is <= 0. Assign a proper value in the Inspector.");
            maxHealth = 100; // Assign a default value to prevent issues
        }

        currentHealth = maxHealth;
         healthbar.SetSliderMax(maxHealth);
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        healthbar.SetSlider(currentHealth);
    }

    private void Update()
    {
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        if (currentHealth <= 1)
        {
            Die();
        }

        if (PlayerIsDead == true)
        {
            DeathScreen.SetActive(true);
            ActiveUI.SetActive(false);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

     void Die()
    {
        PlayerIsDead = true;
        player.SetActive(false);
        Debug.Log("Player died.");
    }
}
