using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandUp : MonoBehaviour
{
    public Animator animator;
    public float standDelay;

    public void Stand()
    {
        StartCoroutine(StandCo());
    }

    IEnumerator StandCo()
    {
        yield return new WaitForSeconds(standDelay);

        animator.SetBool("stand", true);
    }
}
