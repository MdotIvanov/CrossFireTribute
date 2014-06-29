using UnityEngine;
using System.Collections;

public class HeroController : MonoBehaviour {

	//public float force; 
	public float speed; 
	public Transform spawnUp, spawnDown, spawnLeft, spawnRight;
	public GameObject bulletPrefab;


	// Use this for initialization
	void Start () {

	}

	void Update() {
		if (Input.GetButtonDown("FireRight")) {
			Instantiate(bulletPrefab, spawnRight.position, spawnRight.rotation);
		} else if (Input.GetButtonDown("FireLeft")) {
			Instantiate(bulletPrefab, spawnLeft.position, spawnLeft.rotation);
		} else if (Input.GetButtonDown("FireUp")) {
			Instantiate(bulletPrefab, spawnUp.position, spawnUp.rotation);
		} else if (Input.GetButtonDown("FireDown")) {
			Instantiate(bulletPrefab, spawnDown.position, spawnDown.rotation);
		}
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		var x = Input.GetAxis("Horizontal");
		var y = Input.GetAxis("Vertical");

		var pos = transform.position;

		//transform.rotation = Quaternion.identity;

		if (x > 0 ) 
		{
			transform.rotation = Quaternion.Euler(0,0,270);
			pos.x += Mathf.Sign(x) * speed;
		}
		if (x < 0 ) 
		{
			transform.rotation = Quaternion.Euler(0,0,90);
			pos.x += Mathf.Sign(x) * speed;
		}
		if (y > 0 ) 
		{
			transform.rotation = Quaternion.Euler(0,0,0);
			pos.y +=  Mathf.Sign(y) * speed;
		}
		if (y < 0 ) 
		{
			transform.rotation = Quaternion.Euler(180,0,0);
			pos.y +=  Mathf.Sign(y) * speed;
		}

		transform.position = pos;
	}

}
