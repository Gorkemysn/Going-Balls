using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;


public class UIMain : MonoBehaviour
{
    [Header("UIPages")]
    public GameObject settingsScreen;
    public GameObject mainScreen;

    public void StartGame()
    {
        Application.LoadLevel("Level1");
    }
    public void Settings()
    {
        mainScreen.SetActive(false);
        settingsScreen.SetActive(true);
    }

    public void set2Menu()
    {
        mainScreen.SetActive(true);
        settingsScreen.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit(); 
    }

    public void MainMenu()
    {
        Application.LoadLevel("Main Menu");
    }
}
