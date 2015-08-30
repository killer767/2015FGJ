using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Goal : MonoBehaviour {

	int goal;
	
	void Start () {
		if (gameObject.tag == "Day1") {
			goal = Random.Range(120, 200);
			GetComponent<Text> ().text = "第一關 : " + goal.ToString ();
		}
		if (gameObject.tag == "Day2") {
			goal = Random.Range(120, 200);
			GetComponent<Text> ().text = "第二關 : " + goal.ToString ();
		}
		if (gameObject.tag == "Day3") {
			goal = Random.Range(3, 15);
			GetComponent<Text> ().text = "第三關 :   " + goal.ToString ();
		}
		if (gameObject.tag == "Day4") {
			goal = Random.Range(120, 200);
			GetComponent<Text> ().text = "第四關 : " + goal.ToString ();
		}
		if (gameObject.tag == "Day5") {
			goal = Random.Range(120, 200);
			GetComponent<Text> ().text = "第五關 : " + goal.ToString ();
		}
	}
	
	void Update () {
	
	}
}
