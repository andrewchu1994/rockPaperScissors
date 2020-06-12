using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rockAnswer : MonoBehaviour {

	public Button someButton;
	private int answerVal = 2;
	private randomEnemy enemy;
	private bool correct;

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
			Destroy(enemy.instantiatedObj2);
			enemy.Spawn ();
			correctAns += 1;
			sound.Play ();


		} else {

			correct = false;
			SceneManager.LoadScene ("endScreen");


		}


	}


}
