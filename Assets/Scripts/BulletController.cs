using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//var dir = transform.rotation * Vector3.forward;
		//var dir2d = new Vector2 (dir.x, dir.y);
		//dir2d.Normalize ();
		var dir = transform.rotation * Vector2.up;
		rigidbody2D.AddForce (dir * 100);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
