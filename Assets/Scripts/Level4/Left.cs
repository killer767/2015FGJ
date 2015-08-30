using UnityEngine;
using System.Collections;

public class Left : MonoBehaviour {

	string num;
	GameObject obj;

	void Start(){
		num = null;
	}

	void Update(){

	}

	public void CheckL (string amt){
		num = amt;
	}

	public void MatchL (){
		obj.GetComponent<SpriteRenderer> ().enabled = false;
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "A" || other.tag == "B" || other.tag == "C" || other.tag == "D"){
			obj = other.gameObject;
			GameObject.Find("Right").GetComponent<Right>().SendMessage("CheckR", other.tag);
			if(num == other.tag){
				GameObject.Find("Score").GetComponent<ScoreLV4>().SendMessage("Add", 10);
				MatchL();
				GameObject.Find("Right").GetComponent<Right>().SendMessage("MatchR");
			}
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "A" || other.tag == "B" || other.tag == "C" || other.tag == "D") {
			GameObject.Find("Right").GetComponent<Right>().SendMessage("CheckR", null);
		}
	}
}