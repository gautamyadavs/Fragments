using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewChange : MonoBehaviour {

	public Camera playerCamera;
	public Camera otherCamera;
	public GameObject player;
	public GameObject otherplayer;
	public float positionOfOtherAppearance = 1f;


	void Start(){
		
		playerCamera.enabled = true;
		otherCamera.enabled = false;

	}
	void Update(){
		RaycastHit hit;

		if (Physics.Raycast (transform.position, Vector3.down, out hit)) {
			otherplayer.transform.position = new Vector3 (transform.position.x, hit.transform.position.y+positionOfOtherAppearance, transform.position.z);
		}
		else
		    otherplayer.transform.position = new Vector3 (transform.position.x, otherplayer.transform.position.y, transform.position.z);
		if (Input.GetMouseButtonDown (1)){
			playerCamera.enabled = !playerCamera.enabled;
			otherCamera.enabled = !otherCamera.enabled;
		}

		if (otherCamera.enabled) {
			
			otherplayer.SetActive (true);
			player.SetActive (false);


		} else {
			
			otherplayer.SetActive (false);
			player.SetActive (true);

		}
			

	}

}
