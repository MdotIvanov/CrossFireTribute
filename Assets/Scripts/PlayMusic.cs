using UnityEngine;
using System.Collections;

public class PlayMusic : MonoBehaviour {

	private static PlayMusic instance;

	void OnGUI () {
		if (GUI.Button (new Rect (25, 25, 100, 30), "Button")) {
			// This code is executed when the Button is clicked
		}
	}

	// Use this for initialization
	void Start () {
		instance = this;
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
}
