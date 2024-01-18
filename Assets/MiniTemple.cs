using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniTemple : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto colisionado es el jugador (ajusta seg�n tus necesidades)
        if (other.CompareTag("<Player"))
        {
            // Activar el spawner de enemigos
            if (spawnerEnemigos != null)
            {
                spawnerEnemigos.SetActive(true);
            }

            // Opcional: Puedes desactivar o destruir el objeto actual despu�s de la colisi�n
            gameObject.SetActive(false);
        }
    }
}
