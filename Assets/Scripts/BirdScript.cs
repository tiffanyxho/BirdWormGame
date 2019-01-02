using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

	public float distance;
	public int count;
	public string message;
	private bool finished;
	public GameObject alive_worm;

	// Use this for initialization
	void Start () {
		/*
		distance = 1.25f;
		count = 25;
		message = "This is fun!";
		finished = false;
*/
	}
	
	/**
	 *  Moves bird when arrow keys are pressed
	 */
	void Update () {
		// Bird is moved using the arrow keys
		if (Input.GetKey ("right")) {
			Flip ("right");
			transform.Translate (0.2f, 0f, 0f);
		}
		if (Input.GetKey ("left")) {
			Flip ("left");
			transform.Translate (-0.2f, 0f, 0f);
		}
		if (Input.GetKey ("up")) {
			transform.Translate (0f, 0.2f, 0f);
		}
		if (Input.GetKey ("down")) {
			transform.Translate (0f, -0.2f, 0f);
		}
	}

	/**
	 * Flips the direction the bird is facing based on the arrow key pressed
	 */
	public void Flip(string direction) {
		var scale = transform.localScale;

		// direction bird is facing
		if (direction == "right") {
			scale.x = 1.0f;
		}
		if (direction == "left") {
			scale.x = -1.0f;
		}

		// set bird's transform scale values to scale's values
		transform.localScale = scale;
	}

	void OnCollisionEnter2D (Collision2D bird_hit) {
		if (bird_hit.gameObject.name == "theworm") {
			alive_worm.SetActive (false);
		}
	}
}