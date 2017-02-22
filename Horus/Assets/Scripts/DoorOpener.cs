using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour {
	public GameObject door;
	public float opening;

	public bool hasKey;



	void Update()
	{
		if (hasKey) {
			
				door.transform.Translate (Vector3.right * (Time.deltaTime * opening));

		}
	}

	// Use this for initialization
	public void openDoor()
	{
		hasKey = true;
	}
}
