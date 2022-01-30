using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLights : MonoBehaviour
{
    public List<Light> lights = new List<Light>();

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>())
        {
            foreach(Light light in lights)
            {
                light.GetComponent<Animator>().SetBool("flicker", true);
            }
        }
    }
}
