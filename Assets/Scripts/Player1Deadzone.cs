using UnityEngine;
using System.Collections;

public class Player1Deadzone : MonoBehaviour {

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
			gameController.SetAIScore ();
			Destroy (col.gameObject);
		}
	}
}
