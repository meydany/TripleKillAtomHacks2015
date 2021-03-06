﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Vector3 newPosition;
	private Vector3 currentPosition;

	private float speed = 3f;
	private float step;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			newPosition = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
			moveToPosition (newPosition);
		}
	}
	
	void OnTriggerEnter(Collider collision){
		if (collision.gameObject.tag == "leftWall" || collision.gameObject.tag == "rightWall" || collision.gameObject.tag == "topWall" || collision.gameObject.tag == "botWall") {
			//print (collision.gameObject.name);
		}
		else if (collision.gameObject.tag == "Target") {
			Destroy (GameObject.FindGameObjectWithTag ("Target"));
			GameObject.FindGameObjectWithTag ("Manager").GetComponent<Score> ().AddScore (2);
		}
		else if (collision.gameObject.tag == "enemy"){
			GameObject.FindGameObjectWithTag ("Manager").GetComponent<Score> ().removeScore(1);
			Destroy(collision.gameObject);
		}

	}

	void moveToPosition(Vector3 newPosition) {
		currentPosition = gameObject.transform.position;

		float xDifference = newPosition.x - currentPosition.x;
		float yDifference = newPosition.y - currentPosition.y;

		gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (xDifference, yDifference, 0);
	}
}
