﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class playSound : MonoBehaviour {
	public AudioClip impact;
	AudioSource audio;

	void Start() {
		audio = GetComponent<AudioSource>();
	}

	void OnCollisionEnter() {
		audio.PlayOneShot(impact, 0.7F);
		Debug.Log ("playing");
	}
}