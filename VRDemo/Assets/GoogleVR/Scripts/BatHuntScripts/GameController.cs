using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	
	private int score;
	public Text scoreText;
	public Text missCountText;
	private int missCount;
	void Start()
	{
		score = 0;
		UpdateScore(0);
		UpdateMissCount(0);


	}
	
	public void UpdateScore(int value)
	{
		score += value;
		scoreText.text = "Score: " + score;
	}

	public void UpdateMissCount(int misses){

		missCount += misses;
		missCountText.text = "Missed Bats: " + missCount + "/50";

		if (missCount >= 50){
			
			GameOver();
		}
	}

	public void GameOver (){

		Application.LoadLevel("GameOverScene");
	}

	public void RestartGame (){


		Application.LoadLevel("GameplayScene");
	}
}