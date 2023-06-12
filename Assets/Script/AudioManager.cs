using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{

    public Sound[] playersoundsound;
    public AudioSource PlayersSoundSource;

    public void OnplaySound(string Name)
    {
        Sound s = Array.Find(playersoundsound, x => x.Name == Name);
        if (s == null)
        {
            Debug.Log("sound not found");
        }
        else
        {
            PlayersSoundSource.PlayOneShot(s.AudioClip,1);
            
        }
    }
}

[System.Serializable]
public class Sound
{
    public string Name;
    public AudioClip AudioClip;
}