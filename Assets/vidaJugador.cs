using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidaJugador : MonoBehaviour
{
    public int daño = 20;
    public Slider slider;
    public int life = 100;


    private void Update()
    {
        slider.value = life;
    }

    public void RecibirDaño(int Damage)
    {
        life -= daño;

        if (life <= 0)
        {
            //GameManager.Instance.ShowGameOverScreen();
        }

    }

    public void AgregarVida(int cantidad)
    {
        life += cantidad;
        // Aquí puedes agregar lógica adicional, como límites de vida máxima, efectos visuales, etc.
    }
}
