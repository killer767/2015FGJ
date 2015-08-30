using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreDay1 : MonoBehaviour {

	public static int scoreDay1;

	void Start () {
		scoreDay1 = 0;
	}
	
	void Update () {
		GetComponent<Text> ().text = "Score: " + scoreDay1.ToString ();
	}

	public void AddDay1Score(int amt){
		scoreDay1 += amt;
	}
}
