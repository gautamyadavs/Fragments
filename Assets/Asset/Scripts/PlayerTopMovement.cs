using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopMovement : MonoBehaviour {

	public float speed = 5.0f;

	private CharacterController player;
	private Vector3 movement=Vector3.zero;
	private Transform pos;

	public static Collider presentTile;

	// Use this for initialization
	void Start () {
		player = gameObject.GetComponent<CharacterController> ();
	}

	// Update is called once per frame
	void Update () {

		Debug.Log (presentTile.tag);
		
		movement = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		movement = transform.TransformDirection (movement);
		movement *= speed;
		player.Move (movement * Time.deltaTime);



	}

	void OnControllerColliderHit(ControllerColliderHit hit) {
		if (presentTile.tag == hit.collider.tag) {

			Physics.IgnoreCollision (GetComponent<Collider> (), hit.collider);
		}

	}


}
