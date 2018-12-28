using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStartColor : MonoBehaviour {

	private SpriteRenderer playerSprite;

	public void startColorChanger()
	{
		int ran = Random.Range(0, 4);
		playerSprite = GetComponent<SpriteRenderer>();

		switch (ran)
		{
			case 0:
				//change color to red
				playerSprite.color = new Color(1.000f, 0.000f, 0.000f);
				name = "Red";
				break;
			case 1:
				//change color to yellow
				playerSprite.color = new Color(1.000f, 1.000f, 0.000f);
				name = "Yellow";
				break;
			case 2:
				//change color to magenta
				playerSprite.color = new Color(1.000f, 0.000f, 1.000f);
				name = "Magenta";
				break;
			case 3:
				//change color to cyan
				playerSprite.color = new Color(0.000f, 1.000f, 1.000f);
				name = "Cyan";
				break;
		}
	}

	
	
	// Use this for initialization
	void Start () {
		startColorChanger();
	}
	
}
