using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newEstatua : MonoBehaviour
{
  
    public GameObject objetoNuevo; // Nuevo objeto que se instanciar� al colisionar

    private void OnCollisionEnter(Collision collision)
    {
        // Verificar si el objeto con el que colisionamos tiene el componente "spawner"
        if (collision.gameObject.TryGetComponent(out spawner spawn))
        {
            // Ejecutar la funci�n Spawn() del componente Spawner
            spawn.Spawn();

            // Destruir el objeto actual
            Destroy(gameObject);

            // Instanciar el objeto nuevo en la misma posici�n y rotaci�n que el objeto actual
            Instantiate(objetoNuevo, transform.position, transform.rotation);
        }
    }
}

