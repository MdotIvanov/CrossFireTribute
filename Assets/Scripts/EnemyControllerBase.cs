using UnityEngine;
using System.Collections;

public enum BulletDirection { Left, Right, Up, Down }

public class EnemyControllerBase : MonoBehaviour {


	public BulletDirection ammoDirection;
	public float minWaitShoot = 1;
	public float maxWaitShoot = 2;
	public GameObject enemyAmmoPrefab;

	private Vector2 dir;

	// Use this for initialization
	void Start () {
		StartCoroutine (Shoot ());
		switch (ammoDirection) {
		case BulletDirection.Up:
			dir = Vector2.up; break;
		case BulletDirection.Down:
			dir = -Vector2.up; break;
		case BulletDirection.Left:
			dir = -Vector2.right; break;
		case BulletDirection.Right:
			dir = Vector2.right; break;
		default:
				break;
		}
	}

	IEnumerator Shoot() {
		while (gameObject) {
			yield return new WaitForSeconds(Random.Range(minWaitShoot, maxWaitShoot));

			var ammo = (GameObject)Instantiate(
				enemyAmmoPrefab,
				transform.position,
				enemyAmmoPrefab.transform.rotation);

			if (ammoDirection == BulletDirection.Up || ammoDirection == BulletDirection.Down)
			{
				ammo.transform.rotation = Quaternion.identity;
			}
			ammo.rigidbody2D.AddForce(ammo.GetComponent<EnemyAmmo>().forceMultiplier * dir);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Ammo") {
			Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
			Destroy (collision.gameObject);
		}
	}
}
