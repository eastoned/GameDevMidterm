using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volumeInSpace : MonoBehaviour {
	private AudioSource controlVolume;

	// Use this for initialization
	void Start () {
		controlVolume = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
			Debug.Log (controlVolume.volume);
			controlVolume.volume -= .05f * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.A)){
			controlVolume.Pause ();
	}
		if(Input.GetKey(KeyCode.S)){
			if(!controlVolume.isPlaying){
				controlVolume.Play();
			}
		}
}
}