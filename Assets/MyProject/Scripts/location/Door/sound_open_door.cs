using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_open_door : MonoBehaviour
{
    private AudioSource audio;
 
    void Sound_open_door()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
    }
}
