using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
	Animator anim;
	void Start ()
	{	//建立Rigidbody2D的移動(往下)
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -5);
		anim = GetComponent<Animator> ();
	}
	
	void Update ()
	{
		
	}

	public void playdeadanim ()
	{
		anim.SetBool ("dead", true);
		//使敵人在原地死亡
		GetComponent<Rigidbody2D> ().isKinematic = true;
		GetComponent<BoxCollider2D> ().enabled = false;
		GetComponent<EnemyMovement> ().enabled = false;
	}

	public void destoryMyself ()
	{
		Destroy (gameObject);
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.collider.name == "EnemyDestroyer") {
			Destroy (gameObject);
		}
	}

	//物體碰撞function
	/*void OnCollisionEnter2D (Collision2D coll)
	{	
		//被撞到的物體名稱
		if (coll.collider.name == "Player") {
			if (gameObject.tag == "ten") {
				GameObject.Find ("Score").GetComponent<Score> ().AddScore (10);
			}
			if (gameObject.tag == "twenty") {
				GameObject.Find ("Score").GetComponent<Score> ().AddScore (20);
			}
			if (gameObject.tag == "thirty") {
				GameObject.Find ("Score").GetComponent<Score> ().AddScore (-30);
			}
			//使用Player物件呼叫PlaySound方法
			coll.collider.SendMessage ("PlaySound");
			//GameObject.Find ("Score").SendMessage("AddScore", 10);
			Destroy (gameObject);
		} else if (coll.collider.name == "EnemyDestroyer") {
			Destroy (gameObject);
		}
	}*/
} 
