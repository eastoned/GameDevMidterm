using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour {
		public float maxRotation;
		public float lookUp;
	// Use this for initialization
	void Start () {
		lookUp = Input.GetAxis("Mouse Y");
	}
	
	// Update is called once per frame
	void Update () {
		
		
		transform.Rotate(0f, Input.GetAxis("Mouse X") * Time.deltaTime * 360f, 0f);
		//if (lookUp < maxRotation) {
		//transform.Rotate(0f, 0f, lookUp * Time.deltaTime * 400f);
		//} else {
		//	transform.Rotate (0f, 0f, 0f);
		//}
	}
}
