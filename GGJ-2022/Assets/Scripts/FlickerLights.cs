using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLights : MonoBehaviour
{
    AudioSource lightHum;
    public List<Light> lights = new List<Light>();

    private void Start()
    {
        lightHum = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>())
        {
            if (lightHum != null)
            {
                if (!lightHum.isPlaying)
                {
                    lightHum.Play();
                }
            }
            foreach(Light light in lights)
            {
                light.GetComponent<Animator>().SetBool("flicker", true);
            }
        }
    }
}
