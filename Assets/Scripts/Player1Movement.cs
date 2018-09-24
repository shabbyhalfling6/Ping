using UnityEngine;
using System.Collections;

public class Player1Movement : MonoBehaviour {

	private float movementSpeed = 5.0f;

	void FixedUpdate () 
	{
		float move = Input.GetAxis ("Vertical");

		GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, move * movementSpeed);
	}

}
