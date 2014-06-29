using UnityEngine;
using System.Collections;

public class HeroController : MonoBehaviour {

	//public float force; 
	public float speed; 
	public Transform spawnUp, spawnDown, spawnLeft, spawnRight;
	public GameObject bulletPrefab;
    public AudioClip fireClip;

	// Use this for initialization
	void Start () {
	}

	void Update() {
        if (Input.GetButtonDown("FireRight"))
        {
			Instantiate(bulletPrefab, spawnRight.position, spawnRight.rotation);
            audio.clip = fireClip;
            audio.Play();
		} else if (Input.GetButtonDown("FireLeft")) {
			Instantiate(bulletPrefab, spawnLeft.position, spawnLeft.rotation);
            audio.clip = fireClip;
            audio.Play();
        }
        else if (Input.GetButtonDown("FireUp"))
        {
			Instantiate(bulletPrefab, spawnUp.position, spawnUp.rotation);
            audio.clip = fireClip;
            audio.Play();
        }
        else if (Input.GetButtonDown("FireDown"))
        {
			Instantiate(bulletPrefab, spawnDown.position, spawnDown.rotation);
            audio.clip = fireClip;
            audio.Play();
        }
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

	void OnTriggerEnter(Collider other){
		Destroy (this.rigidbody2D);
		}
}
