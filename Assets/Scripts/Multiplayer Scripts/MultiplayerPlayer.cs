using UnityEngine;
using System.Collections;

public class MultiplayerPlayer : MonoBehaviour {

	private GameObject circle;

	private Vector3 newPosition;
	private Vector3 currentPosition;
	
	private float speed = 3f;
	private float step;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectWithTag("Manager").GetComponent<MultiplayerConnection>().gameStarted && Input.GetMouseButtonDown (0)) {
			print ("clicked");
			newPosition = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
			moveToPosition (newPosition);
		}
	}

	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		if (stream.isWriting)
		{
			// We own this player: send the others our data
			stream.SendNext(transform.position);
			stream.SendNext(gameObject.GetComponent<Rigidbody>().velocity 
		}
		else
		{
			// Network player, receive data
			this.transform.position = (Vector3) stream.ReceiveNext();
			this.gameObject.GetComponent<Rigidbody>().velocity = (Vector3) stream.ReceiveNext();
		}
	}
	
	void OnTriggerEnter(Collider collision){
		if (collision.gameObject.tag == "leftWall" || collision.gameObject.tag == "rightWall" || collision.gameObject.tag == "topWall" || collision.gameObject.tag == "botWall") {
			//print (collision.gameObject.name);
		}
		else if (collision.gameObject.tag == "Target") {
			Destroy (GameObject.FindGameObjectWithTag ("Target"));
			GameObject.FindGameObjectWithTag ("Manager").GetComponent<Score> ().AddScore (2);
		}
		else if (collision.gameObject.tag == "enemy"){
			GameObject.FindGameObjectWithTag ("Manager").GetComponent<Score> ().removeScore(1);
			Destroy(collision.gameObject);
		}
		
	}

//	[RPC]
	void moveToPosition(Vector3 newPosition) {
		if (PhotonNetwork.isMasterClient) {
			circle = GameObject.FindGameObjectWithTag ("clientPlayer");
		} else {
			circle = GameObject.FindGameObjectWithTag ("serverPlayer");
		}
		currentPosition = circle.transform.position;
		
		float xDifference = newPosition.x - currentPosition.x;
		float yDifference = newPosition.y - currentPosition.y;
		
		circle.GetComponent<Rigidbody> ().velocity = new Vector3 (xDifference, yDifference, 0);
	}
}
