using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerDoorSlam : MonoBehaviour
{
    public List<Light> lights = new List<Light>();
    public GameObject camOverlay;

    public Animator lockerDoorAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>())
        {
            lockerDoorAnimator.SetBool("slam", true);

            StartCoroutine(StopFlicker());
        }
    }

    IEnumerator StopFlicker()
    {
        yield return new WaitForSeconds(10f);

        foreach (Light light in lights)
        {
            light.GetComponent<Animator>().SetBool("flicker", false);
        }
    }
}
