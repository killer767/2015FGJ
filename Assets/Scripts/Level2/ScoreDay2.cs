using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreDay2 : MonoBehaviour
{

	Text scoreText;
	public static int scoreDay2 = 0;	
	
	void Start ()
	{
		scoreDay2 = 0;
		scoreText = GetComponent<Text> ();
	}
	
	void Update ()
	{
		scoreText.text = "Score: " + scoreDay2.ToString ();
	}
	
	public static void AddScore (int amt)
	{
		scoreDay2 += amt;
	}
}
