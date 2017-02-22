using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.Characters.FirstPerson;

public class MovementControl : MonoBehaviour {
	//public FirstPersonController fpc; 
	// Use this for initialization
	public Transform pos;
	public Transform talking;
	private bool isTalking = false;

	// Update is called once per frame
	public void Update () {
		//lock player moving if eye is talking
		if (isTalking) {
			this.transform.position = pos.transform.position;
		} 
	}

	public void stopPlayer()
	{
	//were talking to you now!
	isTalking = true;
	Debug.Log("tesycles");
	}

	public void stopTalking()
	{
		isTalking = false;
	}
}
