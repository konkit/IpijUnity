using UnityEngine;
using System.Collections;

public class ParticlesDestroyer : MonoBehaviour {
	
	public float timeToLive = 5.0f;
	
	// Use this for initialization
	void Start () {
		Invoke ("DestroyParticles", timeToLive);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void DestroyParticles() {
		Destroy(gameObject);
	}
}
