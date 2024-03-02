using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class FollowPlayer : MonoBehaviour
{
    private Transform jugador;
    private float velocidad = 2f;

    //private vidaJugador VidaPlayer;


    GameObject player;

    private int Salud = 100;


    void Update()
    {
        DireccionEnemigo();
    }

    private void Awake()
    {
        {

            player = GameObject.FindGameObjectWithTag("Player");
            jugador = player.transform;
        }
    }

    public void DireccionEnemigo()
    {
        // Verificar si el jugador está asignado
        if (jugador != null)
        {
            // Calcular la dirección hacia la posición del jugador
            Vector3 direccion = (jugador.position - transform.position).normalized;

            // Mover el enemigo en dirección al jugador
            transform.Translate(direccion * velocidad * Time.deltaTime);
        }
        else
        {
            Debug.LogWarning("El jugador no está asignado en el script.");
        }
    }


    public void TakeDaño(int daño)
    {
        Salud -= daño;

        if (Salud == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            vidaJugador vidaPlayer = collision.gameObject.GetComponent<vidaJugador>();
            Debug.Log("Colision detectada");
            vidaPlayer.RecibirDanio(10);
        }
    }


}
