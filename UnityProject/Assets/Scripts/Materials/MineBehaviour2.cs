using UnityEngine;
using System.Collections;

public class MineBehaviour2 : MonoBehaviour {
	
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
		
		other.gameObject.rigidbody.AddExplosionForce( explosionForceValue, 
													transform.position, 
													explosionRadius,
													1.0f);
		
		ExplosionSpawner explosionSpawner = GetComponent<ExplosionSpawner>();
			explosionSpawner.SpawnExplosion();
		
		Destroy(gameObject);
	}
}


