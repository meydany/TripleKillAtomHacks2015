using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

	public GameObject enemyPrefab;

	private float xPos, yPos;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("createEnemy", 0f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void createEnemy() {
		Instantiate (enemyPrefab, new Vector3 (0, 0, 0), Quaternion.identity);
	}
}
