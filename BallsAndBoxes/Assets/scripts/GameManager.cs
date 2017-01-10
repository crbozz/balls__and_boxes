using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject ball;
	public int maxBalls;

	private int numBalls;

	void Start () {
		numBalls = 0;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (numBalls < maxBalls) {
				Instantiate (ball);
				numBalls++;
			}
		}
	}
}
