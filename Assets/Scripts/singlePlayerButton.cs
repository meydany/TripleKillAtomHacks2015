using UnityEngine;
using System.Collections;

public class singlePlayerButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void switchScenes(string scene){
		Application.LoadLevel(scene);
	}
}
