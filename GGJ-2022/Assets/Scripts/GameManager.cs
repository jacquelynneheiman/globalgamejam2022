using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public void StartGame()
    {
        SceneManager.LoadScene("Main");
        // TODO: Load other scenes additively?
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayCredits()
    {
        // TODO: Implement this.
    }
}
