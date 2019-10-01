using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

	public GameObject platformPrefab;

	public int numberOfPlatforms = 200;
	public float levelWidth = 10f;
	public float minY = 20.0f;
	public float maxY = 30.0f;

	// Use this for initialization
	void Start () {

		Vector3 spawnPosition = new Vector3();

		for (int i = 0; i < numberOfPlatforms; i++)
		{
			spawnPosition.y += minY;
			spawnPosition.x = Random.Range(-levelWidth, levelWidth);
			GameObject currentPrefab = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
			platformPrefab.gameObject.SetActive(true);
			spawnPosition.y = currentPrefab.gameObject.transform.position.y;
		}
	}
}
