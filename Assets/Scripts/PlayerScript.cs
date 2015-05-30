using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	Vector3 target;

	float speed = 3f;
	float step;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			target = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x ,Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
			gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
			gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero; 
		}
		step = speed * Time.deltaTime;
		gameObject.transform.position = Vector3.MoveTowards(transform.position, target, step);
		if (gameObject.GetComponent<Rigidbody> ().velocity.x < .1) {
			gameObject.GetComponent<Rigidbody> ().velocity = new Vector3(0, 0, 0);
		}
	}
}
