using UnityEngine;
using System.Collections;

public enum SpawnSide {
	LEFT,
	RIGHT
}
public class Enemy : MonoBehaviour {
	
	private float randomXPos, randomYPos;

	private float randomSide;

	private float randomXSpeed;
	private float randomYSpeed;

	private Vector3 enemyPos;

	public SpawnSide side;

	// Use this for initialization
	void Start () {
		randomSide = Random.Range (0f, 2f);
		randomXSpeed = Random.Range (1f, 3f);
		randomYSpeed = Random.Range (-2f, 2f);

		if (randomSide < 1) {
			side = SpawnSide.LEFT;
			randomXPos = Random.Range (-Camera.main.orthographicSize * Camera.main.aspect * 2f,-Camera.main.orthographicSize * Camera.main.aspect);
			randomYPos = Random.Range (-Camera.main.orthographicSize,Camera.main.orthographicSize);
		} else {
			side = SpawnSide.RIGHT;
			randomXPos = Random.Range (-Camera.main.orthographicSize * Camera.main.aspect,Camera.main.orthographicSize * Camera.main.aspect * 2f);
			randomYPos = Random.Range (-Camera.main.orthographicSize, Camera.main.orthographicSize);
		}

		Instantiate (gameObject, new Vector3 (randomXPos, randomYPos, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		enemyPos = transform.position;

		if (side == SpawnSide.LEFT) {
			enemyPos.x += Time.deltaTime * randomXSpeed;
		} else {
			enemyPos.x -= Time.deltaTime * randomXSpeed;
		}
		enemyPos.y += Time.deltaTime * randomYSpeed;

		transform.position = enemyPos;
	}
}
