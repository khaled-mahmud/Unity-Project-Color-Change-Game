using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour {
	//Change scene when button is pressed

	private void OnMouseDown()
	{
		SceneManager.LoadScene("playScene");
	}


}
