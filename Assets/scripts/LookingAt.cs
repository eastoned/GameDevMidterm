using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingAt : MonoBehaviour {
	public static string lookingAt = "";
	public static GameObject mousePart;
	public static Vector3 thisPosition;

	void OnMouseOver(){
		thisPosition = this.GetComponent<Transform>().position;
		if (handController.isGrabbing) {
			lookingAt = this.tag.ToString ();
			GameObject clone = (GameObject)Instantiate (mousePart, thisPosition, Quaternion.identity);
			Destroy (clone, 5f);
		} else {
			lookingAt = "";
			//LAPTOP = CUBE 1
			//PHONE = CUBE 2
			//TV = CUBE 3
		}
	}

}
