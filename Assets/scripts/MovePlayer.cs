using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {
	private Animator walkForward;
	// Use this for initialization
	void Start () {
		walkForward = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			walkForward.SetTrigger ("PlayWalking");
			walkForward.speed = 1f;
		} else if (Input.GetKeyUp (KeyCode.Space)) {
			walkForward.speed = 0f;
		}

	//looks at what the players pointing at

	}
}

