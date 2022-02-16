using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneMnger : MonoBehaviour
{
    private bool gameStart = false;
    private bool AboutScene = false;
    //private bool MainMenuScreen = false;
    public void PlayGame()
    {   if (gameStart == false)
        {
            SceneManager.LoadScene("Game");
            gameStart = true;
        }
    }
    public void About()
    {     
        if (AboutScene == false)
        {
            SceneManager.LoadScene("About");
            AboutScene = true;
        }
    }
    public void MainMenu()
    {      
        SceneManager.LoadScene("MainMenu");         
    }
}
