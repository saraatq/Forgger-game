using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class pause : MonoBehaviour
{
    public static bool GameIsPaused = false; 
    public GameObject PauseUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pausee();
            }
        }
        
    }
    public void Resume()
    {
            PauseUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
    }

    void Pausee()
    {
            PauseUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
    }
    public void openMenu()
    {
        SceneManager.LoadScene(0);
    }
}
