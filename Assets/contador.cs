using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class contador : MonoBehaviour
{
    public timer temporizador;
    public int estatuasTotales;
    public int estatuasDesbloqueadas = 0;
    public TextMeshProUGUI textoContador;

    public string enemyTag = "Enemy";

    private void Start()
    {
        ActualizarContador();
        GetTotalEnemies();
    }

    // Llamado cuando una estatua es desbloqueada
    public void EstatuaDesbloqueada()
    {
        estatuasDesbloqueadas++;
        ActualizarContador();
    }

    // Actualiza el texto en pantalla para mostrar la cantidad de estatuas restantes por desbloquear
    private void ActualizarContador()
    {
        int estatuasRestantes = estatuasTotales - estatuasDesbloqueadas;
        if (textoContador != null)
        {
            textoContador.text = "Misiones: " + estatuasRestantes.ToString();
        }
    }

    void UpdateEnemiesCount()
    {
        GameObject[] enemy = GameObject.FindGameObjectsWithTag(enemyTag);
        int totalEnemies = enemy.Length;
        if(totalEnemies < 0 $$ temporizador.restante > 0){

        }
    }
}
