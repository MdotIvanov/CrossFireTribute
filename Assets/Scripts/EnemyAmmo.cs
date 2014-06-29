using UnityEngine;
using System.Collections;

public class EnemyAmmo : MonoBehaviour {
	
	public float forceMultiplier = 100f;
	private string[] destroyTags = { "Player", "Border" };
	
	// Use this for initialization
	void Start () {
		forceMultiplier = EndGameUI.enemyBulletForce;
	}
	
	void OnTriggerEnter2D(Collider2D other){
		var otherTagName = other.gameObject.tag;

		if (otherTagName == "Player" ){

			Destroy (other.gameObject);

        }

		if (System.Array.IndexOf(destroyTags, otherTagName) != -1) {
			Destroy(gameObject);
        }
	}
}
