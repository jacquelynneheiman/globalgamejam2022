using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scequence_1 : MonoBehaviour
{
    //whispers start playing, getting louder as the player walks closer to the lockers.
    //as they get closer to the lockers, the lights begin to flicker
    //as they reach the a locker slams shut and the lights go out

    //lights go back on, and the player is in the dark level


    //in dark level, a door creaks open near the player.

    public AudioSource whisperAudioSource;

    private void Start()
    {
        whisperAudioSource.Play();
    }

    private void Update()
    {
        
    }

}
