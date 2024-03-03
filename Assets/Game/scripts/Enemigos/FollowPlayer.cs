using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class FollowPlayer : MonoBehaviour
{
    private Transform jugador;
    private float velocidad = 2f;



    GameObject player;

    private float velocidadRotacion = 2f;



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
        // Verificar si el jugador est� asignado
        if (jugador != null)
        {
            // Calcular la direcci�n hacia la posici�n del jugador
            Vector3 direccion = (jugador.position - transform.position).normalized;

            Quaternion rotacionDeseada = Quaternion.LookRotation(direccion);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotacionDeseada, velocidadRotacion * Time.deltaTime);

            // Mover el enemigo en direcci�n al jugador
            transform.Translate(direccion * velocidad * Time.deltaTime);
        }
        else
        {
            Debug.LogWarning("El jugador no est� asignado en el script.");
        }
    }


  

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<vidaJugador>().RecibirDanio(10f);
            Debug.Log("Colision detectada"); 
        }
    }


}
