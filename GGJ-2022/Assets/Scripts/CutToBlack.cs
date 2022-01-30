using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutToBlack : MonoBehaviour
{
    public GameObject black;

    public void GoBlack()
    {
        black.SetActive(true);

        StartCoroutine(DarkMode());
    }

    IEnumerator DarkMode()
    {
        //play dark world sounds

        //teleport player into dark hallway

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("DarkSchool");
        
    }

}
