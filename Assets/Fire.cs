using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public float velocidad = 10f; // Velocidad del proyectil
    public float tiempoVida = 2f; // Tiempo de vida antes de autodestruirse
    public GameObject efectoImpacto; // Prefab del efecto al impactar

    private void Start()
    {
        // Aplicamos una velocidad inicial al proyectil
        GetComponent<Rigidbody>().velocity = transform.forward * velocidad;

        // Destruimos el proyectil después de un tiempo
        Destroy(gameObject, tiempoVida);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Si colisionamos con algo, instanciamos el efecto de impacto
        if (efectoImpacto != null)
        {
            Instantiate(efectoImpacto, transform.position, Quaternion.identity);
        }

        // Destruimos el proyectil al impactar
        Destroy(gameObject);
    }
}
