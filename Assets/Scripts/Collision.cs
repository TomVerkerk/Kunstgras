using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Collision : MonoBehaviour {

	public Vector3 resetPos;

	void OnTriggerEnter(Collider coll){
		coll.gameObject.transform.position = resetPos;
		coll.GetComponent<Follow_finger> ().target = resetPos;
		coll.GetComponent<Follow_finger> ().reset = true;
	}
}
