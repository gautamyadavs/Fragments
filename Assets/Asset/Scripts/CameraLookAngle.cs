using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAngle : MonoBehaviour {

	public float XSensitivity = 0.2f;


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		float mouseX = Input.GetAxis ("Mouse X") * XSensitivity;


		transform.Rotate(Vector3.up * mouseX * XSensitivity ,Space.World);

	}
}
