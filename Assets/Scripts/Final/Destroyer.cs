using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

	public int times;
	
	void Update () {
		Destroy(gameObject,times);
	}
}
