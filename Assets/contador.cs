using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contador : MonoBehaviour
{
    public int estatuasTotales; 
    public int estatuasDesbloqueadas = 0; 
    public Text textoContador;

    private void Start()
    {
        ActualizarContador();
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
            textoContador.text = "Estatuas restantes: " + estatuasRestantes.ToString();
        }
    }
}
