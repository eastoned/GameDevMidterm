using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleControl : MonoBehaviour {
	public GameObject[] setReact = new GameObject[4];
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Alpha1)) {
			LookingAt.mousePart = setReact [0];
			//set to eyes
		} else if (Input.GetKey (KeyCode.Alpha2)) {
			LookingAt.mousePart = setReact [1];
			//set to mouth
		} else if (Input.GetKey (KeyCode.Alpha3)) {
			LookingAt.mousePart = setReact [2];
			//set to ear
		}else {
			LookingAt.mousePart = setReact [3];
			//just touching/smoke
		}
			
	}
}
