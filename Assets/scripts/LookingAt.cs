using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingAt : MonoBehaviour {
	public static string lookingAt = "";
	public GameObject mousePart;
	private Vector3 thisPosition;

	void Start(){
		thisPosition = this.GetComponent<Transform>().position;

	}
	void OnMouseEnter(){
		GameObject clone = (GameObject)Instantiate (mousePart, thisPosition, Quaternion.identity);
		Destroy (clone, .5f);
	}
	void OnMouseOver(){
		lookingAt = this.tag.ToString();
	}

}
