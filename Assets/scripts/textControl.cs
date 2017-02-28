using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textControl : MonoBehaviour {
	public Text block1;
	public Text block2;
	public Text block3;
	public Text mainBox;
	public Text timer;




	public static string[] commands = { "Cube1", "Cube2", "Cube3" };
	string[] textArray = {"one", "two", "three"};

	void Start(){
		
	}

	void Update(){
		timer.text = Mathf.RoundToInt(gameManager.timer).ToString();
		mainBox.text = "Mouse over Box #" + (gameManager.randomInt +1 );
		block1.text = textArray[gameManager.randomInt];
		if(Input.GetKey(KeyCode.Space)){
			block2.text = textArray[0];
		}else{
			block2.text = textArray[1];
		}
	
		if (changeScale.isScalingUp == true){
			block3.text = textArray [2];
		}else{
			block3.text = textArray[1];
		}
		if (gameManager.wonGame == true) {
			mainBox.text = "You WON!";
		}
		if (gameManager.lostGame == true) {
			mainBox.text = "You LOST!";
		}



	}


	}


