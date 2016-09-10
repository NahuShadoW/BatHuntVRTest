using UnityEngine;
using System.Collections;

public class DeathBytime : MonoBehaviour {

	private float lifeTime = 12f;
	private float startTime = 0f;
	private float elapsedTime;

	void Update () {

		startTime += Time.deltaTime;

		if (startTime >= lifeTime){

		startTime -= lifeTime;
		Destroy(this.gameObject, lifeTime);
		GameObject.Find("GameController").GetComponent<GameController>().UpdateMissCount(1);
		}
	}
	

}
