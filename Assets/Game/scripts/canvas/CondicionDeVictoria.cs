using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CondicionDeVictoria : MonoBehaviour
{

    public timer temporizador;
    public contador Contador;

    private int totalEnemies;
    private int enemiesEliminated;

    private void Start()
    {
        //totalEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;

    }

    public void EnemiesEliminated()
    {
        enemiesEliminated++;

        if (temporizador.restante > 0 && Contador.GetTotalTotems() == 0)
        {

            //gameManager.Instance.ShowWinScreen();
            SpawnFIndeJuego spawnFinDeJuego = FindObjectOfType<SpawnFIndeJuego>();

            if (spawnFinDeJuego != null)
            {
                spawnFinDeJuego.enabled = true;
            }

        }
    }

    
}
