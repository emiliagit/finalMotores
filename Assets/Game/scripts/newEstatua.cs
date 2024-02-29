using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newEstatua : MonoBehaviour
{
  
    public GameObject objetoNuevo; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(objetoNuevo, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}

