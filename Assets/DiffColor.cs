using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiffColor : MonoBehaviour {
	private Renderer rend;
	public Text personTalk;

	void Start(){
		rend = GetComponent<Renderer>();
	}
	void OnMouseOver(){
		rend.material.color -= new Color(.1f, .1f, .1f) * Time.deltaTime;
		if (this.CompareTag ("Floor")) {
			personTalk.text = "That's the floor.";
		} else if (this.CompareTag ("TV")) {
			personTalk.text = "Thats a TV";
		} else if (this.CompareTag ("Wall")) {
			personTalk.text = "And that's a wall";
		}
	}
	void OnMouseExit(){
		personTalk.text = "That's Nothing";
	}

}
