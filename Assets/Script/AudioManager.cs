using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviourSingletonPersistent<AudioManager>
{


    public Sound[] musicSounds, sfxSounds;

    public AudioSource musicSource, sfxSource;

    

    private void Start()
    {
        PlayMusic("Theme");
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);
            if(s == null)
            {
                Debug.Log("Sound not found");
            }
            else
            {
                musicSource.clip = s.clip;
                musicSource.Play();
            }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);
        if (s == null)
        {
            Debug.Log("Sound not found");
        }
        else
        {
            sfxSource.PlayOneShot(s.clip);
        }
    }
}
