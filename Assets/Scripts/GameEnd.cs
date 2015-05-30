using UnityEngine;
using System.Collections;

public class GameEnd : MonoBehaviour {


	GameObject ScoreKeeper;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void endGame(){
		ScoreKeeper = new GameObject ();
		ScoreKeeper.name = "ScoreKeeper";
		ScoreKeeper.AddComponent<ScoreKeeper>();
		ScoreKeeper.GetComponent<ScoreKeeper> ().score = GameObject.FindGameObjectWithTag ("Manager").GetComponent<Score> ().score;
		DontDestroyOnLoad (ScoreKeeper);
		ScoreKeeper.tag = "ScoreKeeper";
		Application.LoadLevel("GameOver");
	}
}
