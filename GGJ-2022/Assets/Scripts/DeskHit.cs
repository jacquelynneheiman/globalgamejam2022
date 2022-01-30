using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeskHit : MonoBehaviour
{
    public GameObject desk;
    public GameObject overlay;

    void Hit()
    {
        overlay.SetActive(true);
        desk.SetActive(false);
        SceneManager.LoadScene("GameOver");
    }
}
