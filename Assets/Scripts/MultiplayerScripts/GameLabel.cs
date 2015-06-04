using UnityEngine;
using System.Collections;

public class GameLabel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectWithTag ("Manager").GetComponent<MultiplayerConnectionManager> ().gameStarted) {
			Destroy (gameObject);
		}
	}
}
