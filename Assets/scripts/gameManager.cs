using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {
	private int answerRight = 0;
	private int answerWrong = 0;
	public static float timer = 3;

	public static int randomInt;
	public GameObject[] spawnPos = new GameObject[3];
	public GameObject[] itemToPlace = new GameObject[3];

	private int randomPos;
	void Start(){
		randomInt = 0;
	}
	// Use this for initialization
	void GenerateCommand() {
		randomInt = Random.Range(0,3);
		timer = 3;
		for(int i = 0; i < 2; i++){
			randomPos = Random.Range(0, 3-i);
			Instantiate(itemToPlace[i], spawnPos[randomPos].GetComponent<Transform>().position, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (LookingAt.lookingAt == textControl.commands[randomInt]) {
			answerRight += 1;
			Debug.Log ("DING DING DING" + answerRight);
			GenerateCommand ();
		} else if (timer <= 0) {
			answerWrong += 1;
			Debug.Log ("Time UP!" + answerWrong);
			GenerateCommand ();
		}
}
}
