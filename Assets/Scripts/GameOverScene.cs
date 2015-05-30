using UnityEngine;
using System.Collections;

public class GameOverScene : MonoBehaviour {
	
	GameObject FinalScoreText;
	GameObject ScoreKeeper;
	
	void Awake(){
		ScoreKeeper = GameObject.Find ("ScoreKeeper");
	}
	
	// Use this for initialization
	void Start () {
		ScoreKeeper.GetComponent<ScoreKeeper> ().SetFinalScore ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}