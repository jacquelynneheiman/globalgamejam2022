using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator doorAnimator;

    public void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>())
        {
            doorAnimator.SetBool("open", true);
        }
    }
}
