using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidaJugador : MonoBehaviour
{
    public int da�o = 20;
    public Slider slider;
    public int life = 100;


    private void Update()
    {
        slider.value = life;
    }

    public void RecibirDa�o(int Damage)
    {
        life -= da�o;

        if (life <= 0)
        {
            //GameManager.Instance.ShowGameOverScreen();
        }

    }

    public void AgregarVida(int cantidad)
    {
        life += cantidad;
        // Aqu� puedes agregar l�gica adicional, como l�mites de vida m�xima, efectos visuales, etc.
    }
}
