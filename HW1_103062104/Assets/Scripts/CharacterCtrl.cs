using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCtrl : MonoBehaviour {

	public GameObject cam; 
	public GameObject forwardStar, rightStar;

	Vector3 forwardDir, rightDir;

	float x, y;

	// Use this for initialization
	void Start () {
		Vector3 angle = cam.transform.eulerAngles;
		x = angle.y;
		y = angle.x;
	}
	
	// Update is called once per frame
	void Update () {
		// 角色前後左右移動
		if (Input.GetKey (KeyCode.W))
			transform.position += forwardDir * 2.0f;
		if (Input.GetKey (KeyCode.S))
			transform.position -= forwardDir * 2.0f;
		if (Input.GetKey (KeyCode.A))
			transform.position -= rightDir * 2.0f;
		if (Input.GetKey (KeyCode.D))
			transform.position += rightDir * 2.0f;

		// 滑鼠控制第一人稱視角
		x += Input.GetAxis ("Mouse X") * 5.0f;
		y -= Input.GetAxis ("Mouse Y") * 5.0f;
		cam.transform.rotation = Quaternion.Euler (y, x, 0.0f);
	}

	void FixedUpdate () {
		forwardDir = (forwardStar.transform.position - cam.transform.position).normalized;
		forwardDir.y = 0.0f;

		rightDir = (rightStar.transform.position - cam.transform.position).normalized;
		rightDir.y = 0.0f;

		gameObject.GetComponent<Rigidbody> ().velocity = Vector3.zero;
	}
		
}
