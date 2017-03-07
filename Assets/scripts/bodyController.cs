using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyController : MonoBehaviour {

	public GameObject bodyOpen;
	public GameObject bodyClosed;

	public static bool isLeaning = false;


	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			bodyOpen.SetActive(false);
			bodyClosed.SetActive(true);
			isLeaning = true;
		} else {
			bodyOpen.SetActive(true);
			bodyClosed.SetActive(false);
			isLeaning = false;
		}
	}
}
