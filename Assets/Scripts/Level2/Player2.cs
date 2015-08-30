using UnityEngine;
using System.Collections;

public class Player2: MonoBehaviour {

	Rigidbody2D rigid;
	float x = 0;
	float y = 0;
	public float speed = 0.01f;

	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
		x = rigid.velocity.x;
		y = rigid.velocity.y;

		//rigid.velocity = new Vector2 (0, -10);
	}

	void Update () {
		if (Input.GetMouseButton(0)) {
			//rigid.gravityScale = 1;
			rigid.velocity = new Vector2 (rigid.velocity.x,8f);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			x -= speed;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			x += speed;
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			y += speed;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			y -= speed;
		}
		
		x = Mathf.Clamp (x, -7.8f, 7.8f);
		y = Mathf.Clamp (y, -3.2f, 3.2f);
		//transform.position = new Vector2 (x, y);

			
			

			
		//transform.position = new Vector2 (x,0f);


	}
}
