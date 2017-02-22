using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkBox : MonoBehaviour {


public bool enter;
public GameObject key;
public AudioClip talkSound;
public AudioSource source;

//for movement locking
public GameObject player;

//look at the subject when were talking

	void Start()
	{
			source = GetComponent<AudioSource>();
			
	}
 

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

		//lock player movement
		player.GetComponent<MovementControl>().stopPlayer();


		Debug.Log("entered");
	}

	void OnTriggerExit(){
		this.gameObject.SetActive(false);
		Debug.Log("left");
	}

	//drop the key (called in rpg thing when talk is done)
	void DropKey()
	{
		key.SetActive (true);
		UnlockPlayer();
	}
	void UnlockPlayer()
	{
		player.GetComponent<MovementControl>().stopTalking();
	}



}
