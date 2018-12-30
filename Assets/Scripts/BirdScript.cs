﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("right")) {
			transform.Translate (0.2f, 0f, 0f);
		}
		if (Input.GetKey ("left")) {
			transform.Translate (-0.2f, 0f, 0f);
		}
		if (Input.GetKey ("up")) {
			transform.Translate (0f, 0.2f, 0f);
		}
		if (Input.GetKey ("down")) {
			transform.Translate (0f, -0.2f, 0f);
		}
	}
}
