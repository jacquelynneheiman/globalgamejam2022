using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutToBlack : MonoBehaviour
{
    public GameObject black;

    public void GoBlack()
    {
        black.SetActive(true);   
    }
}
