using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {
	
	public float TimeLeft;
	
	GameObject TimerText;
	
	// Use this for initialization
	void Start () {
		TimeLeft = 60f;
		TimeLeft += 1f;
		
		TimerText = GameObject.FindGameObjectWithTag ("TimerText");
		
	}
	
	// Update is called once per frame
	void Update () {
		if (TimeLeft > 0) {
			TimeLeft -= Time.deltaTime;
		} 
		else if (TimeLeft <= 0){
			TimeLeft = 0;
			// Make sure it only runs once ie. use boolean
			print ("running");
			gameObject.GetComponent<GameEnd>().endGame();
		}
		TimerText.GetComponent<Text>().text = ((int)TimeLeft).ToString();            
	}
	
	// Used to add time from Target script
	public void AddTime(float TimeAdded){
		
		if (TimeLeft == 0f) {
			TimeAdded = 0f;        
		}
		TimeLeft += TimeAdded;
	}
	
	public void RemoveTime(float TimeRemoved){
		
		if (TimeLeft == 0f) {
			TimeRemoved = 0f;
		}
		
		TimeLeft -= TimeRemoved;
	}
}