﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene(1);
    }
    public void Level2()
    {
        SceneManager.LoadScene(2);
    }
    public void Level3()
    {
        SceneManager.LoadScene(3);
    }
    public void openMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Levels()
    {
        SceneManager.LoadScene(5);
    }
    public void story()
    {
        SceneManager.LoadScene(6);
    }
    public void QuitGame()
    {
       // Debug.Log("Quit!");
        Application.Quit();
    }
}
