using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {

	public int checkPointNoFwd;
	public int checkPointNoBkw;
	public bool triggered = false;

	void OnTriggerEnter(Collider coll){
		if(triggered == false){
			Camera.main.GetComponent<MoveLevel> ().pos = checkPointNoFwd;
			triggered = true;
		}
		else{
			Camera.main.GetComponent<MoveLevel> ().pos = checkPointNoBkw;
			triggered = false;
		}
	}

}
