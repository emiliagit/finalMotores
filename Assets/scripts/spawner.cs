using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    int minEnemigos = 5;
    int maxEnemigos = 9;

    public float radioMinimo = 10f;
    public float RadioMaximo = 25f;

    public void Spawn ()
    {
        int numEnemigos = Random.Range(minEnemigos, maxEnemigos + 1);

        for (int i = 0; i < numEnemigos; i++)
        {
            generarEnemigos();
        }
    }

    public void generarEnemigos()
    {
        GameObject enemigoPrefab = enemyPrefab[Random.Range(0, enemyPrefab.Length)];

        float angulo = Random.Range(0f, 2f * Mathf.PI);
        float radio = Random.Range(radioMinimo, RadioMaximo);
        float x = transform.position.x + Mathf.Cos(angulo) * radio;
        float z = transform.position.z + Mathf.Sin(angulo) * radio;
        float y = transform.position.z + Random.Range(1f, 10f);

        Vector3 posicionEnemigo = new Vector3 (x, y, z);
        Instantiate(enemigoPrefab, posicionEnemigo, Quaternion.identity);

    }


}
