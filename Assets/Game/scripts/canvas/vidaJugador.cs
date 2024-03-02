using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class vidaJugador : MonoBehaviour
{
    public Slider slider;
    public int life = 100;

    public TextMeshProUGUI hpText;



    private void Update()
    {
        slider.value = life;
    }

    public void RecibirDanio(int dmg)
    {
        life -= dmg;
        UpdateHealthUI();


        if (life <= 0)
        {
            gameManager.Instance.ShowGameOverScreen();
        }
    }

    //public void RecibirDa�o(int da�o)
    //{
    //    life -= da�o;
    //    Debug.Log("Vida restada");
    //    UpdateHealthUI();



    //}

    void UpdateHealthUI()
    {
        life = Mathf.Clamp(life, 0, 100);
        slider.value = life;
        hpText.text = life.ToString() + "%";
    }

    //public void AgregarVida(int cantidad)
    //{
    //    life += cantidad;
    //    // Aqu� puedes agregar l�gica adicional, como l�mites de vida m�xima, efectos visuales, etc.
    //}
}
