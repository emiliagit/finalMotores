using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class vidaJugador : MonoBehaviour
{
    

    public TextMeshProUGUI hpText;
    private float hp;


    private void Start()
    {
        hp = 100;
        UpdateHealthUI();
    }

    private void Update()
    {

        if (hp > 100)
        {
            hp = 100; //pone limite a la cantidad de vida
        } 

        if ( hp <= 0 )
        {
            gameManager.Instance.ShowGameOverScreen();
        }
        UpdateHealthUI();


    }

    public void RecibirDanio(float dmg)
    {
        hp -= dmg;
        UpdateHealthUI();
    }

    public void Curar(float heal)
    {
        hp += heal;
        UpdateHealthUI();
    }

    void UpdateHealthUI()
    {
        hp = Mathf.Clamp(hp, 0, 100);
        hpText.text = "LIfe: " + hp.ToString() + "%";
    }
}
