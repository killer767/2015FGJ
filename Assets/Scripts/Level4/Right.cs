using UnityEngine;
using System.Collections;

public class Right : MonoBehaviour {

	string num;
	GameObject obj, left;

	void Start () {
		num = null;
		left = GameObject.Find ("Left");
	}
	
	void Update () {

	}

	public void CheckR (string amt){
		num = amt;
	}

	public void MatchR (){
		obj.GetComponent<SpriteRenderer> ().enabled = false;
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "A" || other.tag == "B" || other.tag == "C" || other.tag == "D"){
			obj = other.gameObject;
			left.GetComponent<Left> ().SendMessage("CheckL", other.tag);
			if(num == other.tag){
				GameObject.Find("Score").GetComponent<ScoreLV4>().SendMessage("Add", 10);
				MatchR();
				left.GetComponent<Left> ().SendMessage("MatchL");
			}
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "A" || other.tag == "B" || other.tag == "C" || other.tag == "D") {
			left.GetComponent<Left> ().SendMessage("CheckL", null);
		}
	}
}