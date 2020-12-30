using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DifficultyButton : MonoBehaviour
{
	Button btn;
	public GameManager gm;
	public float difficulty = 1;
    // Start is called before the first frame update
    void Start()
	{
		btn = GetComponent<Button>();
		btn.onClick.AddListener(SetDifficulty);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	void SetDifficulty()
	{
		Debug.Log(btn);
		gm.difficulty = difficulty;
		gm.onGameStart();
	}

}
