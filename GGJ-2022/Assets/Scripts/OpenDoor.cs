using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public AudioSource doorOpening;
    public Animator doorAnimator;


    public void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>())
        {
            if (doorOpening != null)
            {
                if (!doorOpening.isPlaying)
                {
                    doorOpening.Play();
                }
            }
            doorAnimator.SetBool("open", true);
        }
    }
}
