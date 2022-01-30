using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        yield return new WaitForSeconds(2f);

        
    }

}
