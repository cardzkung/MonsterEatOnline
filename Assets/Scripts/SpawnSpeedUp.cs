using UnityEngine;
using System.Collections;

public class SpawnSpeedUp : MonoBehaviour {

	public GameObject SpeedUp;
	// Use this for initialization
	void Start () {
		int RandomSpawn = Random.Range (80, 100);
		InvokeRepeating ("Spawn", 1f, RandomSpawn); 
	}
	
	// Update is called once per frame
	void Spawn () {
		Instantiate (SpeedUp, new Vector3 (Random.Range (-16, 16), Random.Range (-9, 9), 0), Quaternion.identity);
	}
}
