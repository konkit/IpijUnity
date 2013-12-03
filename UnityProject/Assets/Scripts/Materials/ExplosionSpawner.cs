using UnityEngine;
using System.Collections;

public class ExplosionSpawner : MonoBehaviour {
	
	public GameObject explosionPrefab;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void SpawnExplosion() {
		Instantiate( explosionPrefab, transform.position, Quaternion.identity );
	}
}
