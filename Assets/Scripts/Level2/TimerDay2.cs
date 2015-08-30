using UnityEngine;

//nityEngine.UI是使用新UI的套件
using UnityEngine.UI;
using System.Collections;

public class TimerDay2 : MonoBehaviour
{
	
	Text timerText;
	bool gameOver = false;
	
	void Start ()
	{
		//取得Text元件
		timerText = GetComponent<Text> ();
	}
	
	public float nowTime = 30f;
	
	void Update ()
	{
		if (nowTime <= 0) {
			TimeISUp ();
			return;
		}
		
		//Time.deltaTime為每一影格經過的時間
		nowTime -= Time.deltaTime;
		//"F0"表示取小點第0位
		timerText.text = "Time: " + nowTime.ToString ("F0");
	}
	
	void TimeISUp ()
	{
		if (gameOver == false) {
			gameOver = true;
			//尋找EnemySpawner物件的EnemySpawner元件的StopSpaw方法
			GameObject.Find ("EnemySpawner").GetComponent<EnemySpawner> ().StopSpaw ();
			//GameObject.Find ("EnemySpawner").SendMessage("StopSpawn");

			Application.LoadLevel(4);
			//Invoke ("ChangeSceneToResult", 3f);
		}
	}
	
//	void ChangeSceneToResult ()
//	{
//		int finalScore = ScoreDay4.scoreDay4;
//		//PlayerPrefs用於傳遞資料於不同場景
//		PlayerPrefs.SetInt ("FinalScore", finalScore);
//		Application.LoadLevel ("Result");
//	}
}