using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public List<GameObject> targets;
	public float spawnInterval;
	WaitForSeconds wait;
	Coroutine spawnConinously;
	public GameManager gm;
	private bool spawning = true;
	
	// Start is called before the first frame update
	void Start()
	{
		
		
		gm = GetComponent<GameManager>();
		gm.onGameStart += StartSpawning;
		gm.onGameOver += StopSpawning;
		
	    
	}

	IEnumerator SpawnConinously()
	{
		while (true)
		{
			yield return wait;
			Instantiate(targets[Random.Range(0,targets.Count)]);
		}
	}
	void StartSpawning()
	{Debug.Log("start Spawning");
		wait = new WaitForSeconds(spawnInterval/=gm.difficulty);
		spawnConinously =  StartCoroutine(SpawnConinously());
	}
	void StopSpawning()
	{
		Debug.Log("Stop Spawning");
		StopCoroutine(spawnConinously);
	}
	

}
