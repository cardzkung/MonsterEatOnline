using UnityEngine;
using System.Collections;

public class ChickMove : MonoBehaviour {

	public float forceX = 0f;
	public float forceY = 0f;
	public float time;
	
	
	void Start () {

		//Movement Chicken
		float speed = Random.Range(1, 2);
		Vector2 force = new Vector2 (forceX*speed, forceY*speed);
		GetComponent<Rigidbody2D> ().AddForce (force);
		
	}
	
	void Update () {
		//Destroy Chicken
		Destroy (gameObject,time);
	}
}
