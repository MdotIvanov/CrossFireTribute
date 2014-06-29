using UnityEngine;
using System.Collections;
using System.Linq;

public class MasterSpawnerController : MonoBehaviour {
	private GameObject[] spawnPositions;
	public GameObject[] enemies;
	public float minWait = 1;
	public float maxWait = 3;
	public Vector3 spawnerOffset;

	private float cameraWidthOver2;
	private float cameraHeightOver2;

	// Use this for initialization
	void Start () {
		spawnPositions = GameObject.FindGameObjectsWithTag ("Respawn");

		var c = Camera.main;
		cameraHeightOver2 = c.orthographicSize;
		cameraWidthOver2 = cameraHeightOver2 * c.aspect;

		StartCoroutine (SpawnNext());
	}

	IEnumerator SpawnNext() {
		while (gameObject) {
			GameObject spawner;
			do {
				spawner = spawnPositions[Random.Range (0, spawnPositions.Length)];
				yield return new WaitForEndOfFrame();
			} while (!IsPosAcceptable(spawner.transform.position));
			
			int nextEnemy = Random.Range (0, enemies.Length);

			var enemy = (GameObject)Instantiate (enemies [nextEnemy], 
			            spawner.transform.position,
			            spawner.transform.rotation);

			enemy.GetComponent<EnemyControllerBase>().ammoDirection = spawner.GetComponent<IndividualSpawner>().bulletDirection;

			yield return new WaitForSeconds (Random.Range (minWait, maxWait));
		}
	}

	bool IsPosAcceptable(Vector3 pos) {
		var test = pos + spawnerOffset;
		bool insideCamera = 
			test.x > -cameraWidthOver2 && test.x < cameraWidthOver2
						&& test.y > -cameraHeightOver2 && test.y < cameraHeightOver2;

		var enemies = GameObject.FindGameObjectsWithTag ("Enemey");
		if (enemies != null) {
			bool noneWithSamePos = !enemies.Where (e => e.transform.position == pos).Any();
			return insideCamera && noneWithSamePos;
		} else {
			return insideCamera;
		}
	}
}
