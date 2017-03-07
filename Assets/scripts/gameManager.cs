using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

	private int answerRight = 0;
	private int answerWrong = 0;
	public static float timer = 10;

	public static int difficultyCounter = 0;
	public static int randomCommand;
	public static int randomObject;

	public GameObject[] spawnPos = new GameObject[3];
	public GameObject[] itemToPlace = new GameObject[3];
	private GameObject[] spawnedObject = new GameObject[3];
	private string[] objects = { "Phone", "Laptop", "Speaker" };
	private int randomPos;

	public static bool wonGame = false;
	public static bool lostGame = false;

	//need COUNTDOWN FIRST

	void Start(){
		randomCommand = Random.Range (0, 3);
		randomObject = Random.Range (0, 3);
		//CONTROLS SPAWNING
		randomPos = Random.Range(0, 6);
			if (randomPos == 0) {
				for (int i = 0; i < 3; i++) {
					spawnedObject [i] = (GameObject)Instantiate (itemToPlace [i], spawnPos [i].GetComponent<Transform> ().position, Quaternion.identity);
					Destroy (spawnedObject [i], timer);
				}
			} else if (randomPos == 1) {
				spawnedObject[0] = (GameObject)Instantiate (itemToPlace [0], spawnPos [2].GetComponent<Transform> ().position, Quaternion.identity);
				spawnedObject[1] = (GameObject)Instantiate (itemToPlace [1], spawnPos [0].GetComponent<Transform> ().position, Quaternion.identity);
				spawnedObject[2] = (GameObject)Instantiate (itemToPlace [2], spawnPos [1].GetComponent<Transform> ().position, Quaternion.identity);
				Destroy(spawnedObject[0], timer);
				Destroy(spawnedObject[1], timer);
				Destroy(spawnedObject[2], timer);
			} else if (randomPos == 2) {
				spawnedObject[0] = (GameObject)Instantiate (itemToPlace [0], spawnPos [1].GetComponent<Transform> ().position, Quaternion.identity);
				spawnedObject[1] = (GameObject)Instantiate (itemToPlace [1], spawnPos [2].GetComponent<Transform> ().position, Quaternion.identity);
				spawnedObject[2] = (GameObject)Instantiate (itemToPlace [2], spawnPos [0].GetComponent<Transform> ().position, Quaternion.identity);
				Destroy(spawnedObject[0], timer);
				Destroy(spawnedObject[1], timer);
				Destroy(spawnedObject[2], timer);
			}else if (randomPos == 3) {
				spawnedObject[0] = (GameObject)Instantiate (itemToPlace [0], spawnPos [1].GetComponent<Transform> ().position, Quaternion.identity);
				spawnedObject[1] = (GameObject)Instantiate (itemToPlace [1], spawnPos [0].GetComponent<Transform> ().position, Quaternion.identity);
				spawnedObject[2] = (GameObject)Instantiate (itemToPlace [2], spawnPos [2].GetComponent<Transform> ().position, Quaternion.identity);
				Destroy(spawnedObject[0], timer);
				Destroy(spawnedObject[1], timer);
				Destroy(spawnedObject[2], timer);
			}else if (randomPos == 4) {
				spawnedObject[0] = (GameObject)Instantiate (itemToPlace [0], spawnPos [2].GetComponent<Transform> ().position, Quaternion.identity);
				spawnedObject[1] = (GameObject)Instantiate (itemToPlace [1], spawnPos [1].GetComponent<Transform> ().position, Quaternion.identity);
				spawnedObject[2] = (GameObject)Instantiate (itemToPlace [2], spawnPos [0].GetComponent<Transform> ().position, Quaternion.identity);
				Destroy(spawnedObject[0], timer);
				Destroy(spawnedObject[1], timer);
				Destroy(spawnedObject[2], timer);
			}else if (randomPos == 5) {
				spawnedObject[0] = (GameObject)Instantiate (itemToPlace [0], spawnPos [0].GetComponent<Transform> ().position, Quaternion.identity);
				spawnedObject[1] = (GameObject)Instantiate (itemToPlace [1], spawnPos [2].GetComponent<Transform> ().position, Quaternion.identity);
				spawnedObject[2] = (GameObject)Instantiate (itemToPlace [2], spawnPos [1].GetComponent<Transform> ().position, Quaternion.identity);
				Destroy(spawnedObject[0], timer);
				Destroy(spawnedObject[1], timer);
				Destroy(spawnedObject[2], timer);
			}

	}
	// Use this for initialization
	void GenerateCommand() {
		//restarts timer and gives new command
		randomCommand = Random.Range (0, 3);
		randomObject = Random.Range (0, 3);
		if (difficultyCounter == 0) {
			timer = 10;
		} else if (difficultyCounter == 1) {
			timer = 5;
		} else if (difficultyCounter == 2) {
			timer = 3;
		}

		//CONTROLS SPAWNING
		randomPos = Random.Range(0, 6);
		if (randomPos == 0) {
			for (int i = 0; i < 3; i++) {
				spawnedObject [i] = (GameObject)Instantiate (itemToPlace [i], spawnPos [i].GetComponent<Transform> ().position, Quaternion.identity);
				Destroy (spawnedObject [i], timer);
			}
		} else if (randomPos == 1) {
			spawnedObject[0] = (GameObject)Instantiate (itemToPlace [0], spawnPos [2].GetComponent<Transform> ().position, Quaternion.identity);
			spawnedObject[1] = (GameObject)Instantiate (itemToPlace [1], spawnPos [0].GetComponent<Transform> ().position, Quaternion.identity);
			spawnedObject[2] = (GameObject)Instantiate (itemToPlace [2], spawnPos [1].GetComponent<Transform> ().position, Quaternion.identity);
			Destroy(spawnedObject[0], timer);
			Destroy(spawnedObject[1], timer);
			Destroy(spawnedObject[2], timer);
		} else if (randomPos == 2) {
			spawnedObject[0] = (GameObject)Instantiate (itemToPlace [0], spawnPos [1].GetComponent<Transform> ().position, Quaternion.identity);
			spawnedObject[1] = (GameObject)Instantiate (itemToPlace [1], spawnPos [2].GetComponent<Transform> ().position, Quaternion.identity);
			spawnedObject[2] = (GameObject)Instantiate (itemToPlace [2], spawnPos [0].GetComponent<Transform> ().position, Quaternion.identity);
			Destroy(spawnedObject[0], timer);
			Destroy(spawnedObject[1], timer);
			Destroy(spawnedObject[2], timer);
		}else if (randomPos == 3) {
			spawnedObject[0] = (GameObject)Instantiate (itemToPlace [0], spawnPos [1].GetComponent<Transform> ().position, Quaternion.identity);
			spawnedObject[1] = (GameObject)Instantiate (itemToPlace [1], spawnPos [0].GetComponent<Transform> ().position, Quaternion.identity);
			spawnedObject[2] = (GameObject)Instantiate (itemToPlace [2], spawnPos [2].GetComponent<Transform> ().position, Quaternion.identity);
			Destroy(spawnedObject[0], timer);
			Destroy(spawnedObject[1], timer);
			Destroy(spawnedObject[2], timer);
		}else if (randomPos == 4) {
			spawnedObject[0] = (GameObject)Instantiate (itemToPlace [0], spawnPos [2].GetComponent<Transform> ().position, Quaternion.identity);
			spawnedObject[1] = (GameObject)Instantiate (itemToPlace [1], spawnPos [1].GetComponent<Transform> ().position, Quaternion.identity);
			spawnedObject[2] = (GameObject)Instantiate (itemToPlace [2], spawnPos [0].GetComponent<Transform> ().position, Quaternion.identity);
			Destroy(spawnedObject[0], timer);
			Destroy(spawnedObject[1], timer);
			Destroy(spawnedObject[2], timer);
		}else if (randomPos == 5) {
			spawnedObject[0] = (GameObject)Instantiate (itemToPlace [0], spawnPos [0].GetComponent<Transform> ().position, Quaternion.identity);
			spawnedObject[1] = (GameObject)Instantiate (itemToPlace [1], spawnPos [2].GetComponent<Transform> ().position, Quaternion.identity);
			spawnedObject[2] = (GameObject)Instantiate (itemToPlace [2], spawnPos [1].GetComponent<Transform> ().position, Quaternion.identity);
			Destroy(spawnedObject[0], timer);
			Destroy(spawnedObject[1], timer);
			Destroy(spawnedObject[2], timer);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		if (answerRight >= 10 && answerRight <=15) {
			difficultyCounter = 1;
		} else if (answerRight >= 16 && answerRight <= 24) {
			difficultyCounter = 2;
		} else if (answerRight >= 25) {
			goodEnding ();
		}
		if (answerWrong >= 15) {
			badEnding ();
		}

		timer -= Time.deltaTime;

		if (objects[randomObject] == LookingAt.lookingAt && randomCommand == particleControl.currentReaction) {
			answerRight += 1;
			Debug.Log ("DING DING DING" + answerRight);
			DestroyImmediate(spawnedObject[0]);
			DestroyImmediate(spawnedObject[1]);
			DestroyImmediate(spawnedObject[2]);
			GenerateCommand();
		} else if (timer <= 0) {
			answerWrong += 1;
			Debug.Log ("Time UP!" + answerWrong);
			GenerateCommand();
		}
}
	void goodEnding(){
		wonGame = true;
		//load nice scene

	}

	void badEnding(){
		lostGame = true;
		//load sad scene

	}
}
