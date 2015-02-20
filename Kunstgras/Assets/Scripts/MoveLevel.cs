using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveLevel : MonoBehaviour {
	
	public List<Vector3> positions; 
	public Vector3 target;
	public int pos;

	void Update(){
		target = positions[pos];
		transform.position = Vector3.Lerp(Camera.main.gameObject.transform.position,target,0.04f);
	}
}
