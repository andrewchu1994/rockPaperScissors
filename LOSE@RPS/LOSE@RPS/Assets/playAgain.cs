using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playAgain : MonoBehaviour {

	public Text highScore;
	public Text score;

	// Use this for initialization
	void Start () {

		highScore.text = "Highscore: " + (PlayerPrefs.GetInt ("Highscore", 0).ToString ());
		score.text = "Score: " + (PlayerPrefs.GetInt ("Score", 0).ToString ());

		
	}

	public void back(){

		SceneManager.LoadScene ("home");

	}


}
