using UnityEngine;
using System.Collections;

public class ChickParticle : MonoBehaviour {

	public ParticleSystem ChickDieEffect;
	
	void OnTriggerEnter2D (Collider2D hitInfo){
		//Particle Chicken
		if (hitInfo.gameObject.tag == "Player") {
			ParticleSystem newChickDieEffect = Instantiate (ChickDieEffect, transform.position,
			                                               Quaternion.identity)as ParticleSystem;
			Destroy (newChickDieEffect.gameObject, 2);
		}
	}
}
