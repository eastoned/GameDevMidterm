using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textControl : MonoBehaviour {
	
	public Text mainBox;
	public Text timer;

	private string[] randomReactCommands = { "Check out this ", "What do you think about that ", "Let me tell you about another " };
	private string[] randomObjectCommands = { "Instagram", "Netflix series", "Spotify playlist" };

	void Update(){
		//shows timer and box to mouse over
		timer.text = Mathf.RoundToInt(gameManager.timer).ToString();
		//if (gameManager.random
		mainBox.text = randomReactCommands[gameManager.randomCommand].ToString() + randomObjectCommands[gameManager.randomObject].ToString();

		if (gameManager.wonGame == true) {
			mainBox.text = "You WON!";
		}
		if (gameManager.lostGame == true) {
			mainBox.text = "You LOST!";
		}



	}


	}


