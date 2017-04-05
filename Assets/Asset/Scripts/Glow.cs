using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour {

	private Renderer ren;
	private GameObject tile;

	void Start(){
		
		ren = GetComponent<Renderer> ();
		tile = GetComponent<GameObject> ();

	}

	// Update is called once per frame
	void OnTriggerEnter (Collider player) {
		Debug.Log ("collide");
		if (player.tag == "Player") {
			Debug.Log (tile.tag);
			switch (gameObject.tag) {

			case ("red"):
				ren.material.color = new Color( 229,89  ,52 );
				break;
			case ("yellow"):
				ren.material.color  = new Color(253,231,76);
				break;
			case ("blue"):
				ren.material.color  = new Color( 91,192  ,235 );
				break;
			case ("green"):
				ren.material.color  = new Color( 155, 197 ,61 );
				break;
			}

		}
	}

	void OnTriggerExit(Collider player){
		if (player.tag == "Player") {
			switch (gameObject.tag) {

			case ("red"):
				ren.material.color  = new Color(161 , 43 , 12);
				break;
			case ("yellow"):
				ren.material.color  = new Color(165 ,148  ,22 );
				break;
			case ("blue"):
				ren.material.color  = new Color(30 ,97  ,126 );
				break;
			case ("green"):
				ren.material.color  = new Color(111 ,144  ,35 );
				break;
			}

		}
	}
}
