using UnityEngine;
using System.Collections;

public class BallReflection : MonoBehaviour {

	private float ballSpeed = 5f;
	private float maxMoveSpeed = 5f;

	private Vector2 ballMovement;

	private AudioSource audio;

	private Rigidbody2D rb;

	void Awake()
	{
		audio = GetComponent<AudioSource> ();

		GetComponent<Rigidbody2D>().velocity = new Vector2 (-1, -1) * ballSpeed;
	}

	void FixedUpdate()
	{
		ballMovement = GetComponent<Rigidbody2D>().velocity;
	
		if (GetComponent<Rigidbody2D>().velocity.magnitude > maxMoveSpeed)
		{
			this.GetComponent<Rigidbody2D>().velocity = this.GetComponent<Rigidbody2D>().velocity.normalized * maxMoveSpeed;
		}

	}

	void OnCollisionEnter2D(Collision2D col)
	{
		//play audio
		audio.Play ();

		if (col.gameObject.tag == "Bumper")
		{
			ballMovement.x = ballMovement.x * -2;
			ballMovement.y = ballMovement.y * 2;
			transform.GetComponent<Rigidbody2D>().velocity = ballMovement;
		}
		else if (col.gameObject.tag == "Border")
		{
			ballMovement.x = ballMovement.x * 2;
			ballMovement.y = ballMovement.y * -2;
			transform.GetComponent<Rigidbody2D>().velocity = ballMovement;
		}
	}
}
