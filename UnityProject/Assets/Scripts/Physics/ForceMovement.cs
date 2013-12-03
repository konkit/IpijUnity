using UnityEngine;
using System.Collections;

public class ForceMovement : MonoBehaviour {
	
	public float forceValue = 20f;
	public float torqueValue = 15f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKey( KeyCode.W ) ) { 
			rigidbody.AddForce( transform.forward * forceValue );	
		}
		if( Input.GetKey( KeyCode.S ) ) { 
			GetComponent<Rigidbody>().AddForce( -transform.forward * forceValue );		
		}
		if( Input.GetKey( KeyCode.A ) ) { 
			rigidbody.AddTorque( Vector3.up * -torqueValue );
		}
		if( Input.GetKey( KeyCode.D ) ) { 
			rigidbody.AddTorque( Vector3.up * torqueValue );	
		}
	}
}
