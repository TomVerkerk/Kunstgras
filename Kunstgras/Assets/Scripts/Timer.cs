using UnityEngine;
using System.Collections;
using System.Timers;

public class Timer : MonoBehaviour {

	private float minutes;
	public Audio sound;
	public Texture image;
	public bool firstlevel;
	public bool running;
	public GameObject explosion;
	private GUITexture texture;
	private float startTime;
	private Quaternion pos;
	public GameObject plate;
	private Color myColor = Color.red;
	private bool playingSound = false;
	public Animate anim;

	void Start(){
		explosion.particleEmitter.emit = false;
		minutes = 1;
		if(firstlevel){
			PlayerPrefs.SetFloat("timex",0);
			PlayerPrefs.SetFloat("timey",0);
			PlayerPrefs.SetFloat("timez",0);
			PlayerPrefs.SetFloat("timew",0);
		}
		else{
			running = true;
		}
	}

	void Update(){
		if(running){
			Time.timeScale = 1;
			transform.Rotate (-new Vector3 (0, 0, 6/minutes) * Time.deltaTime);
		}
		else{
			Time.timeScale = 0;
			bool henk = true;
			if(henk){
				//explosion.particleEmitter.emit = true;
				explosion.particleEmitter.Emit();
				henk = false;
			}
		}
	}

	void OnGUI(){
		if (Time.time >= 60 * minutes) {
			//GUI.DrawTexture (new Rect (Screen.width * 0.2f, Screen.height * 0.25f, Screen.width * 0.6f, Screen.height * 0.5f), image);
			running = false;
		}
		else if(Mathf.Floor(Time.time) % 60 == 59 && Mathf.Floor(Time.time) != 0 && running){
			if(playingSound == false){
				myColor = Color.red;
				playingSound = true;
			}
			plate.renderer.material.color = myColor;
			myColor = Color.Lerp(myColor,Color.white,0.03f);
			if (Mathf.Floor(60*minutes - Time.time) == 59){
				Debug.Log("one minute left");
				anim.PlayAnim(0);
				anim.PlayAnim(1);
			}
		}
		else if(60*minutes - Time.time <= 10 && 60*minutes - Time.time >= 9.1f && running ||
		        60*minutes - Time.time <= 9 && 60*minutes - Time.time >= 8.1f && running ||
		        60*minutes - Time.time <= 8 && 60*minutes - Time.time >= 7.1f && running ||
		        60*minutes - Time.time <= 7 && 60*minutes - Time.time >= 6.1f && running ||
		        60*minutes - Time.time <= 6 && 60*minutes - Time.time >= 5.1f && running ||
		        60*minutes - Time.time <= 5 && 60*minutes - Time.time >= 4.1f && running ||
		        60*minutes - Time.time <= 4 && 60*minutes - Time.time >= 3.1f && running ||
		        60*minutes - Time.time <= 3 && 60*minutes - Time.time >= 2.1f && running ||
		        60*minutes - Time.time <= 2 && 60*minutes - Time.time >= 1.1f && running ||
		        60*minutes - Time.time <= 1 && 60*minutes - Time.time >= 0.1f && running){
			if(playingSound == false){
				myColor = Color.red;
				playingSound = true;
			}
			plate.renderer.material.color = myColor;
			myColor = Color.Lerp(myColor,Color.white,0.04f);
		}
		else{
			myColor = Color.white;
			plate.renderer.material.color = myColor;
			playingSound = false;
		}
	}
}
