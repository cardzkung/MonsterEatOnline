using UnityEngine;
using System.Collections;

public class MonsterController : MonoBehaviour {

	public static float maxSpeed = 4f;
	private Rigidbody2D rb2D;
	Animator anim;
	

	void Start () {
		rb2D = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate () {
		//Character's Speed
		float moveX = Input.GetAxis("Horizontal");
		float moveY = Input.GetAxis("Vertical");
		rb2D.velocity = new Vector2 (moveX * maxSpeed, rb2D.velocity.y);
		rb2D.velocity = new Vector2 (rb2D.velocity.x, moveY * maxSpeed);

		//Character's Animate
		if (moveX > 0) {
			anim.SetBool ("Right", true);
			anim.SetBool ("Left", false);
			anim.SetBool ("Down", false);
			anim.SetBool ("Up", false);
		} else if (moveX < 0) {
			anim.SetBool ("Left", true);
			anim.SetBool ("Right", false);
			anim.SetBool ("Down", false);
			anim.SetBool ("Up", false);
		} else if (moveY > 0) {
			anim.SetBool ("Up", true);
			anim.SetBool ("Down", false);
			anim.SetBool ("Left", false);
			anim.SetBool ("Right", false);
		} else if (moveY < 0) {
			anim.SetBool ("Down", true);
			anim.SetBool ("Up", false);
			anim.SetBool ("Left", false);
			anim.SetBool ("Right", false);
		} else if (moveX == 0 && moveY == 0) {
			anim.SetBool ("Down", false);
			anim.SetBool ("Up", false);
			anim.SetBool ("Left", false);
			anim.SetBool ("Right", false);
		} 
	}

	void OnTriggerEnter2D (Collider2D hitInfo){
		//Egg's Effect
		if (hitInfo.gameObject.tag == "Food") {
			Destroy (hitInfo.gameObject);
			//GetComponent<Scores> ().playerScore += 1;
			UIManager.EggScore();
			transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
			//GameObject.FindGameObjectWithTag("PlayerCam").GetComponent<CircleCollider2D>().radius += 0.1f;
			GetComponents<AudioSource> () [0].Play ();
		} 
		//Bonus's Effect
		else if (hitInfo.gameObject.tag == "Bonus") {
			Destroy (hitInfo.gameObject);
			//GetComponent<Scores> ().playerScore += 10;
			UIManager.BonusScore();
			transform.localScale -= new Vector3 (0.5f, 0.5f, 0.5f);
			GetComponents<AudioSource> () [0].Play ();
		} 
		//Hit's Effect
		else if (hitInfo.gameObject.tag == "Sword") {
			Destroy (hitInfo.gameObject);
			//GetComponent<Scores> ().playerHit += 1;
			UIManager.IncreaseHit();
			GetComponents<AudioSource> () [0].Play ();
		} 
		//Enemy's Effect. If you no Hit. Your HP -1.
		else if (hitInfo.gameObject.tag == "Enemy" && UIManager.Hit == 0 
		           && UIManager.HP >= 1) {
			//GetComponent<Scores> ().playerLives -= 1;
			UIManager.DecreaseHP();
		} 
		//Enemy's Effect. If you have Hit, Your Hit -1 but your HP not decrease.
		else if (hitInfo.gameObject.tag == "Enemy" && UIManager.Hit >= 0) {
			Destroy (hitInfo.gameObject);
			//GetComponent<Scores> ().playerHit -= 1;
			UIManager.DecreaseHit();
			GetComponents<AudioSource> () [1].Play ();
		} //else if (hitInfo.gameObject.tag == "Heart") {
			//Destroy (hitInfo.gameObject);
			//GetComponent<Scores> ().playerLives += 1;
		 else if (hitInfo.gameObject.tag == "SpeedUp") {
			Destroy (hitInfo.gameObject);
			StartCoroutine (UIManager.SpeedUp());
		}
	}

}
