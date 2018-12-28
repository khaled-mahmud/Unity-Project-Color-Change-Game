using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreHandler : MonoBehaviour {

	public GameObject currentScore;
	public GameObject highScore;

	private TextMesh currentScoreText;
	private TextMesh highScoreText;

	private int current;
	private int high;

	// Use this for initialization
	void Start () {

		//PlayerPrefs.SetString("highScore", "0");

		//targeting the text mesh components
		currentScoreText = currentScore.GetComponent<TextMesh>();
		highScoreText = highScore.GetComponent<TextMesh>();

		//changing the current score
		currentScoreText.text = PlayerPrefs.GetString("currentScore");

		//check if the current score is greater than the highscore
		current = System.Convert.ToInt32(PlayerPrefs.GetString("currentScore"));

		//checks if it is the first time the game has been opened
		if(PlayerPrefs.GetInt("FirstTimeOpenning", 1) == 1)
		{
			PlayerPrefs.SetInt("FirstTimeOpenning", 0);
			PlayerPrefs.SetString("highScore", "0");
		}
		else
		{
			high = System.Convert.ToInt32(PlayerPrefs.GetString("highScore"));

			if (current > high)
			{
				PlayerPrefs.SetString("highScore", System.Convert.ToString(current));
			}
			highScoreText.text = PlayerPrefs.GetString("highScore");
		}

		/*high = System.Convert.ToInt32(PlayerPrefs.GetString("highScore"));

		if(current > high)
		{
			PlayerPrefs.SetString("highScore", System.Convert.ToString(current));
		}
		highScoreText.text = PlayerPrefs.GetString("highScore");*/

	}
	
}
