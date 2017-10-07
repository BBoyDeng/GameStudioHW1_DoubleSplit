using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : MonoBehaviour {

	public GameObject player1, player2;
	public GameObject firework;
	GameObject prefab;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		// 切換 player1 與 player2
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			player1.SetActive (true);
			player2.SetActive (false);
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			player1.SetActive (false);
			player2.SetActive (true);
		}

		// 動態生成煙火
		if (Input.GetKeyDown (KeyCode.Space)) {
			prefab = Instantiate (firework);
			prefab.transform.position = new Vector3 (Random.Range(-200.0f, 200.0f), 0.0f, 800.0f);
		}
	}
}
