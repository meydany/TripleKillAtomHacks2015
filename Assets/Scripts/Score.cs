using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {
	
	public int score;
	
	public GameObject ScoreText;
	
	// Use this for initialization
	void Start () {
		score = 0;
		ScoreText = GameObject.FindGameObjectWithTag ("ScoreText");
	}
	
	// Update is called once per frame
	void Update () {
		ScoreText.GetComponent<Text> ().text = score.ToString ();        
	}
	
	public void AddScore (int PointsAdded){
		score += PointsAdded;
	}

	public void removeScore(int points){
		score -= points;
	}
}