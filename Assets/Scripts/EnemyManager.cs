using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

	public GameObject enemyPrefab;

	private float xPos, yPos;
	// Use this for initialization
	void Start () {
		xPos = 0f;
		yPos = 0f;
		Instantiate (enemyPrefab, new Vector3 (xPos, yPos, 0f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
