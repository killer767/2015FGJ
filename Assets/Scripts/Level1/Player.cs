using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Rigidbody2D rigid;
	bool isJump;
	bool isDown;
	bool isC;
	
	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
		isC = true;
	}
	
	void Update () {
		rigid.velocity = new Vector2 (2, rigid.velocity.y);
		
		if (Input.GetKeyDown (KeyCode.T) && isJump == false && isC == true) {
			isJump = true;
			isC = false;
			rigid.gravityScale = 1;
			GameObject.Find("Up").GetComponent<BoxCollider2D>().enabled = false;
			GameObject.Find("Down").GetComponent<BoxCollider2D>().enabled = true;
			rigid.AddForce(Vector2.up * 500);
			StartCoroutine("Hold");
		}
		if (Input.GetKeyDown (KeyCode.Y) && isDown == false && isC == true) {
			isDown = true;
			isC = false;
			rigid.gravityScale = -1;
			GameObject.Find("Down").GetComponent<BoxCollider2D>().enabled = false;
			GameObject.Find("Up").GetComponent<BoxCollider2D>().enabled = true;
			rigid.AddForce(Vector2.down * 500);
			StartCoroutine("Hold");
		}
	}
	
	void OnCollisionEnter2D (Collision2D coll){
		if (coll.collider.tag == "Down") {
			isJump = false;
		}
		if (coll.collider.tag == "Up") {
			isDown = false;
		}
	}
	
	IEnumerator Hold(){
		yield return new WaitForSeconds(1);
		isC = true;
	}
}
