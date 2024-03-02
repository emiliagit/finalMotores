using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    public int cantidadDeVida = 3; // La cantidad de vida que se agregará al jugador

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Fire"))
        {
            // Obtener el componente de vida del jugador
            vidaJugador vidaJugador = collision.gameObject.GetComponent<vidaJugador>();

            // Asegurarse de que el componente de vida del jugador existe
            if (vidaJugador != null)
            {
                // Incrementar la vida del jugador
                //vidaJugador.AgregarVida(cantidadDeVida);

                // destruir el objeto: Destroy(gameObject);
                Destroy(gameObject);
            }
        }
    }

   
}
