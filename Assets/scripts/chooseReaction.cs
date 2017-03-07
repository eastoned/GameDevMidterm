using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chooseReaction : MonoBehaviour {
	public Sprite[] reactions = new Sprite[3];
	private Image currentSprite;
	private Color lerpToShow;
	// Use this for initialization
	void Start () {
		currentSprite = GetComponent<Image>();
		lerpToShow = currentSprite.color;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Alpha1)) {
			currentSprite.sprite = reactions [0];
			lerpToShow.a = 255;
			currentSprite.color = lerpToShow;
			//set to eyes
		} else if (Input.GetKey (KeyCode.Alpha2)) {
			currentSprite.sprite = reactions [1];
			lerpToShow.a = 255;
			currentSprite.color = lerpToShow;
			//set to mouth
		} else if (Input.GetKey (KeyCode.Alpha3)) {
			currentSprite.sprite = reactions [2];
			lerpToShow.a = 255;
			currentSprite.color = lerpToShow;
			//set to ear
		} else {
			lerpToShow.a = 0;
			currentSprite.color = lerpToShow;

		}
	}
}
