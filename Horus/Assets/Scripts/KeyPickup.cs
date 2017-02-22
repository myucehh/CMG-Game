using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour {
	public GameObject door;
	public GameObject key;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider player){

		if (player.gameObject.tag == "Player") {
			door.GetComponent<DoorOpener> ().openDoor ();
			Destroy (key);
			Debug.Log ("touched key");
		}

	}
}
