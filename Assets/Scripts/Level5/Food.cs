using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Food : MonoBehaviour {
	[SerializeField]Image fillImage;
	[SerializeField]Slider slider;
	public float attackNum;
	float attackUnit;
	float alpha;
	float alphaUnit;
	SpriteRenderer spriteRenderer;
	SpriteRenderer[] renderers;

	void Start () {

		if(fillImage.enabled){fillImage.enabled=false;}
		
		attackUnit=slider.maxValue/attackNum;
		spriteRenderer= GetComponent<SpriteRenderer> ();

		if(spriteRenderer.sprite==null){
			renderers=GetComponentsInChildren<SpriteRenderer>();
		}


		alpha = spriteRenderer.color.a;
		alphaUnit = alpha / attackNum;
	}

	void OnMouseDown(){

		if(!fillImage.enabled){
			fillImage.enabled=true;
		}

		if(spriteRenderer.sprite==null){
			foreach(SpriteRenderer s in renderers){
				Color c=s.color;
				c.a -=alphaUnit;
				s.color = new Color(c.r, c.g, c.b, c.a);
			}
		}else{
			Color c=spriteRenderer.color;
			alpha -=alphaUnit;
			spriteRenderer.color = new Color(c.r, c.g, c.b, alpha);
		}


		slider.value+=attackUnit;
				
		if(slider.value==slider.maxValue){
			ScoreDay5.AddScore((int)attackNum);
			GameObject.Find("FoodSpawner").GetComponent<FoodSpawner>().SpawnFood(gameObject.transform.position);			
			Destroy(gameObject);
		}

	}
	
	void Update () {				

		
	}
}
