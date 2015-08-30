using UnityEngine;
using System.Collections;

public class Incense : MonoBehaviour {
	
	void Start () {
		
	}
	
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.collider.tag == "Down") {
			Destroy(gameObject);
			GameObject.Find("Player3").GetComponent<PlayerDay3>().SendMessage("Incen");
		}
		
		if (coll.collider.tag == "Censer") {
			Destroy(gameObject);
			GameObject.Find("Player3").GetComponent<PlayerDay3>().SendMessage("Incen");
			GameObject.Find("Score").GetComponent<ScoreDay3>().SendMessage("AddDay3Score", 10);
			
		}
	}
}
