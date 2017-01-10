using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		float moveH = Input.GetAxis ("Horizontal");
		float moveV = Input.GetAxis ("Vertical");

		//Vector3 move = new Vector3 (-moveV, 0, moveH);

		//transform.position = transform.position + move;

		transform.RotateAround (Vector3.zero, Vector3.up, moveH);

		var fw = transform.position + (transform.forward * moveV);
		if (fw.y > 12 && fw.y < 25) {
			transform.position = fw;
		}
	}
}
