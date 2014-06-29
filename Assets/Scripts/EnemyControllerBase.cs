using UnityEngine;
using System.Collections;

public class EnemyControllerBase : MonoBehaviour {

	public float minWaitShoot = 1;
	public float maxWaitShoot = 2;
	public GameObject enemyAmmoPrefab;

	// Use this for initialization
	void Start () {
		StartCoroutine (Shoot ());
	}

	IEnumerator Shoot() {
		while (gameObject) {
			yield return new WaitForSeconds(Random.Range(minWaitShoot, maxWaitShoot));

			Instantiate(
				enemyAmmoPrefab,
				transform.position,
				enemyAmmoPrefab.transform.rotation);
		}
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
