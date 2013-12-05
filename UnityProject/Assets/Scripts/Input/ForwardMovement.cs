﻿using UnityEngine;
using System.Collections;

public class ForwardMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if( Input.GetKey( KeyCode.W ) ) { 
			transform.position += new Vector3(0.0f, 0.0f, 1.0f);	
		}
		if( Input.GetKey( KeyCode.S ) ) { 
			transform.position += new Vector3(0.0f, 0.0f,-1.0f);	
		}
		if( Input.GetKey( KeyCode.A ) ) { 
			transform.position += new Vector3(-1.0f, 0.0f, 0.0f);	
		}
		if( Input.GetKey( KeyCode.D ) ) { 
			transform.position += new Vector3(1.0f, 0.0f, 0.0f);	
		}
		
	}
}
