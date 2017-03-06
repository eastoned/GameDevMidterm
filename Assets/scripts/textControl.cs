using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textControl : MonoBehaviour {
	
	public Text mainBox;
	public Text timer;

	public static string[] commands = { "Cube1", "Cube2", "Cube3" };
	private string[] cubeColors = { "blue", "red", "green" };

	//string[] textArray = {"one", "two", "three"};


	void Start(){
	}

	void Update(){
		//shows timer and box to mouse over
		timer.text = Mathf.RoundToInt(gameManager.timer).ToString();
		mainBox.text = "Click the " + (cubeColors[gameManager.randomInt]) + " cube";
		//mainbox.text
		if (gameManager.wonGame == true) {
			mainBox.text = "You WON!";
		}
		if (gameManager.lostGame == true) {
			mainBox.text = "You LOST!";
		}



	}


	}


