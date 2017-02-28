using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScale : MonoBehaviour {
	private float currentScaleX;
	private float currentScaleY;
	private float currentScaleZ;

	private float largerScaleX = 3f;
	private float largerScaleY = 3f;
	private float largerScaleZ = 3f;

	private float scaleFactor;

	private float currentPosX;
	private float currentPosY;
	private float currentPosZ;

	private float furtherPosx;
	private float furtherPosY;
	private float furtherPosZ;

	public static bool isScalingUp = false;
	public static bool isShaking = false;

	public int shakeAmount;

	// Use this for initialization
	void Start () {
		currentScaleX = this.GetComponent<Transform>().localScale.x;
		currentScaleY = this.GetComponent<Transform>().localScale.y;
		currentScaleZ = this.GetComponent<Transform>().localScale.z;

		currentPosX = this.GetComponent<Transform>().position.x;
		currentPosY = this.GetComponent<Transform>().position.y;
		currentPosZ = this.GetComponent<Transform>().position.z;

		furtherPosx = currentPosX - 1f;
		furtherPosY = currentPosY - 1f;
		furtherPosZ = currentPosZ - 1f;

	}

	void OnMouseEnter(){
		StartCoroutine("changeScaleUp");
	}
	void OnMouseOver(){
		StartCoroutine("shakeObject");
	}
	void OnMouseExit(){
		StartCoroutine("changeScaleDown");
	}

	IEnumerator changeScaleUp(){
		isScalingUp = true;
		for (float i = 0; i < 1; i += .1f) {
			this.gameObject.transform.localScale = new Vector3 (Mathf.Lerp (currentScaleX, largerScaleX, i), Mathf.Lerp (currentScaleY, largerScaleY, i), Mathf.Lerp (currentScaleZ, largerScaleZ, i));
			yield return new WaitForSeconds (.01f);
		}
	}

	IEnumerator changeScaleDown(){
		isScalingUp = false;
		for (float i = 0; i < 1; i += .1f) {
			this.gameObject.transform.localScale = new Vector3 (Mathf.Lerp (largerScaleX, currentScaleX, i), Mathf.Lerp (largerScaleY, currentScaleY, i), Mathf.Lerp (largerScaleZ, currentScaleZ, i));
			yield return new WaitForSeconds(.01f);
		}
	}
	IEnumerator shakeObject(){
		shakeAmount = Random.Range(0, 3);
		isShaking = true;
		for (float i = 0; i < 1; i += .2f) {
			this.gameObject.transform.position = new Vector3 (Mathf.Lerp (currentPosX, furtherPosx + shakeAmount, i), Mathf.Lerp (currentPosY, furtherPosY + shakeAmount, i), Mathf.Lerp (currentPosZ, furtherPosZ + shakeAmount, i));
			yield return new WaitForSeconds (.1f);
			this.gameObject.transform.position = new Vector3 (Mathf.Lerp (furtherPosx + shakeAmount, currentPosX, i), Mathf.Lerp (furtherPosY + shakeAmount, currentPosY, i), Mathf.Lerp (furtherPosZ + shakeAmount, currentPosZ, i));
			yield return new WaitForSeconds (.1f);
		}
	}


}
