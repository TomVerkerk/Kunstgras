using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Audio : MonoBehaviour {
	
	public List<AudioClip> Sounds;
	private AudioSource audio;
	public bool sound;

	void Start(){
		audio = transform.GetComponent<AudioSource> ();
	}

	void Update(){
		if(sound){
			PlaySound(0,1,false);
			sound = false;
		}
	}

	public void PlaySound(int clip, float volume, bool loop) {
		audio.clip = Sounds[clip];
		audio.volume = volume;
		audio.loop = loop;
		audio.Play ();
	}
}
