using UnityEngine;
using System.Collections;

public enum SpawnSide {
	LEFT,
	RIGHT
}

public class Enemy : MonoBehaviour {
	
	private float randomXSpeed;
	private float randomYSpeed;
	
	private Vector3 enemyPos;

	
	// Use this for initialization
	void Start () {
		randomXSpeed = Random.Range (1f, 3f);
		randomYSpeed = Random.Range (-2f, 2f);


	}
	
	// Update is called once per frame
	void Update () {
		moveEnemy ();
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
}