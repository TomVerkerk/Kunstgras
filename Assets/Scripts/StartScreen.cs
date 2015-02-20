using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {

	private Follow_finger player;
	public Texture image;
	public Timer timer;

	void Start(){
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Follow_finger>();
		player.playing = false;
		timer.running = false;
	}

	void OnGUI(){
		GUI.DrawTexture (new Rect (Screen.width * 0.2f, Screen.height * 0.25f, Screen.width * 0.6f, Screen.height * 0.5f), image);
		GUI.color = Color.clear;
		if (GUI.Button(new Rect(Screen.width*0.2f,Screen.height*0.15f,Screen.width*0.6f,Screen.height*0.7f),"")){
			player.playing = true;
			timer.running = true;
			Destroy(this.gameObject);
		}
	}
}
