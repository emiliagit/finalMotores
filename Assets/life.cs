using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    public int cantidadDeVida = 10; // La cantidad de vida que se agregará al jugador

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto colisionado es el jugador 
        if (other.CompareTag("Player"))
        {
            // Obtener el componente de vida del jugador
            vidaJugador vidaJugador = other.GetComponent<vidaJugador>();

            // Asegurarse de que el componente de vida del jugador existe
            if (vidaJugador != null)
            {
                // Incrementar la vida del jugador
                vidaJugador.AgregarVida(cantidadDeVida);

                // destruir el objeto: Destroy(gameObject);
                Destroy(gameObject);
            }
        }
    }
}
