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
			rend = GetComponent<Renderer> ();
	
	}

	void Update(){
		lerpToThis = commandColors[gameManager.randomInt];
		if (lerpToThis != rend.material.color) {
			StartCoroutine ("lerpColor");
		}
	}
	IEnumerator lerpColor(){
		for (float i = 0; i < 1; i += .01f) {
			rend.material.color = new Color (Mathf.Lerp (lerpToThis.r, rend.material.color.r, i), Mathf.Lerp (lerpToThis.g, rend.material.color.g, i), Mathf.Lerp (lerpToThis.b, rend.material.color.b, i));
			yield return new WaitForSeconds (1f);
		}
	}
		
}
