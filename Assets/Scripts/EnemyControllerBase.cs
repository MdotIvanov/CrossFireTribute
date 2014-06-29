using UnityEngine;
using System.Collections;

public class EnemyControllerBase : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collision2D collision) {
		if (collider.gameObject.tag == "Ammo") {
			Destroy(gameObject);
		} else if (collider.gameObject.tag == "Player") {
			Destroy (collider.gameObject);
		}
	}
}
