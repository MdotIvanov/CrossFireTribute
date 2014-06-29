using UnityEngine;
using System.Collections;
using System.Linq;

public class BulletController : MonoBehaviour {

	public float forceMultiplier = 100f;
	public string[] killTags = { "Border", "Block", "Enemey" };

	// Use this for initialization
	void Start () {
		var dir = transform.rotation * Vector2.up;
		rigidbody2D.AddForce (dir * forceMultiplier);
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if (killTags.Contains(other.gameObject.tag)) {
			Destroy (gameObject);
        }
	}
}
