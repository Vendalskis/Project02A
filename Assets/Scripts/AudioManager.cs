﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public static AudioManager Instance = null;

    AudioSource _audioSource;


    private void Awake()
    {

        #region Singleton Pattern (Simple)
        if(Instance == null)
        {
            //doesnt exist yet, this is now our singleton
            Instance = this;
            //fill references
            _audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
        #endregion

    }

    public void PlaySong(AudioClip clip)
    {
        _audioSource.clip = clip;
        _audioSource.Play();
    }
}
