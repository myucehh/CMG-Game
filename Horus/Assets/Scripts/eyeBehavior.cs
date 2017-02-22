using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeBehavior : MonoBehaviour 
{

	public Transform targetPlayer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
       if(targetPlayer != null)
       {
            transform.LookAt(targetPlayer);
       }
	}
}
