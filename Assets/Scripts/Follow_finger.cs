using UnityEngine;
using System.Collections;

public class Follow_finger : MonoBehaviour {
	
	private Ray ray;
	public Vector3 target;
	private Vector3 camTarget;
	public bool reset = false;
	private bool player = false;
	public bool playing = true;
	public float speedUp = 1;
	
	void Start(){
		camTarget = new Vector3(transform.position.x,transform.position.y,-10);
		Camera.main.transform.position = camTarget;
	}

	void Update () {
		if(playing){
			if(Input.touchCount>0 && reset == false){
				ray = Camera.main.ScreenPointToRay (Input.GetTouch(0).position);
				RaycastHit hit;
				hit = new RaycastHit();
				if(Physics.Raycast(ray, out hit)){
					if(hit.collider.gameObject.tag == "Player"){
						player = true;
					}
					if(player){
						speedUp = 1;
						target = hit.point;
					}
				}
			}
			else if(Input.touchCount==0){
				player = false;
			}
			if(reset){
				speedUp = 2;
				if(Input.touchCount==0){
					reset = false;
				}
				player = false;
			}
			target.z = 2;
			transform.position = Vector3.Lerp(transform.position,target,0.015f);
			camTarget = new Vector3(transform.position.x,transform.position.y,-10);
			Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position,camTarget,(0.01f)*speedUp);
		}
	}
}
