using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Animate : MonoBehaviour {

	public List<GameObject> anim;

	// Use this for initialization
	public void PlayAnim (int dejorden) {
		Debug.Log (anim [dejorden]);
		anim [dejorden].GetComponent<ParticleSystem> ().enableEmission = true;
	}

	public void stopAnim(int dejorden){
		anim [dejorden].GetComponent<ParticleEmitter>().emit = false;
	}
}
