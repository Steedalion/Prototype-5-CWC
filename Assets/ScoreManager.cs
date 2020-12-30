using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI scoreText;
	private int score = 0;
	public GameManager gm;
    // Start is called before the first frame update
    void Start()
	{
		gm.onGameStart += UpdateScore;
		gm.onGameOver += ()=> {Debug.Log("Score stopped");};
		
        
    }

	public void UpdateScore(int scoreToAdd)
	{
		if(!gm.isGameActive) return;
		score += scoreToAdd;
		scoreText.text = "Score :"+score;
		if(score < 0)
		{
			gm.onGameOver();
		}
	}
	public void UpdateScore()
	{
		UpdateScore(0);
	}
}
