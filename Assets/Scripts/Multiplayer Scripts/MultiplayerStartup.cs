using UnityEngine;
using System.Collections;

public class MultiplayerStartup : MonoBehaviour {

	public bool instantiatedObjects = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnJoinedRoom() {
		if (!instantiatedObjects && PhotonNetwork.masterClient != null) {
			PhotonNetwork.Instantiate ("MultiplayerPlayer", new Vector3 (0, 0, 0), Quaternion.identity,0, null);
		}
	}
}
