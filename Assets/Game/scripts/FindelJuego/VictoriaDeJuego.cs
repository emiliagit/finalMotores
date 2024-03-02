using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VictoriaDeJuego : MonoBehaviour
{

    public KeyCode targetKey = KeyCode.E;

    public float requiredHoldTime = 3.0f;

    private float currentHoldTime = 0.0f;
    private bool victoryAchieved = false;





    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(targetKey))
        {
            currentHoldTime += Time.deltaTime;

            // Si se mantiene presionada durante el tiempo requerido, activa la victoria
            if (currentHoldTime >= requiredHoldTime && !victoryAchieved)
            {
                victoryAchieved = true;
                gameManager.Instance.ShowWinScreen();
            }
        }
        else
        {
            // Reinicia el contador si la tecla se suelta antes de tiempo
            currentHoldTime = 0.0f;
        }

    }

  


}

