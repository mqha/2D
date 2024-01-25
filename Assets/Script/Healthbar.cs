using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    Character player;
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar;

    void Start()
    {
        player = Init.player;
        UpdateHealthBar();
        //totalHealthBar.fillAmount = playerHealth.currentHealth/3;
    }

    
    void Update()
    {
        UpdateHealthBar();
        //currentHealthBar.fillAmount = playerHealth.currentHealth/3;
    }

    private void UpdateHealthBar()
    {
        if (player != null)
        {
            // Ensure that the division is done correctly by casting to float
            float maxHealth = 3f;
            totalHealthBar.fillAmount = player.health.GetCurrentHealth() / maxHealth;
            currentHealthBar.fillAmount = player.health.GetCurrentHealth() / maxHealth;
        }
    }
}
