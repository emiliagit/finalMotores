using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyLife : MonoBehaviour
{

    public TextMeshProUGUI healthEnemyText;
    private float health;


    private void Start()
    {
        health = 100;
        UpdateHealthUI();

    }


    // Update is called once per frame
    void Update()
    {
        UpdateHealthUI();
    }

    public void TakeDaño(int daño)
    {
        health -= daño;

        if (health<= 0)
        {
            Destroy(gameObject);
        }

        UpdateHealthUI();

    }

    void UpdateHealthUI()
    {
        health = Mathf.Clamp(health, 0, 100);
        healthEnemyText.text = health.ToString() + "%";
    }
}
