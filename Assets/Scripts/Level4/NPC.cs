using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour {

	bool hold =false;

	void FixedUpdate(){
		if(!hold)
			return;
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = new Vector3(mousePos.x,mousePos.y,0f);
	}

	void OnMouseDown(){
		hold = true;
	}

	void OnMouseUp(){
		hold = false;
	}
}