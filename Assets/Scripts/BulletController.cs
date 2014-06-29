using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public float forceMultiplier = 100f;
	public string[] killTags = { "Border", "Block", "Enemy" };

	// Use this for initialization
	void Start () {
		var dir = transform.rotation * Vector2.up;
		rigidbody2D.AddForce (dir * forceMultiplier);
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if (System.Array.IndexOf(killTags, other.gameObject.tag) != -1) {
			Destroy (gameObject);
        }
	}
}
