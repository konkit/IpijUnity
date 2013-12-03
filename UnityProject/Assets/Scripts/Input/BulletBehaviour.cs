using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour {
	
	public float bulletSpeed = 0.5f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate( Vector3.forward * bulletSpeed );
	}
}
