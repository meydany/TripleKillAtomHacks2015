using UnityEngine;
using System.Collections;

public class StartUp : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		Instantiate (player, new Vector3 (0, 0, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
