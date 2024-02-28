using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerMainMenu : MonoBehaviour
{
    public GameObject tutorialCanvas;

    private bool tutorialActive = false;



    public void PlayButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void tutorialButton()
    {
        tutorialCanvas.SetActive(true);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void ContinuarButton()
    {
        SceneManager.LoadScene("GameScene");
    }
}
