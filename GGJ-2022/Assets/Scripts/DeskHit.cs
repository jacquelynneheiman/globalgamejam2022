using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeskHit : MonoBehaviour
{
    public GameObject overlay;

    void Hit()
    {
        overlay.SetActive(true);

        SceneManager.LoadScene("GameOver");
    }
}
