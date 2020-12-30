using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
	private Rigidbody rb;
	private ScoreManager score;
	public float xmin,xmax,forceMin,forceMax,torqueMin,torqueMax;
	public int pointClicked = 1;
	public int pointMissed = -1;
	public ParticleSystem clickedParticles;
    // Start is called before the first frame update
    void Start()
	{
		score = GameObject.Find("Game Manager").GetComponent<ScoreManager>();
	    rb = GetComponent<Rigidbody>();
	    rb.AddTorque(RandomTorque(), ForceMode.Impulse);
	    rb.AddForce(RandomForce(), ForceMode.Impulse);
	    transform.position = RandomXPosition();
	    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	// OnTriggerEnter is called when the Collider other enters the trigger.
	protected IEnumerator OnTriggerEnter(Collider other)
	{
		score.UpdateScore(pointMissed);
		Destroy(gameObject);
		yield return null;
	}
    
	// OnMouseDown is called when the user has pressed the mouse button while over the GUIElement or Collider.
	protected IEnumerator OnMouseDown()
	{
		Instantiate(clickedParticles, transform.position, clickedParticles.transform.rotation);
		score.UpdateScore(pointClicked);
		Destroy(gameObject);
		yield return null;
	}
	Vector3 RandomXPosition()
	{
		return new Vector3(Random.Range(xmin, xmax), 
			-6, 
			0);
	}
	
	Vector3 RandomTorque()
	{
		return new Vector3(Random.Range(torqueMin, torqueMax), 
			Random.Range(torqueMin, torqueMax), 
			Random.Range(torqueMin, torqueMax));
	}
	
	Vector3 RandomForce()
	{
		return  Vector3.up * Random.Range(forceMax, forceMin);
	}
}
