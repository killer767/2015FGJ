using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	Animator anim;
	float num;
	bool isFire;

	void Start () {
		anim = GetComponentInChildren<Animator> ();
		isFire = false;
	}
	
	void FixedUpdate () {
		if (isFire == false) {
			isFire = true;
			StartCoroutine ("FireShowTime");
		}
	}
	
	IEnumerator FireShowTime(){
		num = Random.Range (1f, 3f);
		yield return new WaitForSeconds (num);
		anim.SetBool ("Fire", true);
		yield return new WaitForSeconds(2f);
		anim.SetBool ("Fire", false);
		isFire = false;

	}
}
