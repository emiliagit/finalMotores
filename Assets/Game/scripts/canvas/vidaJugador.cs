using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidaJugador : MonoBehaviour
{
    public int da�o = 10;
    public Slider slider;
    public int life = 100;


    private void Update()
    {
        slider.value = life;
    }

    public void RecibirDa�o()
    {
        life -= da�o;

        if (life <= 0)
        {
            gameManager.Instance.ShowGameOverScreen();
        }

    }

    public void AgregarVida(int cantidad)
    {
        life += cantidad;
        // Aqu� puedes agregar l�gica adicional, como l�mites de vida m�xima, efectos visuales, etc.
    }
}
