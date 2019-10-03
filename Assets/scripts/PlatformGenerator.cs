using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

	public GameObject platformPrefab;

	public int numberOfPlatforms = 200;
	public float levelWidth = 10f;
	public float minY = 3.0f;
	public float maxY = 4.0f;
	private Vector3 spawnPosition = new Vector3();

	// Use this for initialization
	void Start () {
		float prevXPos = 0;
		spawnPosition.x = Random.Range(-levelWidth, levelWidth);
		spawnPlatform(spawnPosition);
		prevXPos = spawnPosition.y;
		for (int i = 0; i < numberOfPlatforms; i++)
		{
	
				spawnPosition.y += ((int)(Random.Range(minY,maxY)) + 2);
				spawnPosition.x = Random.Range(-levelWidth, levelWidth);
				spawnPlatform(spawnPosition);
				Debug.Log("Spawned");
		}
	}

	private void spawnPlatform(Vector3 spawnPos)
	{
	spawnPos.x = Random.Range(-levelWidth, levelWidth);
	GameObject currentPrefab = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
	currentPrefab.gameObject.SetActive(true);
	}
}