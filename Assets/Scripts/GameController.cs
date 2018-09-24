using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public Player1ScoreCounter player1ScoreCounter;
	public Player2ScoreCounter player2ScoreCounter;

	public GameObject pauseMenu;
	public GameObject gameoverMenu;
	public GameObject ball;

	public int player1Score;
	public int player2Score;
	private int winningScore = 10;

	void Update()
	{
		ball = GameObject.FindGameObjectWithTag ("Ball");

		player1ScoreCounter.SetScore (player1Score);
		player2ScoreCounter.SetScore (player2Score);

		Pause ();

		if (player1Score >= winningScore || player2Score >= winningScore) 
		{
			gameoverMenu.SetActive(true);
			Time.timeScale = 0.0f;
			Destroy(ball);

			if(Input.GetKeyDown("space"))
				Application.LoadLevel("Pong");
		}
	}
	
	void Pause()
	{
		if (Input.GetKeyDown ("escape"))
		{
			//toggle pausing
			if (Time.timeScale == 0.0f)
			{
				pauseMenu.SetActive(false);
				Time.timeScale = 1.0f;
			}
			else
			{
				pauseMenu.SetActive(true);
				Time.timeScale = 0.0f;
			}
		}
	}

	public void SetPlayerScore()
	{
		player1Score++;
		Instantiate (ball, new Vector3(0,0,0), new Quaternion(0,0,0,0));


	}

	public void SetAIScore()
	{
		player2Score++;
		Instantiate (ball, new Vector3(0,0,0), new Quaternion(0,0,0,0));
	}
}
