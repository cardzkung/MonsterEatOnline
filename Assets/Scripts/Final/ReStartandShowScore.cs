using UnityEngine;
using System.Collections;

public class ReStartandShowScore : MonoBehaviour {
	
	public GUISkin GameoverSkin;

	void Start(){
		Time.timeScale = 1;
	}

	void OnGUI () {
		GUI.skin = GameoverSkin;
		//Show HP
		if (UIManager.HP == 0) {
			//Show GameOver
			GUI.Label (new Rect (Screen.width / 2 - 110, Screen.height / 3 - 80, 250, 100), "GAMEOVER");
			//Show Score
			GUI.Label (new Rect (Screen.width / 2 - 90, Screen.height / 2 - 70, 250, 100), "SCORE : " + UIManager.Score);
			Time.timeScale = 0;
			//Restart
			if (GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height / 2 + 150, 100, 40), "RESTART")) {
				Application.LoadLevel (2);
				GetComponents<AudioSource> () [2].Play ();
			}
			//Go to Menu
			if (GUI.Button (new Rect (Screen.width / 2 - 200, Screen.height / 2 + 150, 100, 40), "MENU")) {
				Application.LoadLevel ("Menu");
				GetComponents<AudioSource> () [2].Play ();
			}
			//Quit game
			if (GUI.Button (new Rect (Screen.width / 2 + 100, Screen.height / 2 + 150, 100, 40), "EXIT")) {
				Application.Quit ();
				GetComponents<AudioSource> () [2].Play ();
			}
		}
	}
}
