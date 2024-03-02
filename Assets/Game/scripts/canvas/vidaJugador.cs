using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class vidaJugador : MonoBehaviour
{
    //public Slider slider;
    //public int life = 100;

    //public TextMeshProUGUI hpText;



    //private void Update()
    //{
    //    slider.value = life;
    //}

    //public void RecibirDanio(int dmg)
    //{
    //    life -= dmg;
    //    UpdateHealthUI();


    //    if (life <= 0)
    //    {
    //        gameManager.Instance.ShowGameOverScreen();
    //    }
    //}

    ////public void RecibirDaño(int daño)
    ////{
    ////    life -= daño;
    ////    Debug.Log("Vida restada");
    ////    UpdateHealthUI();



    ////}

    //void UpdateHealthUI()
    //{
    //    life = Mathf.Clamp(life, 0, 100);
    //    slider.value = life;
    //    hpText.text = life.ToString() + "%";
    //}

    //public void AgregarVida(int cantidad)
    //{
    //    life += cantidad;
    //    // Aquí puedes agregar lógica adicional, como límites de vida máxima, efectos visuales, etc.
    //}

    public Slider healthSlider;
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
        healthSlider.value = hp;
        hpText.text = hp.ToString() + "%";
    }
}
