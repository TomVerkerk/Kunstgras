using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

	public GameObject player;

	void Start(){
		SpawnPlayer ();
	}
	
	public void SpawnPlayer () {
		Instantiate (player, player.transform.position, player.transform.rotation);
	}
}
