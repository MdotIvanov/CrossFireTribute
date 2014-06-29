using UnityEngine;
using System.Collections;

public class HeroController : MonoBehaviour {
	
	public float force = 2; 
	public float speed; 
	public Transform spawnUp, spawnDown, spawnLeft, spawnRight;
	public GameObject bulletPrefab;
    public AudioClip fireClip;
    public AudioClip deathClip;
	
	// Use this for initialization
	void Start () {
	}
	
	void Update() {
		if (Input.GetButtonDown("FireRight"))
		{
			Instantiate(bulletPrefab, spawnRight.position, Quaternion.Euler(0,0,270));
			audio.clip = fireClip;
			audio.Play();
		} else if (Input.GetButtonDown("FireLeft")) {
			Instantiate(bulletPrefab, spawnLeft.position, Quaternion.Euler(0,0,90));
			audio.clip = fireClip;
			audio.Play();
		}
		else if (Input.GetButtonDown("FireUp"))
		{
			Instantiate(bulletPrefab, spawnUp.position, Quaternion.Euler(0,0,0));
			audio.clip = fireClip;
			audio.Play();
		}
		else if (Input.GetButtonDown("FireDown"))
		{
			Instantiate(bulletPrefab, spawnDown.position, Quaternion.Euler(180,0,0));
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
		
		if(x > 0.0f)
		{
			//rigidbody2D.AddForce(Mathf.Sign(x) * Vector2.right * force);
			pos.x += Mathf.Sign(x) * speed;

			transform.rotation = Quaternion.Euler(0,0,270);
		}if(x < 0.0f)
		{
			//rigidbody2D.AddForce(Mathf.Sign(y) * Vector2.up * force);
			pos.x +=  Mathf.Sign(x) * speed;
			transform.rotation =  Quaternion.Euler(0,0,90);
		}
		
		if(y > 0.0f)
		{
			//rigidbody2D.AddForce(Mathf.Sign(y) * Vector2.up * force);
			pos.y +=  Mathf.Sign(y) * speed;
			transform.rotation =  Quaternion.Euler(0,0,0);
		}if(y < 0.0f)
		{
			//rigidbody2D.AddForce(Mathf.Sign(y) * Vector2.up * force);
			pos.y +=  Mathf.Sign(y) * speed;
			transform.rotation =  Quaternion.Euler(180,0,0);
		}
		
		transform.position = pos;
	}
	
	void OnTriggerEnter(Collider other){
        Destroy(this.rigidbody2D);
    }

    void OnDestroy()
    {
		PlayMusic.Play (deathClip, transform.position);
		Application.LoadLevel("Game");
    }
}
