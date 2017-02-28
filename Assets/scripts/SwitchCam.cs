using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour {
	public Camera turnOff;
	public Camera turnOn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			turnOff.enabled = false;
			turnOn.enabled = true;
		} else {
			turnOff.enabled = true;
			turnOn.enabled = false;
		}
	}
}
