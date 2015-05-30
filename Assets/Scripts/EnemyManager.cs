using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

	public GameObject enemyPrefab;

	private float xPos, yPos;
	// Use this for initialization
	void Start () {

		if (enemyPrefab.GetComponent<Enemy> ().side == SpawnSide.LEFT) {
			xPos = Random.Range (-Camera.main.orthographicSize * Camera.main.aspect * 2f,-Camera.main.orthographicSize * Camera.main.aspect);
			yPos = Random.Range (-Camera.main.orthographicSize,Camera.main.orthographicSize);
		} else if(enemyPrefab.GetComponent<Enemy> ().side == SpawnSide.RIGHT){
			print ("im here");
			xPos = Random.Range (Camera.main.orthographicSize * Camera.main.aspect,Camera.main.orthographicSize * Camera.main.aspect * 2f);
			yPos = Random.Range (-Camera.main.orthographicSize, Camera.main.orthographicSize);
		}

		Instantiate (enemyPrefab, new Vector3 (xPos, yPos, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
