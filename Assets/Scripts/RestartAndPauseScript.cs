using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartAndPauseScript : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] GameObject pauseScreen;

    private void Start()
    {
        Time.timeScale = 1.0f;
        pauseScreen.SetActive(false);
        gameOverScreen.SetActive(false);
    }
    private void Update()
    {
        PauseMethod();
    }

    private void PauseMethod()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pauseScreen.SetActive(true);
            }
            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                pauseScreen.SetActive(false);
            }
        }
    }

    public void GameOverMethod()
    {
        Time.timeScale = 0;
        gameOverScreen.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
