using UnityEngine;
using System.Collections;

public class HeroController : MonoBehaviour {

	//public float force; 
	public float speed; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		var x = Input.GetAxis("Horizontal");
		var y = Input.GetAxis("Vertical");

		var pos = transform.position;

		if(x != 0.0f)
		{
			//rigidbody2D.AddForce(Mathf.Sign(x) * Vector2.right * force);
			pos.x += Mathf.Sign(x) * speed;
		}

		if(y != 0.0f)
		{
			//rigidbody2D.AddForce(Mathf.Sign(y) * Vector2.up * force);
			pos.y +=  Mathf.Sign(y) * speed;
		}

		transform.position = pos;
		transform.rotation = Quaternion.identity;
	}
}
