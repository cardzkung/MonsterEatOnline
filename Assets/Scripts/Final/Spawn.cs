using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	
	public GameObject ChickenMoveUp;
	public GameObject ChickenMoveRight;
	public GameObject ChickenMoveLeft;
	public GameObject Egg;
	public GameObject Bonus;
	public GameObject Hit;
	public GameObject SpeedUp;


	void Start () {
		InvokeRepeatingSpawn ();
	}

	//Random Time to Invoke
	void InvokeRepeatingSpawn(){
		int RandomTimeSpawnChickenMoveUp = Random.Range (15, 20);
			InvokeRepeating ("SpawnChickenMoveUp", 2f, RandomTimeSpawnChickenMoveUp);
		int RandomTimeSpawnChickenMoveRight = Random.Range (15, 20);
			InvokeRepeating ("SpawnChickenMoveRight", 2f, RandomTimeSpawnChickenMoveRight);
		int RandomTimeSpawnChickenMoveLeft = Random.Range (15, 20);
			InvokeRepeating ("SpawnChickenMoveLeft", 2f, RandomTimeSpawnChickenMoveLeft);
		int RandomTimeSpawnEgg = Random.Range (2, 4);
			InvokeRepeating ("SpawnEgg", 1f, RandomTimeSpawnEgg);
		int RandomTimeSpawnBonus = Random.Range (25, 30);
			InvokeRepeating ("SpawnBonus", 30f, RandomTimeSpawnBonus);
		int RandomTimeSpawnHit = Random.Range (50, 60);
			InvokeRepeating ("SpawnHit", 40f, RandomTimeSpawnHit);
		int RandomTimeSpawnSpeedUp = Random.Range (20, 30);
			InvokeRepeating ("SpawnSpeedUp", 20f, RandomTimeSpawnSpeedUp);
	}

	//SpawnChickenMoveUp
	void SpawnChickenMoveUp () {
		Instantiate (ChickenMoveUp, new Vector3 (Random.Range (-14, 15), -11, 0)
		             , Quaternion.identity);
	}

	//SpawnChickenMoveRight
	void SpawnChickenMoveRight(){
		Instantiate (ChickenMoveRight, new Vector3 (-19,Random.Range (-7, 7), 0)
		             , Quaternion.identity);
	}

	//SpawnChickenMoveLeft
	void SpawnChickenMoveLeft(){
		Instantiate (ChickenMoveLeft, new Vector3 (19,Random.Range (-7, 7), 0)
		             , Quaternion.identity);
	}

	//SpawnEgg
	void SpawnEgg(){
		Instantiate (Egg, new Vector3 (Random.Range (-16, 16), Random.Range (-9, 9), 0)
		             , Quaternion.identity);
	}

	//SpawnBonus
	void SpawnBonus(){
		Instantiate (Bonus, new Vector3 (Random.Range (-16, 16), Random.Range (-9, 9), 0)
		             , Quaternion.identity);
	}

	//SpawnHit
	void SpawnHit(){
		Instantiate (Hit, new Vector3 (Random.Range (-16, 16), Random.Range (-9, 9), 0)
		             , Quaternion.identity);
	}

	//SpawnSpeedUp
	void SpawnSpeedUp(){
		Instantiate (SpeedUp, new Vector3 (Random.Range (-16, 16), Random.Range (-9, 9), 0)
		             , Quaternion.identity);
	}
}
