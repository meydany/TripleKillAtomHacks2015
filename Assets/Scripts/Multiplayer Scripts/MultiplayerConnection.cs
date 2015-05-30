using UnityEngine;
using System.Collections;

public class MultiplayerConnection : MonoBehaviour {

	private TypedLobby lobby;
	private RoomOptions options;

	public bool AutoConnect = true;
	private bool ConnectInUpdate = true;

	// Use this for initialization
	void Start () {
		PhotonNetwork.autoJoinLobby = false;

		options = new RoomOptions();
		options.isOpen = true;
		options.maxPlayers = 2;
	}
	
	// Update is called once per frame
	void Update () {

		if (ConnectInUpdate && AutoConnect && !PhotonNetwork.connected) {
			ConnectInUpdate = false;

			if(PhotonNetwork.ConnectUsingSettings ("v1.0")) {
				print("Connection formed");
			}
		}
		if( PhotonNetwork.room != null && PhotonNetwork.room.playerCount == PhotonNetwork.room.maxPlayers) {
			options.isOpen = true;
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
		print("Joined room");
	}
}
