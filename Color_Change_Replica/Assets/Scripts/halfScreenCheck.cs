using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halfScreenCheck : MonoBehaviour {

	public float cameraJumpSpeed = 10f;
	private Rigidbody2D halfBody;

	// Use this for initialization
	void Start () {
		halfBody = GetComponent<Rigidbody2D>();
	}

	private void OnTriggerStay2D(Collider2D collision)
	{
		if (collision.tag == "Player")
		{
			halfBody.velocity = Vector2.up * cameraJumpSpeed * 0.1f;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if(collision.tag == "Player")
		{
			halfBody.velocity = Vector2.up * cameraJumpSpeed * 0f;
		}
	}
}
