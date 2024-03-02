using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            vidaJugador vidaJugador = collision.gameObject.GetComponent<vidaJugador>();

            if (vidaJugador != null)
            {
                vidaJugador.Curar(3);

                Destroy(gameObject);
            }
        }
    }

   
}
