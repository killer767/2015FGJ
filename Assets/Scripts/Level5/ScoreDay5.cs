using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreDay5 : MonoBehaviour {

	Text scoreText;
	public static int scoreDay5 = 0;	
	
	void Start ()
	{
		scoreDay5 = 0;
		scoreText = GetComponent<Text> ();
	}
	
	void Update ()
	{
		scoreText.text = "Score: " + scoreDay5.ToString ();
	}
	
	public static void AddScore (int amt)
	{
		scoreDay5 += amt;
	}
}
