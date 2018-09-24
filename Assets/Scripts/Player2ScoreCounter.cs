using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player2ScoreCounter : MonoBehaviour {

	public Text value;

	public void SetScore(int AIScore)
	{
		value.text = AIScore.ToString ();
	}
}
