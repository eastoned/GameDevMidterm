using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingAt : MonoBehaviour {
	public static string lookingAt = "";
	public GameObject mousePart;
	private Vector3 mousePos;

	void Start(){
		mousePos.x = Input.mousePosition.x/Screen.width;
		mousePos.y = Input.mousePosition.y/Screen.height;

	}
	void OnMouseOver(){
		lookingAt = this.tag.ToString();
		GameObject clone = (GameObject)Instantiate (mousePart, mousePos, Quaternion.identity);
		Destroy (clone, .5f);
	}

}
