using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public int buttonWidth ;
	public int buttonHeight ;
	public GUISkin mySkin;

	void Start(){
		Time.timeScale = 1;
	}

	void OnGUI () {
		GUI.skin = mySkin;
		//Go to Play
		if (GUI.Button (new Rect (Screen.width / 2 - (buttonWidth/2) , Screen.height / 3,buttonWidth, buttonHeight), "START")) {
			Application.LoadLevel ("Level1");
			GetComponents<AudioSource>()[0].Play();
		}
		//Go to How to play
		 if (GUI.Button (new Rect (Screen.width / 2 -(buttonWidth/2) , Screen.height / 2,buttonWidth, buttonHeight), "HOW TO PLAY")) {
			Application.LoadLevel ("HowtoPlay");
			GetComponents<AudioSource>()[0].Play();
		}
		//Quit game
		 if (GUI.Button (new Rect (Screen.width / 2 - (buttonWidth/2) , 2 * Screen.height / 3,buttonWidth, buttonHeight), "EXIT")) {
			Application.Quit ();
			GetComponents<AudioSource>()[0].Play();
		}
	
	}

}
