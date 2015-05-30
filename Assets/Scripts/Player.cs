using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Vector3 newPosition;
	private Vector3 currentPosition;

	private float speed = 3f;
	private float step;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			newPosition = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
			moveToPosition (newPosition);
		}
	}

<<<<<<< HEAD:Assets/Scripts/Player.cs
	void OnTriggerEnter(Collider collision){
		print(collision.gameObject.name);
		if (collision.gameObject.tag == "leftWall" || collision.gameObject.tag == "rightWall" || collision.gameObject.tag == "topWall" || collision.gameObject.tag == "botWall") {
			print (collision.gameObject.name);
		} else if(collision.gameObject.tag == "Target"){
			score += 1;
			Destroy(GameObject.FindGameObjectWithTag("Target"));
		}

=======
	void OnTriggerEnter(){
		Destroy(GameObject.FindGameObjectWithTag("Target"));
		GameObject.FindGameObjectWithTag ("Manager").GetComponent<Score> ().AddScore (1);
>>>>>>> f0f437e09585f0d934aab97b01a9a58d39ab0e45:Assets/Scripts/PlayerScript.cs
	}

	void moveToPosition(Vector3 newPosition) {
		currentPosition = gameObject.transform.position;

		float xDifference = newPosition.x - currentPosition.x;
		float yDifference = newPosition.y - currentPosition.y;

		gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (xDifference, yDifference, 0);
	}
}
