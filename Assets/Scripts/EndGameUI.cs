using UnityEngine;
using System.Collections;

public class EndGameUI : MonoBehaviour {
	public static int finalScore;

	void OnGUI() {
		string yourFinalScoreIs = string.Format ("Your score is {0}", finalScore);
		string replay = "Replay";
		string quit = "Quit";

		float maxWidth = 200;
		float height = 30;
		float space = 10;

		float xStart = (Screen.width - maxWidth) / 2;
		float yStart = (Screen.height - 3 * height + 2 * space) / 2;

		GUI.Label (new Rect (xStart, yStart, maxWidth, height), yourFinalScoreIs);
		yStart += space + height;
		if (GUI.Button(new Rect(xStart, yStart, maxWidth, height), replay)) {
			Application.LoadLevel("Game");
		}
		yStart += space + height;
		if (GUI.Button(new Rect(xStart, yStart, maxWidth, height), quit)) {
			Application.Quit();
		}

		/*
		GUILayout.BeginArea (new Rect (0, 0, Screen.width, Screen.height));
		GUILayout.FlexibleSpace ();
		GUILayout.BeginVertical (GUILayout.MaxWidth(200));
		GUILayout.FlexibleSpace ();

		GUILayout.Label (yourFinalScoreIs);
		if (GUILayout.Button(replay)) {
			Application.LoadLevel("Game");
		}
		if (GUILayout.Button(quit)) {
			Application.Quit();
		}

		GUILayout.FlexibleSpace();
		GUILayout.EndVertical();
		GUILayout.FlexibleSpace();
		GUILayout.EndArea ();
		*/



	}
}
