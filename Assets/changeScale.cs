using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScale : MonoBehaviour {
	private float currentScaleX;
	private float currentScaleY;
	private float currentScaleZ;

	private float scaleFactor;

	private float largerScaleX = 3f;
	private float largerScaleY = 3f;
	private float largerScaleZ = 3f;

	public static bool isScalingUp = false;
	// Use this for initialization
	void Start () {
		currentScaleX = this.GetComponent<Transform>().localScale.x;
		currentScaleY = this.GetComponent<Transform>().localScale.y;
		currentScaleZ = this.GetComponent<Transform>().localScale.z;
	}

	void OnMouseEnter(){
		StartCoroutine("changeScaleUp");
	}
	void OnMouseExit(){
		StartCoroutine("changeScaleDown");
	}

	IEnumerator changeScaleUp(){
		isScalingUp = true;
		for (float i = 0; i < 1; i += .1f) {
			this.gameObject.transform.localScale = new Vector3 (Mathf.Lerp (currentScaleX, largerScaleX, i), Mathf.Lerp (currentScaleY, largerScaleY, i), Mathf.Lerp (currentScaleZ, largerScaleZ, i));
			yield return new WaitForSeconds(.01f);
		}
	}

	IEnumerator changeScaleDown(){
		isScalingUp = false;
		for (float i = 0; i < 1; i += .1f) {
			this.gameObject.transform.localScale = new Vector3 (Mathf.Lerp (largerScaleX, currentScaleX, i), Mathf.Lerp (largerScaleY, currentScaleY, i), Mathf.Lerp (largerScaleZ, currentScaleZ, i));
			yield return new WaitForSeconds(.01f);
		}
	}


}
