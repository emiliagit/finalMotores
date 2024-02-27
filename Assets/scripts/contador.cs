using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class contador : MonoBehaviour
{
    public int estatuasTotales;
    public int estatuasDesbloqueadas = 0;
    public TextMeshProUGUI textoContador;

    public float estatuasRestantes;

    public string enemyTag = "Enemy";

    private void Start()
    {

        EstatuaDesbloqueada();
        //ActualizarContador();
    }

    // Llamado cuando una estatua es desbloqueada
    public void EstatuaDesbloqueada()
    {
        estatuasDesbloqueadas++;
        ActualizarContador();
    }

    // Actualiza el texto en pantalla para mostrar la cantidad de estatuas restantes por desbloquear
    public void ActualizarContador()
    {
        estatuasRestantes = estatuasTotales - estatuasDesbloqueadas;
        if (textoContador != null)
        {
            textoContador.text = "Misiones: " + estatuasRestantes.ToString();
        }
    }

}
