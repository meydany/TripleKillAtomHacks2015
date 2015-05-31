using UnityEngine;
using System.Collections;

public class MultiplayerStartup : MonoBehaviour {

	public bool instantiatedObjects = false;

	private GameObject ourPlayer;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnJoinedRoom() {
		if (!instantiatedObjects && PhotonNetwork.masterClient != null) {
			instantiatePlayer ();
		}
		/*
		if (PhotonNetwork.isMasterClient) {
			ourPlayer.tag = "clientPlayer";
		} else {
			ourPlayer.tag = "serverPlayer";
		}
		*/
	}

	public void instantiatePlayer(){
		ourPlayer = (GameObject) PhotonNetwork.Instantiate ("MultiplayerPlayer", new Vector3 (0, 2, 0), Quaternion.identity,0, null);
		if (PhotonNetwork.isMasterClient) {
			ourPlayer.tag = "clientPlayer";
		} else {
			ourPlayer.tag = "serverPlayer";
		}
	}
}
