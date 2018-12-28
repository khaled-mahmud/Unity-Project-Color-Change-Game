using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour {

	private SpriteRenderer playerSprite;

	public GameObject score;
	private TextMesh scoreText;

	public ParticleSystem starParticle;
	public ParticleSystem plusOne;

	public ParticleSystem gameOverRed;
	public ParticleSystem gameOverYellow;
	public ParticleSystem gameOverCyan;
	public ParticleSystem gameOverMagenta;

	private SpriteRenderer playerSpriteRenderer;
	private Rigidbody2D playerBody;

	public void killPlayer()
	{
		SceneManager.LoadScene("gameoverScene");
	}

	private void Start()
	{
		scoreText = score.GetComponent<TextMesh>();
		PlayerPrefs.SetString("currentScore", "0");
		playerSpriteRenderer = GetComponent<SpriteRenderer>();
		playerBody = GetComponent<Rigidbody2D>();
	}

	//check if it collided with the obstacle
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Obstacle")
		{
			if(collision.name != name)
			{
				if(name == "Red")
				{
					gameOverRed.Play();
				}else if (name == "Yellow")
				{
					gameOverYellow.Play();
				}else if (name == "Cyan")
				{
					gameOverCyan.Play();
				}else
				{
					gameOverMagenta.Play();
				}

				PlayerPrefs.SetString("currentScore", scoreText.text);
				playerSpriteRenderer.enabled = false;
				playerBody.constraints = RigidbodyConstraints2D.FreezePositionY;
				Invoke("killPlayer", 1);
			}
		}
		//check if it is collided with a color changer
		else if (collision.tag == "ColorChanger")
		{
			Destroy(collision.gameObject);

			playerSprite = GetComponent<SpriteRenderer>();
			//if the player is yellow
			if(name == "Yellow")
			{
				int ran = Random.Range(0, 3);

				switch (ran)
				{
					case 0:
						//change color to red
						playerSprite.color = new Color(1.000f, 0.000f, 0.000f);
						name = "Red";
						break;
					case 1:
						//change color to magenta
						playerSprite.color = new Color(1.000f, 0.000f, 1.000f);
						name = "Magenta";
						break;
					case 2:
						//change color to cyan
						playerSprite.color = new Color(0.000f, 1.000f, 1.000f);
						name = "Cyan";
						break;
				}
			}

			//if the player is red
			else if (name == "Red")
			{
				int ran = Random.Range(0, 3);

				switch (ran)
				{
					
					case 0:
						//change color to yellow
						playerSprite.color = new Color(1.000f, 1.000f, 0.000f);
						name = "Yellow";
						break;
					case 1:
						//change color to magenta
						playerSprite.color = new Color(1.000f, 0.000f, 1.000f);
						name = "Magenta";
						break;
					case 2:
						//change color to cyan
						playerSprite.color = new Color(0.000f, 1.000f, 1.000f);
						name = "Cyan";
						break;
				}
			}

			//if the player is cyan
			else if (name == "Cyan")
			{
				int ran = Random.Range(0, 3);

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
				}
			}

			//if the player is magenta
			else if (name == "Magenta")
			{
				int ran = Random.Range(0, 3);

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
						//change color to cyan
						playerSprite.color = new Color(0.000f, 1.000f, 1.000f);
						name = "Cyan";
						break;
				}
			}

			
		}
		//check if it is collided with a point
		else if (collision.tag == "Point")
		{
			//+1 to score text
			scoreText.text = System.Convert.ToString(System.Convert.ToInt32(scoreText.text) + 1);

			Destroy(collision.gameObject);
			starParticle.Play();
			plusOne.Play();

		}

	}
}
