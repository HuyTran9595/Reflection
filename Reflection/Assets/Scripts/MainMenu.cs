using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Loads TutorialLevel

    }

    public void QuitGame()
    {
        Application.Quit();

    }

    public void Credits()
    {
        SceneManager.LoadScene(2); // Loads Credits Scene
    }

    public void BackButton()
    {
        SceneManager.LoadScene(0); // Loads Main Menu
    }
}
