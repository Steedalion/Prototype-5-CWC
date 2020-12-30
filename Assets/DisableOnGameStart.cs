using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnGameStart : MonoBehaviour
{
	public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
	    gm.onGameStart += DisableMe;
    }
    
	public void DisableMe()
	{
		gameObject.SetActive(false);
	}
	
	public void EnableMe()
	{
		
	}
}
