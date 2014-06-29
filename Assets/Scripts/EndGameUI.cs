using UnityEngine;
using System.Collections;

public class EndGameUI : MonoBehaviour {
	public static int finalScore;
	public static float minSpawn = 1;
	public static float maxSpawn = 2;
	public static float enemyBulletForce = 200;

	public static void StartEasy ()
	{
		minSpawn = 2;
		maxSpawn = 5;
		enemyBulletForce = 100;
		Application.LoadLevel ("Game");
	}

	public static void StartNormal ()
	{
		minSpawn = 1;
		maxSpawn = 3;
		enemyBulletForce = 200;
		Application.LoadLevel ("Game");
	}

	public static void StartDifficult ()
	{
		minSpawn = 0.2f;
		maxSpawn = 0.7f;
		enemyBulletForce = 400;
		Application.LoadLevel ("Game");
	}

	void OnGUI() {
		string yourFinalScoreIs = string.Format ("Your score is {0}", finalScore);

		float maxWidth = 200;
		float height = 30;
		float space = 10;

		float xStart = (Screen.width - maxWidth) / 2;
		float yStart = (Screen.height - 5 * height + 4 * space) / 2;

		GUI.Label (new Rect (xStart, yStart, maxWidth, height), yourFinalScoreIs);
		yStart += space + height;
		if (GUI.Button(new Rect(xStart, yStart, maxWidth, height), "Easy")) {
			StartEasy ();
		}
		yStart += space + height;
		if (GUI.Button(new Rect(xStart, yStart, maxWidth, height), "Normal")) {
			StartNormal ();
		}
		yStart += space + height;
		if (GUI.Button(new Rect(xStart, yStart, maxWidth, height), "Difficult")) {
			StartDifficult ();
		}
		yStart += space + height;
		if (GUI.Button(new Rect(xStart, yStart, maxWidth, height), "Quit")) {
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
