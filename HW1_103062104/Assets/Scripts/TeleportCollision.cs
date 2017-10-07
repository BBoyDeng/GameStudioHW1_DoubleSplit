using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCollision : MonoBehaviour {

	public GameObject[] teleport = new GameObject[10];

	bool isTeleport = false;

	void OnCollisionEnter (Collision other) {

		if (other.gameObject.tag == "Teleport" && !isTeleport) {

			// player1 傳送控制
			if (other.gameObject.name == "Teleport 1-1-1") {
				transform.position = teleport [1].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 1-1-2") {
				transform.position = teleport [0].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 1-2-1") {
				transform.position = teleport [3].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 1-2-2") {
				transform.position = teleport [2].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 1-3-1") {
				transform.position = teleport [5].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 1-3-2") {
				transform.position = teleport [4].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 1-4-1") {
				transform.position = teleport [7].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 1-4-2") {
				transform.position = teleport [6].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 1-5-1") {
				transform.position = teleport [9].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 1-5-2") {
				transform.position = teleport [8].transform.position + new Vector3 (0, 11, 0);
			} 

			// player2 傳送控制
			if (other.gameObject.name == "Teleport 2-1-1") {
				transform.position = teleport [1].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 2-1-2") {
				transform.position = teleport [0].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 2-2-1") {
				transform.position = teleport [3].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 2-2-2") {
				transform.position = teleport [2].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 2-3-1") {
				transform.position = teleport [5].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 2-3-2") {
				transform.position = teleport [4].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 2-4-1") {
				transform.position = teleport [7].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 2-4-2") {
				transform.position = teleport [6].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 2-5-1") {
				transform.position = teleport [9].transform.position + new Vector3 (0, 11, 0);
			} else if (other.gameObject.name == "Teleport 2-5-2") {
				transform.position = teleport [8].transform.position + new Vector3 (0, 11, 0);
			} 

			isTeleport = true;
		} else {
			isTeleport = false;
		}

	}

}
