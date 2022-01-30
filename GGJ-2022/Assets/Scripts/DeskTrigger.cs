using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskTrigger : MonoBehaviour
{
    public Animator deskAnimator;

    public void ThrowDesk()
    {
        deskAnimator.SetBool("throw", true);
    }
}
