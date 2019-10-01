using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

	public GameObject platformPrefab;

	public int numberOfPlatforms = 200;
	public float levelWidth = 10f;
	public float minY = 15.0f;
	public float maxY = 120.0f;
	private Vector3 spawnPosition = new Vector3();

	// Use this for initialization
	void Start () {
		spawnPosition.y = minY;
		spawnPosition.x = Random.Range(-levelWidth, levelWidth);
		spawnPlatform(spawnPosition);

		for (int i = 0; i < numberOfPlatforms; i++)
		{
			spawnPosition.y += maxY;
			spawnPosition.x = Random.Range(-levelWidth, levelWidth);
			spawnPlatform(spawnPosition);
			
		}
	}

	private void spawnPlatform(Vector3 spawnPos)
	{
	spawnPos.x = Random.Range(-levelWidth, levelWidth);
	GameObject currentPrefab = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
	platformPrefab.gameObject.SetActive(true);
	spawnPos.y += currentPrefab.gameObject.transform.position.y;
	}
}


