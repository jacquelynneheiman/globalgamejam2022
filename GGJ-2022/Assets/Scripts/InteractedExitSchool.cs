using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractedExitSchool : MonoBehaviour, IInteractible
{
    bool interacted = false;
    [SerializeField] AudioClip warningClip;
    public enum EndingType { BAD_ENDING, GOOD_ENDING }

    public void Interact()
    {
        if (GameManager.Instance.beatGame)
        {
            EndGame(EndingType.GOOD_ENDING);
        }
        else
        {
            if (interacted)
            {
                EndGame(EndingType.BAD_ENDING);
            }
            else
            {
                WarnPlayer();
                interacted = true;
            }
        }
    }

    private void WarnPlayer()
    {
        if (warningClip != null)
        {
            AudioSource.PlayClipAtPoint(warningClip, transform.position);
        }
    }

    private void EndGame(EndingType ending)
    {
        switch (ending)
        {
            case EndingType.BAD_ENDING:
                SceneManager.LoadScene("GameOver");
                Debug.Log("Bad end");
                break;
            case EndingType.GOOD_ENDING:
                // TODO: implement good ending
                Debug.Log("Good end");
                break;
            default:
                Debug.LogWarning("That case doesn't exist");
                break;
        }
    }
}
