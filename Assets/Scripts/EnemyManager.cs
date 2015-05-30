using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

	public GameObject enemyPrefab;

	private float xPos, yPos;
	// Use this for initialization
	void Start () {
		Instantiate (enemyPrefab, new Vector3 (0, 0, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
