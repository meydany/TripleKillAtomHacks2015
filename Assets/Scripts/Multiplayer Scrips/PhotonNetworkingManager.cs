using UnityEngine;
using System.Collections;

public class PhotonNetworkingManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PhotonNetwork.sendRate = 20;
		PhotonNetwork.sendRateOnSerialize = 10;
	}	
	
	// Update is called once per frame
	void Update () {
	
	}

	void onPhotoSerializedView(PhotonStream stream, PhotonMessageInfo info) {


	}
}
