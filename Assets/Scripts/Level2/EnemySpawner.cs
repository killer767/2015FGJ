using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
	public GameObject[] enemyPrefab;
	
	void Start ()
	{	//0.1秒後每0.5秒重複呼叫SpawnEnemy function
		InvokeRepeating ("SpawnEnemy", .1f, .5f);
	}
	
	void SpawnEnemy (){
		Instantiate (
			enemyPrefab [Random.Range (0, enemyPrefab.Length)], 
			new Vector2 (Random.Range (-20f, 20f), -17f),
			Quaternion.identity
		);



	}

	public void StopSpaw ()
	{
		//停止呼叫InvokeRepeating
		CancelInvoke ("SpawnEnemy");
	}
}
