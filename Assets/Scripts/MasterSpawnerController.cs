using UnityEngine;
using System.Collections;

public class MasterSpawnerController : MonoBehaviour {
	private GameObject[] spawnPositions;
	public GameObject[] enemies;
	public float minWait = 1;
	public float maxWait = 3;

	// Use this for initialization
	void Start () {
		spawnPositions = GameObject.FindGameObjectsWithTag ("Respawn");

		StartCoroutine (SpawnNext());
	}

	IEnumerator SpawnNext() {
		while (gameObject) {
			int nextSpawnPoint = Random.Range (0, spawnPositions.Length);
			int nextEnemy = Random.Range (0, enemies.Length);

			var spawner = (spawnPositions[nextSpawnPoint]);

			var enemy = (GameObject)Instantiate (enemies [nextEnemy], 
			            spawner.transform.position,
			            spawner.transform.rotation);

			enemy.GetComponent<EnemyControllerBase>().ammoDirection = spawner.GetComponent<IndividualSpawner>().bulletDirection;

			yield return new WaitForSeconds (Random.Range (minWait, maxWait));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
