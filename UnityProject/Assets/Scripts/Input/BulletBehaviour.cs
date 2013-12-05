using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour {
	
	public float bulletSpeed = 0.5f;
	public float timeToDestroy = 5.0f;
	
	// Use this for initialization
	void Start () {
		Destroy(gameObject, timeToDestroy);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate( Vector3.forward * bulletSpeed );
	}
}
