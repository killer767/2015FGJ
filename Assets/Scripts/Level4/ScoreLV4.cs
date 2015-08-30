using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreLV4 : MonoBehaviour {

	public static int scoreLV4;
	bool getScore = false;

	void Start () {
		scoreLV4 = 0;
	}
	
	void Update () {

		if (scoreLV4 >= 40) {
			GetGoal ();
			return;
		}
		transform.GetComponent<Text> ().text = "score: " + scoreLV4.ToString ();

	}

	public void Add(int amt){
		scoreLV4 += amt;
	}

	void GetGoal ()
	{
		if (getScore == false) {

			getScore = true;
			
			
			Application.LoadLevel(5);
			//Invoke ("ChangeSceneToResult", 3f);
		}
	}
}
