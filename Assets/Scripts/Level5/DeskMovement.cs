using UnityEngine;
using System.Collections;

public class DeskMovement : MonoBehaviour
{
	public float speed = 5f;
	float yPos;
	float xPos;
	bool isMoveable=true;
	void Start ()
	{
		yPos=transform.position.y;
		xPos=transform.position.x;

	}


	public void StartToSpawnFood(){
		isMoveable=true;
	}
	public void StopToSpawnFood(){
		isMoveable=false;
	}

	void Update ()
	{
		if(!isMoveable){return;}

		xPos=Mathf.Clamp(xPos+speed*Time.deltaTime,-5.28f,5.28f);
		yPos=Mathf.Clamp(yPos+speed*Time.deltaTime,-3.67f,-0.35f);
		
		if(Mathf.Abs(xPos)==5.28f){
			speed=speed*(-1f);
			yPos=Random.Range(-3.67f,-0.35f);					
		}

		transform.position=new Vector3(
			xPos,
			yPos,
			transform.position.z
			);
	}


}
