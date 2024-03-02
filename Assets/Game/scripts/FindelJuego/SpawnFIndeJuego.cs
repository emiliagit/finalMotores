using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFIndeJuego : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject objectToSpawn; 

    void Start()
    {
        // Instancia el objeto en la posición del objeto vacío
        Instantiate(objectToSpawn, spawnPoint.position, Quaternion.identity);
    }
}
