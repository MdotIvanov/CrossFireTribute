using UnityEngine;
using System.Collections;

public class PlayMusic : MonoBehaviour {

	private static PlayMusic instance;
	private int score = 0;

	void OnGUI () {
		GUI.Label(new Rect (10, 10, 100, 20), "High Score " + score);
	}

	// Use this for initialization
	void Start () {
		instance = this;
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDestroy() {
		instance = null;
	}

	public static void Play(AudioClip clip, Vector3 pos) {
		if (!instance)	return;

		instance.transform.position = pos;
		instance.audio.PlayOneShot(clip);
	}

	public static void Score(int points)
	{
		if (!instance)	return;
		instance.score += points;
	}

}
