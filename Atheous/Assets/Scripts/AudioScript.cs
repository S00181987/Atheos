using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {

    public AudioClip musicClips;
    public AudioSource musicSource;

	// Use this for initialization
	void Start () {

        musicSource.clip = musicClips;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
            musicSource.Play();
		
	}
}
