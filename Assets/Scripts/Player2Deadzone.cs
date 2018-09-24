using UnityEngine;
using System.Collections;

public class Player2Deadzone : MonoBehaviour {
	
	public GameObject ball;
	public GameController gameController;
	
	void Update()
	{
		ball = GameObject.FindGameObjectWithTag ("Ball");
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Ball") 
		{
			gameController.SetPlayerScore ();
			Destroy (col.gameObject);
		}
	}
}
