using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreDay3 : MonoBehaviour {

	public static int scoreDay3;

	void Start () {
		scoreDay3 = 0;
	}
	
	void Update () {
		GetComponent<Text> ().text = "Score: " + scoreDay3.ToString ();
	}
	
	public void AddDay3Score(int amt){
		scoreDay3 += amt;
	}
}
