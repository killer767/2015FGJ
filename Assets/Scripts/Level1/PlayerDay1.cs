using UnityEngine;
using System.Collections;

public class PlayerDay1 : MonoBehaviour {

	Rigidbody2D rigid;
	bool isJump;
	bool isDown;
	bool isC;
	float high;
	
	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
		isC = true;
	}
	
	void Update () {
		rigid.velocity = new Vector2 (3, rigid.velocity.y);

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			rigid.gravityScale = 1;
			rigid.AddForce(Vector2.up * 500);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			rigid.gravityScale = -1;
			rigid.AddForce(Vector2.down * 500);
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Food") {
			Destroy(other.gameObject);
			GameObject.Find("Score").GetComponent<ScoreDay1>().SendMessage("AddDay1Score", 20);
		}

		if (other.tag == "BadFood") {
			GameObject.Find("Score").GetComponent<ScoreDay1>().SendMessage("AddDay1Score", 5);
		}
		if (other.tag == "Fire") {
			GameObject.Find("Score").GetComponent<ScoreDay1>().SendMessage("AddDay1Score", -30);
		}

		if (other.tag == "End") {
			Application.LoadLevel(2);
		}
	}
}
