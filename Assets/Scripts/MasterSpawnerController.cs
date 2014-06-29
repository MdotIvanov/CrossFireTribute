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

			Instantiate (enemies [nextEnemy], 
			            spawnPositions [nextSpawnPoint].transform.position,
			            spawnPositions [nextSpawnPoint].transform.rotation);

			yield return new WaitForSeconds (Random.Range (minWait, maxWait));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
