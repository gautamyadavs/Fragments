using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile : MonoBehaviour {
	public float x=0f;
	public float y=0f;
	public float z=0f;
	public float cx=0f;
	public float cy=0f;
	public float cz=0f;
	public float t=1f; // speed
	public float l= 10f; // length from 0 to endpoint.

	void Update() 
	{
		Vector3 pos = new Vector3 (cx+x*(Mathf.PingPong (t * Time.time, l)), cy+y*(Mathf.PingPong (t * Time.time, l)), cz+z*(Mathf.PingPong (t * Time.time, l)));
		transform.position = pos;
	}
}