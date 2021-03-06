﻿using UnityEngine;
using System.Collections;

public enum SpawnSide {
	LEFT,
	RIGHT
}

public class Enemy : MonoBehaviour {
	
	private float randomXSpeed;
	private float randomYSpeed;
	
	private Vector3 enemyPos;

	private float randomSide;
	private SpawnSide side;
	
	// Use this for initialization
	void Start () {
		randomXSpeed = Random.Range (1f, 3f);
		randomYSpeed = Random.Range (-2f, 2f);

		randomSide = Random.Range (0f, 2f);

		if (randomSide < 1) {
			side = SpawnSide.LEFT;
			transform.position = new Vector3(-(Camera.main.orthographicSize * Camera.main.aspect + (GetComponent<Renderer>().bounds.size.x /2)), Random.Range(-(Camera.main.orthographicSize), Camera.main.orthographicSize), 0);
		} else {
			side = SpawnSide.RIGHT;
			transform.position = new Vector3((Camera.main.orthographicSize * Camera.main.aspect + (GetComponent<Renderer>().bounds.size.x /2)), Random.Range(-(Camera.main.orthographicSize), Camera.main.orthographicSize), 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		moveEnemy ();
		checkPosition ();
	}

	void moveEnemy() {
		enemyPos = transform.position;
		
		if (side == SpawnSide.LEFT) {
			enemyPos.x += Time.deltaTime * randomXSpeed;
		} else if(side == SpawnSide.RIGHT) {
			enemyPos.x -= Time.deltaTime * randomXSpeed;
		}
		enemyPos.y += Time.deltaTime * randomYSpeed;
		
		transform.position = enemyPos;
	}

	void checkPosition() {
		if (side == SpawnSide.LEFT && gameObject.transform.position.x > Camera.main.orthographicSize * Camera.main.aspect + (GetComponent<Renderer> ().bounds.size.x / 2)) {
			Destroy (gameObject);
		} else if (side == SpawnSide.RIGHT && gameObject.transform.position.x < -(Camera.main.orthographicSize * Camera.main.aspect + (GetComponent<Renderer> ().bounds.size.x / 2))) {
			Destroy (gameObject);
		}
	}
}