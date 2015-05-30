using UnityEngine;
using System.Collections;

public class ColliderCreator : MonoBehaviour {

	public GameObject rightWallPrefab, leftWallPrefab, topWallPrefab, botWallPrefab;

	GameObject rightWall;
	GameObject leftWall;
	GameObject botWall;
	GameObject topWall;

	void Awake(){
		rightWall = (GameObject)Instantiate (rightWallPrefab, new Vector3 (0, 0, 0), Quaternion.identity);
		leftWall = (GameObject)Instantiate (leftWallPrefab, new Vector3 (0, 0, 0), Quaternion.identity);

		topWall = (GameObject)Instantiate (topWallPrefab, new Vector3 (0, 0, 0), Quaternion.identity);
		botWall = (GameObject)Instantiate (botWallPrefab, new Vector3 (0, 0, 0), Quaternion.identity);
	}

	// Use this for initialization
	void Start () {
		createWalls ();
	}

	// Update is called once per frame
	void Update () {
	
	}

	void createWalls(){
		float sideLimits = Camera.main.orthographicSize * Camera.main.aspect + (rightWall.GetComponent<Renderer> ().bounds.size.x / 2);

		rightWall.transform.position = new Vector3 (sideLimits, 0, 0);
		rightWall.transform.localScale = new Vector3(1, Camera.main.orthographicSize * 2, 1);

		leftWall.transform.position = new Vector3 (-sideLimits, 0, 0);
		leftWall.transform.localScale = new Vector3(1, Camera.main.orthographicSize * 2, 1);

		float topLimit = Camera.main.orthographicSize + topWall.GetComponent<Renderer> ().bounds.size.y / 2;

		topWall.transform.position = new Vector3 (0, topLimit, 0);
		topWall.transform.localScale = new Vector3(Camera.main.orthographicSize * Camera.main.aspect * 2, 1, 1);

		botWall.transform.position = new Vector3 (0, -topLimit, 0);
		botWall.transform.localScale = new Vector3(Camera.main.orthographicSize * Camera.main.aspect * 2, 1, 1);
	}
}
