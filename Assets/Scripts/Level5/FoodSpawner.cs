using UnityEngine;
using System.Collections;

public class FoodSpawner : MonoBehaviour
{
	public GameObject[] foodPrefabs;
	Vector3[] positions;
	int counter;
	[SerializeField] GameObject deskObject;

	void Start ()
	{
		positions = new Vector3[3];
		positions [0] = new Vector3 (2.17f, -1.3f, 0f);
		positions [1] = new Vector3 (-2.1f, -1.3f, 0f);
		positions [2] = new Vector3 (0.04f, -1.3f, 0f);

		foreach (Vector3 v3 in positions) {
			GameObject childObject =Instantiate (
				foodPrefabs [Random.Range (0, foodPrefabs.Length)], 
				v3,
				Quaternion.identity
			)as GameObject;
					
			childObject.transform.parent=deskObject.transform;
		}


	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	public void SpawnFood (Vector3 pos)
	{
		//deskObject.GetComponent<DeskMovement>().StopToSpawnFood();

		if (counter >= 3) {
			counter = 0;
		}



		counter++;

		if (counter != 3)
			return;

		for (int i=0; i<positions.Length; i++) {
			GameObject childObject=Instantiate (
					foodPrefabs [Random.Range (0, foodPrefabs.Length)], 
					positions [i],
					Quaternion.identity
			) as GameObject;

			childObject.transform.parent=deskObject.transform;
			Vector3 v=deskObject.transform.localPosition+positions[i];
			childObject.transform.position=new Vector3(v.x,v.y+2.97f,v.z);

					
		}

	}

}
