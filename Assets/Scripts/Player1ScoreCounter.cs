using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player1ScoreCounter : MonoBehaviour {

	public Text value;

	public void SetScore (int playerScore)
	{
		value.text = playerScore.ToString ();
	}
}
