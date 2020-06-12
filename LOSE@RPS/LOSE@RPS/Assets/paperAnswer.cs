using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class paperAnswer : MonoBehaviour {

	public Button someButton;
	private int answerVal = 3;
	private randomEnemy enemy;
	public bool correct;

	private timer timeReset;

	public int correctAns = 0;
	public AudioSource sound;

	// Use this for initialization
	void Start () {

		Button btn = someButton.GetComponent<Button> ();
		btn.onClick.AddListener (clicked);
		enemy = FindObjectOfType<randomEnemy> ();
		timeReset = FindObjectOfType<timer> ();



	}

	// Update is called once per frame
	void Update () {

	

	}

	void clicked(){

		if (enemy.val == answerVal) {

			correct = true;
			timeReset.time = 3.5f;
			correctAns += 1;
			Destroy(enemy.instantiatedObj3);
			enemy.Spawn ();
			sound.Play ();

		} else {

			correct = false;
			SceneManager.LoadScene ("endScreen");

		}

	}



}