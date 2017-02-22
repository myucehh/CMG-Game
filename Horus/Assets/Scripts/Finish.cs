using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {
	public bool enter;
	public AudioClip talkSound;
	public AudioSource source;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update(){

		if(enter) {
			//Play sound 
			source.PlayOneShot(talkSound);
			//start dialogue
			gameObject.GetComponent<RPGTalk>().NewTalk();
			enter = false;


		}
	}

	void OnTriggerEnter(Collider player){
		//Set enter to true when player enters
		if(player.gameObject.tag=="Player"){
			enter = true;
		}
	}

	void fadeOut(){
		//fade out the game
		Debug.Log("end!");
	}
}



