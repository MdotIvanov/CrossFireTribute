using UnityEngine;
using System.Collections;

public class EnemyAmmo : MonoBehaviour {
	
	public float forceMultiplier = 100f;
	
	// Use this for initialization
	void Start () {
		var dir = transform.rotation * Vector2.up;
		rigidbody2D.AddForce (dir * forceMultiplier);
	}
	
	void OnTriggerEnter2D(Collider2D other){
		Destroy (gameObject);
		if (other.gameObject.tag == "Player" ){
			Destroy (other.gameObject);
		}
	}
}
