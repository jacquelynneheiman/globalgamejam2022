using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPenny : MonoBehaviour
{
    public GameObject playerCamera;
    public GameObject cutsceneCamera;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>())
        {
            cutsceneCamera.SetActive(true);
            playerCamera.SetActive(false);

            cutsceneCamera.GetComponent<Animator>().SetBool("penny", true);
        }
    }
}
