using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyLife : MonoBehaviour
{

    private int Salud = 100;

    public TextMeshProUGUI healthEnemyText;
    private float health;


    private void Start()
    {
        health = 100;
    }


    // Update is called once per frame
    void Update()
    {
        UpdateHealthUI();
    }

    public void TakeDaño(int daño)
    {
        Salud -= daño;

        if (Salud == 0)
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
