using UnityEngine;
using System.Collections;

public class Placement : MonoBehaviour {

	public GameObject clock;
	public Timer timer;
	public bool checkTime;
	public float side;
	public float down;
	public float back;

	void Start(){
		transform.position = new Vector3 (clock.transform.position.x - transform.localScale.x*side, clock.transform.position.y-transform.localScale.y *down,clock.transform.position.z + back);
		if(checkTime){
			Quaternion rotation = new Quaternion(PlayerPrefs.GetFloat("timex"),PlayerPrefs.GetFloat("timey"),PlayerPrefs.GetFloat("timez"),PlayerPrefs.GetFloat("timew"));
			timer.gameObject.transform.rotation = rotation;
		}
	}
}
