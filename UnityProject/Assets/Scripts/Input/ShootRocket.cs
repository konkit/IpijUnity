using UnityEngine;
using System.Collections;

public class ShootRocket : MonoBehaviour {
	
	public GameObject bulletPrefab;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKey(KeyCode.Space) ) {
			Vector3 spawnPosition = transform.position;
				spawnPosition += transform.forward * 2.0f;
			
			Instantiate ( bulletPrefab, spawnPosition, Quaternion.identity );
		}
	}
}
