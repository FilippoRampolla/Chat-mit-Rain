using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public Sounds[] sound;

    public static AudioManager instance;
    
    void Awake()
    {
        //for destroy the object in the scene and don't have repetion of audio
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        //Assign the component of the sound to the field
        foreach(Sounds s in sound)
        {
            s.source=gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
//Function for play by other script
    public void Play(string name)
    {
        Sounds s = Array.Find(sound, sound => sound.name == name);
        if (s == null)
            return;
        s.source.Play();
    }
    
}
//FindObjectOfType<AudioManager>().Play("name")