using UnityEngine;
using System.Collections;

public class SpawnHeart : MonoBehaviour {

	public GameObject Heart;
	// Use this for initialization
	void Start () {
		int RandomSpawn = Random.Range (120, 130);
		InvokeRepeating ("Spawn", 60f, RandomSpawn); 
	}
	
	// Update is called once per frame
	void Spawn () {
		Instantiate (Heart, new Vector3 (Random.Range (-16, 16), Random.Range (-9, 9), 0), Quaternion.identity);
	}
}
