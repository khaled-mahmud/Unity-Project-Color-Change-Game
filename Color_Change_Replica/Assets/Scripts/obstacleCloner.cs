using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleCloner : MonoBehaviour {

	public GameObject smallCirclePrefab;
	public GameObject smallCircleSpawnpoint;

	public GameObject smallRectanglePrefab;
	public GameObject smallRectangleSpawnPoint;

	public GameObject colorChangerPrefab;
	public GameObject colorChangerSpawnpoint;

	public GameObject pointPrefab;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Spawn")
		{
			//clone obstacle
			int ran = Random.Range(0, 2);

			if (ran == 0)
			{
				//SmallCircle
				Instantiate(smallCirclePrefab, smallCircleSpawnpoint.transform.position, smallCircleSpawnpoint.transform.rotation);
				Instantiate(colorChangerPrefab, colorChangerSpawnpoint.transform.position, colorChangerSpawnpoint.transform.rotation);
				Instantiate(pointPrefab, smallCircleSpawnpoint.transform.position, smallCircleSpawnpoint.transform.rotation);
			}
			else if(ran == 1)
			{
				//Small Rectangle
				Instantiate(smallRectanglePrefab, smallRectangleSpawnPoint.transform.position, smallRectangleSpawnPoint.transform.rotation);
				Instantiate(colorChangerPrefab, colorChangerSpawnpoint.transform.position, colorChangerSpawnpoint.transform.rotation);
				Instantiate(pointPrefab, smallRectangleSpawnPoint.transform.position, smallRectangleSpawnPoint.transform.rotation);
			}
		}
	}
}
