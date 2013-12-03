using UnityEngine;
using System.Collections;

public class MineBehaviour : MonoBehaviour {
	
	public float explosionForceValue = 50f;
	public float explosionRadius = 50f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		Debug.Log("Boom!");
		Debug.Log(other.gameObject.name);
		other.gameObject.rigidbody.AddExplosionForce( explosionForceValue, 
													transform.position, 
													explosionRadius,
													1.0f);
		
		Destroy(gameObject);
	}
}
