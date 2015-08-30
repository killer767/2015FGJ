using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Result : MonoBehaviour
{

	int[] score;
	public Text[] items = new Text[3];
	
	void Start ()
	{
		score = new int[4];

		/*for (int i=0; i<3; i++) {
			PlayerPrefs.SetInt ("No" + (i + 1) + "_Score", 0);
		}*/
		score [0] = PlayerPrefs.GetInt ("No1_Score");
		score [1] = PlayerPrefs.GetInt ("No2_Score");
		score [2] = PlayerPrefs.GetInt ("No3_Score");
		score [3] = PlayerPrefs.GetInt ("FinalScore");

		//泡沫排序
		for (int i=0; i<score.Length; i++) {
			for (int j=i+1; j<score.Length; j++) {
				if (score [i] < score [j]) {
					int temp = score [i];
					score [i] = score [j];
					score [j] = temp;
				}
			}
		}


		for (int i=0; i<3; i++) {
			PlayerPrefs.SetInt ("No" + (i + 1) + "_Score", score [i]);
			Debug.Log ("No" + (i + 1) + "Score: " + score [i]);	
			items [i].text = (i + 1) + ". " + score [i].ToString ();
		}

	}
}
