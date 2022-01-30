using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandUp : MonoBehaviour
{
    public AudioSource deskThrow;
    public AudioSource wtf;
    public Animator animator;
    public float standDelay;
    public float soundDelay = 3.5f;

    public void Stand()
    {
        StartCoroutine(StandCo());
    }

    IEnumerator StandCo()
    {
        yield return new WaitForSeconds(standDelay);
        if (wtf != null)
        {
            if (!wtf.isPlaying)
            {
                wtf.Play();
            }
        }
        if (deskThrow != null)
        {
            deskThrow.PlayDelayed(soundDelay);
        }
        animator.SetBool("stand", true);
    }
}
