using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public Transform[] spawnPoints;
	public float spawnTime = 5f;
	public GameObject[] duckPrefabs;


	// Use this for initialization
	void Start () {
			
		InvokeRepeating ("Spawn", spawnTime, 10f);
	}

	void Spawn (){

		while (true){
			for (int i = 0;  i <= duckPrefabs.Length ; i ++ ){

		
				Instantiate (duckPrefabs[i].gameObject, spawnPoints[i].position, spawnPoints[i].rotation);
			}
		}
	}

}
