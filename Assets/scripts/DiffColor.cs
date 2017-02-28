using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiffColor : MonoBehaviour {
	public Color[] commandColors = new Color[3];
	private Color lerpToThis;
	private Renderer rend;
	private Text textColor;

	void Start(){
		if (this.gameObject.CompareTag("Wall")){
			rend = GetComponent<Renderer> ();
		}
		if(this.gameObject.CompareTag("gameText")){
			textColor = GetComponent<Text>();
		}
	}

	void Update(){
		lerpToThis = commandColors[gameManager.randomInt];

		if (this.gameObject.CompareTag ("Wall")) {
			rend.material.color = lerpToThis;
		} else if (this.gameObject.CompareTag("gameText")) {
			textColor.color = Color.black;
		}
	}
		
}
