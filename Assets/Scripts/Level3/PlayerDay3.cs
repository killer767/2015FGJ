using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerDay3 : MonoBehaviour {

	float num;
	public GameObject prefab;
	public Scrollbar scroll;
	bool isRe;
	bool isJump;
	
	void Start () {
		num = 0;
		isJump = false;
		GameObject obj = (GameObject)Instantiate(prefab);
		obj.name = "Incense";
	}
	
	void Update () {
		if (Input.GetKey (KeyCode.Space) && isJump == false) {
			
			num = num + 0.5f;
			num = Mathf.Clamp(num, 0, 10);
			scroll.size = num * 0.1f;
			Debug.Log (num);
		}
		
		if (Input.GetKeyUp (KeyCode.Space) && isJump == false) {
			isJump = true;
			GameObject.Find("Incense").GetComponent<Rigidbody2D>().AddForce(new Vector2(300, num * 30));
			isRe = false;
		}
	}
	
	//	void OnCollisionEnter2D(Collision2D coll){
	//		if (coll.collider.tag == "Down" && isRe == false) {
	//			Destroy(GameObject.Find("Incense"));
	//			StartCoroutine("Re");
	//			isRe = true;
	//			num = 0;
	//		}
	
	public void Incen(){
		StartCoroutine ("Re");
		num = 0;
	}
	
	IEnumerator Re(){
		yield return new WaitForSeconds(.5f);
		GameObject obj = (GameObject)Instantiate(prefab);
		obj.name = "Incense";
		scroll.size = 0;
		isJump = false;
		yield return new WaitForSeconds(2f);
	}
}