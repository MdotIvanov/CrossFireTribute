using UnityEngine;
using System.Collections;

public class EnemyControllerBase : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Ammo") {
			Destroy(gameObject);
		} else if (collision.gameObject.tag == "Player") {
			Destroy (collision.gameObject);
		}
	}
}
