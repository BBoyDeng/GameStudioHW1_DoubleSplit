using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportTrigger : MonoBehaviour {

	public GameObject gate;

	void OnTriggerStay (Collider other) {
		gate.SetActive (false);
	}

	void OnTriggerExit (Collider other) {
		gate.SetActive (true);
	}
}


