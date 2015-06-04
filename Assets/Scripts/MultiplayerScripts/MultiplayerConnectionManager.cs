using UnityEngine;
using System.Collections;

public class MultiplayerConnectionManager : MonoBehaviour {
	
	private TypedLobby lobby;
	private RoomOptions options;

	private bool ConnectInUpdate;
	
	public bool gameStarted;
	
	public bool instantiatedPlayer;
	
	// Use this for initialization
	void Start () {
		PhotonNetwork.autoJoinLobby = false;
		
		options = new RoomOptions();
		options.isOpen = true;
		options.maxPlayers = 2;
		
		gameStarted = false;
		instantiatedPlayer = false;
		
		ConnectInUpdate = true;;
	}
	
	// Update is called once per frame
	void Update () {

		if (ConnectInUpdate && !PhotonNetwork.connected) {
			ConnectInUpdate = false;
			
			if(PhotonNetwork.ConnectUsingSettings ("v1.0")) {
				print("Connection formed");
				PhotonNetwork.sendRate = 20;
				PhotonNetwork.sendRateOnSerialize = 10;
			}
		}

		//checks if game has started yet
		if (!ConnectInUpdate && PhotonNetwork.inRoom && PhotonNetwork.room.playerCount == options.maxPlayers) {
			gameStarted = true;
			print ("GAME STARTED");
		} 
	}
	
	public virtual void OnConnectedToMaster() {
		PhotonNetwork.JoinRandomRoom ();
	}
	
	public virtual void OnPhotonRandomJoinFailed() {
		if (PhotonNetwork.JoinRandomRoom ()) {
			print ("Failed, creating room");
			PhotonNetwork.CreateRoom (null, options, null);
		}
	}

	public void OnJoinedRoom() {
		print("Joined room succesfully");
	}

	public void OnPhotonPlayerDisconnected() {
		print ("A player disconnected, leaving room");
		PhotonNetwork.LeaveRoom ();
	}	

	public void OnLeftRoom() {
		GameObject.FindGameObjectWithTag("Manager").GetComponent<SwitchScenes>().switchScenes("GUIScene");
	}
}