using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	
	[SerializeField] private TextMeshProUGUI gameoverText;
	
	public bool isGameActive {get; private set;} = true;
	public float difficulty;
	
	public delegate void onEvent();
	public onEvent onGameOver, onGameStart;


	// Awake is called when the script instance is being loaded.
	protected void Awake()
	{
		onGameOver = delegate (){GameOver();};
		onGameStart = delegate (){StartGame();};
	}
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected IEnumerator Start()
	{
		yield return null;
	}

    // Update is called once per frame
    void Update()
    {
        
    }
    

	public void GameOver()
	{
		isGameActive = false;
		gameoverText.gameObject.SetActive(true);
		
	}
	
	public void RestartScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	
	public void StartGame()
	{
		
	}

}
