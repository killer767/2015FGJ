using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	float x = -0.34f;
	float y = -9.6f;
	//公開變數至Inspector
	public float speed = 0.5f;

	public AudioClip[] clips;
	AudioSource audioSource;

	void Start ()
	{
		
		audioSource = GetComponent <AudioSource> ();

	}
	
	void Update ()
	{
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
		//限制數值
		x = Mathf.Clamp (x, -18f, 18f);
		y = Mathf.Clamp (y, -3.44f,7.98f);
		transform.position = new Vector2 (x, y);

	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		switch (coll.collider.tag) {
		case "ten":
			audioSource.clip = clips [0];
			audioSource.Play ();
			ScoreDay2.AddScore (10);
			break;
		case "twenty":
			audioSource.clip = clips [1];
			audioSource.Play ();
			ScoreDay2.AddScore (20);
			break;
		case "thirty":
			audioSource.clip = clips [2];
			audioSource.Play ();
			ScoreDay2.AddScore (-30);
			break;
		}
		//coll.collider.SendMessage ("playdeadanim");
		coll.collider.transform.GetComponent<EnemyMovement>().playdeadanim();
		//Destroy (coll.collider.gameObject);
	}
}
