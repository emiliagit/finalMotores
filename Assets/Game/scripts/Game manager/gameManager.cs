using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    [SerializeField] private GameObject GameOverScreen;
    [SerializeField] private GameObject WinScreen;

    public cameraMovement controlCamera;


    public static gameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    private void Start()
    {
        GameOverScreen.SetActive(false);
        WinScreen.SetActive(false);
    }
    public void ShowGameOverScreen()
    {
        GameOverScreen.SetActive(true);
        Time.timeScale = 0f;

        controlCamera.enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ShowWinScreen()
    {
        //WinScreen.SetActive(true);
        

        controlCamera.enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }


    public void MenuPrincipal ()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
    }
}
