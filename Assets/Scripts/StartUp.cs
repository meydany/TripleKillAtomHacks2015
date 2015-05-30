using UnityEngine;
using System.Collections;

public class StartUp : MonoBehaviour {

	public GameObject playerPrefab;
	public GameObject targetPrefab;

	// Use this for initialization
	void Start () {
		Instantiate (playerPrefab, new Vector3 (0, 0, 0), Quaternion.identity);
		Instantiate (targetPrefab, new Vector3 (0, 2, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
