using UnityEngine;
using System.Collections;

public class MultiplayerStartup : MonoBehaviour {

	private TypedLobby lobby;

	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectUsingSettings ("v1.0");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
