using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworkDestroy : MonoBehaviour {

	float timeStart;

	// Use this for initialization
	void Start () {
		timeStart = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if ((Time.time - timeStart) >= 14.0f) {
			Destroy (gameObject);
		}
	}
}
