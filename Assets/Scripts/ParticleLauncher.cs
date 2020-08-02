using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleLauncher : MonoBehaviour {

    private AudioSource mAudioSrc;

    public ParticleSystem particleLauncher;

	// Use this for initialization
	void Start () {
        mAudioSrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            particleLauncher.Emit(20);
            mAudioSrc.Play();
        }
        
        
	}
}
