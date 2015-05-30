using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {
	
	
	public int score;
	
	GameObject FinalScoreText;    
	void Awake(){
		score = 0;
	}
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	//sets the score of the text
	public void SetFinalScore(){
		FinalScoreText = GameObject.FindGameObjectWithTag ("FinalScore");
		FinalScoreText.GetComponent<Text>().text = score.ToString ();
		Destroy (gameObject);
	}
}

