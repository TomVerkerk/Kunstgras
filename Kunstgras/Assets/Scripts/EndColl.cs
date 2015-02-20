using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EndColl : MonoBehaviour {
	
	public Texture image;
	private bool end = false;
	public string nextLevel;
	public Timer time;

	void OnTriggerEnter(Collider coll){
		if(nextLevel == "End"){
			coll.gameObject.GetComponent<Follow_finger>().playing = false;
			time.running = false;
			end = true;
		}
		else{
			PlayerPrefs.SetFloat("timex",time.gameObject.transform.rotation.x);
			PlayerPrefs.SetFloat("timey",time.gameObject.transform.rotation.y);
			PlayerPrefs.SetFloat("timez",time.gameObject.transform.rotation.z);
			PlayerPrefs.SetFloat("timew",time.gameObject.transform.rotation.w);
			PlayerPrefs.SetFloat("time",Time.time);
			Application.LoadLevel (nextLevel);
		}
	}

	void OnGUI(){
		if(end){
			GUI.DrawTexture (new Rect (Screen.width * 0.2f, Screen.height * 0.25f, Screen.width * 0.6f, Screen.height * 0.5f), image);
		}
	}
}
