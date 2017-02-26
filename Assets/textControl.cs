using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textControl : MonoBehaviour {
	public Text block1;
	public Text block2;
	public Text block3;

	public GameObject box1;
	public GameObject box2;
	public GameObject box3;

	string[] textArray = {"one", "two", "three"};
	int randomInt;


	void Update(){
		randomInt = Random.Range (0, 3);
		block1.text = textArray[randomInt];
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
	}


}
