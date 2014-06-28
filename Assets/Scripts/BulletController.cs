using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody2D.AddForce (Vector2.up * 100);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
