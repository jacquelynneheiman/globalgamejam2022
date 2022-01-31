using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public bool beatGame = false;

    public bool IsPaused
    {
        get
        {
            return Mathf.Approximately(Time.timeScale, 0f);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("DaySchool");
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

    public void TogglePause()
    {
        if (IsPaused)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }
}
