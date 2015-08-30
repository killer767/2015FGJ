using UnityEngine;
using System.Collections;

public class Player4 : MonoBehaviour {

	void Start(){
		
	}

	void FixedUpdate () {
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		transform.position = new Vector3 (
			Mathf.Clamp(mousePos.x - 1.5f, -10f, 8f),
			Mathf.Clamp(mousePos.y - 0.5f, -3f, 3f),
			0f);
	}
}