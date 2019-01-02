using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

	public float distance;
	public int count;
	public string message;
	private bool finished;

	// Use this for initialization
	void Start () {
		/*
		distance = 1.25f;
		count = 25;
		message = "This is fun!";
		finished = false;

		Debug.Log ("The distance value is " + distance);
		Debug.Log ("The count is " + count);
		Debug.Log (message);
		Debug.Log ("The value of finished is " + finished);

		if (count == 0) {
			Debug.Log ("The variable count is 0.");	
		} else {
		
		}
*/
		int num;
		num = double_it (5);
		Debug.Log (num);
	}
	
	// Update is called once per frame
	void Update () {
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

	int double_it(int input_num) {
		return input_num * 2;
	}
}
