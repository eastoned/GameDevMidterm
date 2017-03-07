using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handController : MonoBehaviour {
	public GameObject handOpen;
	public GameObject handClosed;

	public static bool isGrabbing = false;

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			handOpen.SetActive(false);
			handClosed.SetActive(true);
			isGrabbing = true;
		} else {
			handOpen.SetActive(true);
			handClosed.SetActive(false);
			isGrabbing = false;
		}
	}
}
