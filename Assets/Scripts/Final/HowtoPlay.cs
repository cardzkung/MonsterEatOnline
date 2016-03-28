using UnityEngine;
using System.Collections;

public class HowtoPlay : MonoBehaviour {

	//public GUISkin mySkin;
	public int buttonWidth ;
	public int buttonHeight ;

	void Start(){
		Time.timeScale = 1;
	}
/*
	void OnGUI(){
		GUI.skin = mySkin;
		// Go to Menu
		if (GUI.Button (new Rect (4 *Screen.width / 5 - (buttonWidth/2) , 5 * Screen.height/6,buttonWidth, buttonHeight), "PLAY")) {
			Application.LoadLevel ("Level1");
			GetComponents<AudioSource>()[0].Play();
		}
		//Go to Play
		if (GUI.Button (new Rect ( Screen.width / 5 , 5 * Screen.height/6,buttonWidth, buttonHeight), "MENU")) {
			Application.LoadLevel ("Menu");
			GetComponents<AudioSource>()[0].Play();
		}
	}
*/
	public void playClick(){
		Application.LoadLevel ("Level1");
		GetComponents<AudioSource> () [0].Play ();
	}

	public void menuClick(){
		Application.LoadLevel ("Menu");
		GetComponents<AudioSource> () [0].Play ();
	}
}
