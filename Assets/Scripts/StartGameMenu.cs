using UnityEngine;
using System.Collections;

public class StartGameMenu : MonoBehaviour {



	
	// Update is called once per frame
	void OnGUI () {
		float height = 30;
		float space = 10;
		float maxWidth = 200;

		float xStart = (Screen.width - maxWidth) / 2;
		float yStart = (Screen.height - 5 * height + 4 * space) / 2;
		
		GUI.Label (new Rect (xStart, yStart, maxWidth, height), "CrossFire Tribute");
		yStart += space + height;
		if (GUI.Button(new Rect(xStart, yStart, maxWidth, height), "Easy")) {
			EndGameUI.StartEasy();
		}
		yStart += space + height;
		if (GUI.Button(new Rect(xStart, yStart, maxWidth, height), "Normal")) {
			EndGameUI.StartNormal();
		}
		yStart += space + height;
		if (GUI.Button(new Rect(xStart, yStart, maxWidth, height), "Difficult")) {
			EndGameUI.StartDifficult();
		}
		yStart += space + height;
		if (GUI.Button(new Rect(xStart, yStart, maxWidth, height), "Quit")) {
			Application.Quit();
		}
	}
}
