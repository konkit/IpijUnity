using UnityEngine;
using System.Collections;

public class MoveAndRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {		
		if( Input.GetKey( KeyCode.W ) ) { 
			transform.Translate( new Vector3(0.0f, 0.0f, 1.0f) );	
		}
		if( Input.GetKey( KeyCode.S ) ) { 
			transform.Translate( new Vector3(0.0f, 0.0f,-1.0f) );	
		}
		if( Input.GetKey( KeyCode.A ) ) { 
			transform.Rotate( Vector3.up, -1.0f );	
		}
		if( Input.GetKey( KeyCode.D ) ) { 
			transform.Rotate( Vector3.up, 1.0f );	
		}		
	}
}
