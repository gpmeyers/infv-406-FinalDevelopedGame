using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
    // This function will be called when the user selects the play button at the main menu and will begin the game
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // This function will be called when the user selects the quit button at the main menu and will end the application
    public void QuitGame()
    {
        Application.Quit();
    }

}
