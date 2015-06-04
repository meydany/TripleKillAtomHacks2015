using UnityEngine;
using System.Collections;

public class WaitingLabel : MonoBehaviour {
	
	public GameObject text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectWithTag ("Manager").GetComponent<MultiplayerConnectionManager> ().gameStarted) {
			Destroy (text);
		}
	}
}
