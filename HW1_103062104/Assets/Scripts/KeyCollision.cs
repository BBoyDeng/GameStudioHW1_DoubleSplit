using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollision : MonoBehaviour {

	public GameObject gate;

	void OnCollisionEnter (Collision other) {
		gate.SetActive (false);
		Destroy (gameObject);
	}

}
