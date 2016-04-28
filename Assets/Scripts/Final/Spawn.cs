using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Spawn : NetworkBehaviour {
	
	public GameObject ChickenMoveUp;
	public GameObject ChickenMoveRight;
	public GameObject ChickenMoveLeft;
	public GameObject Egg;
	public GameObject Bonus;
	public GameObject Hit;
	public GameObject SpeedUp;
	

	void Start () {
		CmdInvokeRepeatingSpawn();
	}

	//Random Time to Invoke
	[Command]
	void CmdInvokeRepeatingSpawn(){
		int RandomTimeSpawnChickenMoveUp = Random.Range (15, 20);
			InvokeRepeating ("CmdSpawnChickenMoveUp", 2f, RandomTimeSpawnChickenMoveUp);
		int RandomTimeSpawnChickenMoveRight = Random.Range (15, 20);
			InvokeRepeating ("CmdSpawnChickenMoveRight", 2f, RandomTimeSpawnChickenMoveRight);
		int RandomTimeSpawnChickenMoveLeft = Random.Range (15, 20);
			InvokeRepeating ("CmdSpawnChickenMoveLeft", 2f, RandomTimeSpawnChickenMoveLeft);
		int RandomTimeSpawnEgg = Random.Range (2, 4);
			InvokeRepeating ("CmdSpawnEgg", 1f, RandomTimeSpawnEgg);
//		int RandomTimeSpawnBonus = Random.Range (25, 30);
//			InvokeRepeating ("SpawnBonus", 30f, RandomTimeSpawnBonus);
//		int RandomTimeSpawnHit = Random.Range (50, 60);
//			InvokeRepeating ("SpawnHit", 40f, RandomTimeSpawnHit);
//		int RandomTimeSpawnSpeedUp = Random.Range (20, 30);
//			InvokeRepeating ("SpawnSpeedUp", 20f, RandomTimeSpawnSpeedUp);
	}

	
	[Command]
	void CmdSpawnChickenMoveUp(){
		GameObject ChickUp = (GameObject)Instantiate (ChickenMoveUp, new Vector3 (Random.Range (-14, 15), -11, 0)
		                     						, Quaternion.identity);
		NetworkServer.Spawn (ChickUp);
		//Debug.Log (1);
	}
	void CmdSpawnChickenMoveRight(){
		GameObject ChickRight = (GameObject)Instantiate (ChickenMoveRight, new Vector3 (-19,Random.Range (-7, 7), 0)
		                         					, Quaternion.identity);
		NetworkServer.Spawn (ChickRight);
		//Debug.Log (2);
	}
	void CmdSpawnChickenMoveLeft(){
		GameObject ChickLeft = (GameObject)Instantiate (ChickenMoveLeft, new Vector3 (19,Random.Range (-7, 7), 0)
		                        					, Quaternion.identity);
		NetworkServer.Spawn (ChickLeft);
		//Debug.Log (3);
	}
	void CmdSpawnEgg(){
		GameObject Eggs = (GameObject)Instantiate (Egg, new Vector3 (Random.Range (-16, 16), Random.Range (-9, 9), 0)
		                                           , Quaternion.identity);
		NetworkServer.Spawn (Eggs);
		Debug.Log (4);
	}
/*
	//SpawnChickenMoveRight
	void SpawnChickenMoveRight(){
		Network.Instantiate (ChickenMoveRight, new Vector3 (-19,Random.Range (-7, 7), 0)
		             , Quaternion.identity,0);
	}

	//SpawnChickenMoveLeft
	void SpawnChickenMoveLeft(){
		Network.Instantiate (ChickenMoveLeft, new Vector3 (19,Random.Range (-7, 7), 0)
		             , Quaternion.identity,0);
	}

	//SpawnEgg
	void SpawnEgg(){
		Instantiate (Egg, new Vector3 (Random.Range (-16, 16), Random.Range (-9, 9), 0)
		             , Quaternion.identity);
	}
*/
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
