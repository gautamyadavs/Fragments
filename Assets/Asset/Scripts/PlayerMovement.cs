using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

	public float speed = 5.0f;
	public float jumpForce = 5.0f;

	private static Collider presentTile;

	private CharacterController player;
	private Vector3 movement;
	private Transform pos;

	// Use this for initialization
	void Start () {
		player = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (player.isGrounded == true) {
			
			movement = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
			movement = transform.TransformDirection (movement);
			movement *= speed;
			if(Input.GetButton("Jump")){
				movement.y = jumpForce;

			}
		}
		movement += Physics.gravity * Time.deltaTime;
		player.Move (movement * Time.deltaTime);
		if (transform.position.y <= -20) {
			SceneManager.LoadScene ("Level1");
		}



	}


	void OnControllerColliderHit(ControllerColliderHit hit) {
		presentTile = hit.collider;
		PlayerTopMovement.presentTile = presentTile;

	}





}
