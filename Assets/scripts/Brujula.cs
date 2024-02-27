using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brujula : MonoBehaviour
{

    public Transform jugador;
    public GameObject[] Misiones;
    public Image brujulaImage;


    void Start()
    {
        if (jugador == null)
        {
            jugador = GameObject.FindGameObjectWithTag("Player").transform;

        }


       BuscarObjetoCercano(); //busca al objeto mas cercano al jugadro al iniciar el juego
    }

    void Update()
    {
        BuscarObjetoCercano();
    }

    void BuscarObjetoCercano()
    {
        float distanciaMinima = Mathf.Infinity; //incializa distancia minima como infinito 
        GameObject ObjetoMasCercano = null;

        //itera a traves de los objetos y encuentra al mas cercano
        foreach (GameObject objeto in Misiones)
        {
            float distancia = Vector3.Distance(jugador.position, objeto.transform.position);
            if (distancia < distanciaMinima)
            {
                distanciaMinima = distancia;
                ObjetoMasCercano = objeto;
            }
        }

        if (ObjetoMasCercano != null)
        {

            //calcula direccion hacia el objeto mas cercano
            Vector3 direccion = (ObjetoMasCercano.transform.position - jugador.position).normalized;
            float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg - 90;

            //actualiza la rotacion de la brujula 
            //BrujulaUI.rotation = Quaternion.Euler(0, 0, angulo);
        }
    }

    //private void ApuntarHaciaTotemMasCercano()
    //{
    //    if (targetTotem != null && brujulaImage != null)
    //    {
    //        Vector3 direction = (targetTotem.position - player.position).normalized;
    //        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
    //        brujulaImage.rectTransform.rotation = Quaternion.Euler(0, 0, angle);
    //    }
    //}


}
