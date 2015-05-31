﻿using UnityEngine;
using System.Collections;

public class MultiplayerTargetManager : MonoBehaviour {
	
	public GameObject targetPrefab;
	public GameObject[] targets;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectWithTag("Target") == null && PhotonNetwork.isMasterClient) {
			spawnNewTarget();
		}
	}
	
	void spawnNewTarget(){
		targets = GameObject.FindGameObjectsWithTag ("Target");

		foreach(GameObject target in targets) {
			Destroy (target);
		}
		Vector3 newPos = new Vector3 (Random.Range(-(Camera.main.orthographicSize * Camera.main.aspect - (targetPrefab.GetComponent<Renderer>().bounds.size.x/2)), Camera.main.orthographicSize * Camera.main.aspect - (targetPrefab.GetComponent<Renderer>().bounds.size.x/2)), 
		                              Random.Range (-(Camera.main.orthographicSize - targetPrefab.GetComponent<Renderer>().bounds.size.y/2), Camera.main.orthographicSize - targetPrefab.GetComponent<Renderer>().bounds.size.y/2), 0);
		PhotonNetwork.Instantiate("MultiplayerTarget", newPos, Quaternion.identity,0,null);
	}
	
}