using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public float time ;
	public Text ScoreTxt;
	public Text HitTxt;
	public static int Score = 0;
	public static int Hit = 0;
	public static int HP = 1;
	
	void Start () {
		Score = 0;
		Hit = 0;
		HP = 1;
	}
	
	public static void EggScore(){
		Score++;
	}

	public static void BonusScore(){
		Score += 10;
	}

	public static void IncreaseHit(){
		Hit++;
	}

	public static void DecreaseScore(){
		Score -= 20;
	}

	public static void DecreaseHit(){
		Hit--;
	}

	public static void DecreaseHP(){
		HP--;
	}

	public static IEnumerator SpeedUp(){
		MonsterController.maxSpeed = 6f;
		yield return new WaitForSeconds (3);
		MonsterController.maxSpeed = 3f;
	}

	void Update () {
		ScoreTxt.text = "SCORE: " + Score;
		HitTxt.text = "HIT: " + Hit;
		time += Time.deltaTime;
	}

	public void hitClick(){
		if(Score >= 20){
			UIManager.IncreaseHit();
			UIManager.DecreaseScore();
			GetComponents<AudioSource> () [0].Play ();
		}
	}

/*
	public GUISkin mySkin;

	void OnGUI(){
		GUI.skin = mySkin;
		//GUI.Label (new Rect (Screen.width / 2 +100, 10, 200, 200), "SCORE: " + playerScore);
		//GUI.Label (new Rect (Screen.width / 2 -200, 10, 200, 200), "Live: " + playerLives);
		//GUI.Label (new Rect (Screen.width / 2 + 250 , 10, 200, 200), "Hit: " + playerHit);
		//GUI.Label (new Rect (Screen.width / 2 - 300 , 0, 200, 200), "Time: " + time);
		
		//if (playerLives == 0) {
		//	GUI.Label (new Rect (Screen.width / 2 , Screen.height / 3 -100, 200, 200), "GAMEOVER");
		//	Time.timeScale = 0;
		//	if (GUI.Button (new Rect (Screen.width / 2, Screen.height / 3, 100, 64), "RESTART")){
		
		//	}
		//}

		//When Click "HIT" to Convert 1 hit
		if (GUI.Button (new Rect (Screen.width / 2 + 350, 10, 50, 20), "Hit")) {
			if(Score >= 20){
				UIManager.IncreaseHit();
				UIManager.DecreaseScore();
				GetComponents<AudioSource> () [0].Play ();
			}
		} 
	}
*/

}