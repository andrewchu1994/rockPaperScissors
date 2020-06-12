using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {

	Image imgFill;
	float timeAmt = 3.5f;
	public float time;
	public Text countText;
	public Text highScores;

	private	 rockAnswer rockCorrect;
	private scissorsAnswer scissorsCorrect;
	private paperAnswer paperCorrect;
	public int totalCorrect;

	// Use this for initialization
	public void Start () {


		rockCorrect = FindObjectOfType<rockAnswer> ();
		scissorsCorrect = FindObjectOfType<scissorsAnswer> ();
		paperCorrect = FindObjectOfType<paperAnswer> ();

		imgFill = this.GetComponent<Image> ();
		time = timeAmt;
		setCountText ();


		highScores.text =  "Highscore: " + (PlayerPrefs.GetInt ("Highscore", 0).ToString ());
	}
	
	// Update is called once per frame
	void Update () {

		totalCorrect = rockCorrect.correctAns + scissorsCorrect.correctAns + paperCorrect.correctAns;
		setCountText ();

		if (time > 0 && totalCorrect <= 7) {
			time -= Time.deltaTime;
			imgFill.fillAmount = time / timeAmt;


		} else if (time > 0 && totalCorrect > 7 && totalCorrect <= 14) {

			time -= Time.deltaTime*2f;
			imgFill.fillAmount = time / timeAmt;

		} else if (time > 0 && totalCorrect > 14 && totalCorrect <= 21) {

			time -= Time.deltaTime*3f;
			imgFill.fillAmount = time / timeAmt;

		} else if (time > 0 && totalCorrect > 21 && totalCorrect <= 28) {

			time -= Time.deltaTime*3.5f;
			imgFill.fillAmount = time / timeAmt;

		} else if (time > 0 && totalCorrect > 28 && totalCorrect <= 35) {

			time -= Time.deltaTime*4f;
			imgFill.fillAmount = time / timeAmt;

		} else if (time > 0 && totalCorrect > 35 && totalCorrect <= 39) {

			time -= Time.deltaTime*4.5f;
			imgFill.fillAmount = time / timeAmt;

		} else if (time > 0 && totalCorrect > 39 && totalCorrect <= 43) {

			time -= Time.deltaTime*5f;
			imgFill.fillAmount = time / timeAmt;

		} else if (time > 0 && totalCorrect > 43 && totalCorrect <= 47) {

			time -= Time.deltaTime*5.5f;
			imgFill.fillAmount = time / timeAmt;

		} else if (time > 0 && totalCorrect > 47 && totalCorrect <= 51) {

			time -= Time.deltaTime*6f;
			imgFill.fillAmount = time / timeAmt;

		} else if (time > 0 && totalCorrect > 51) {

			time -= Time.deltaTime*7f;
			imgFill.fillAmount = time / timeAmt;

		}
			
		else{

			SceneManager.LoadScene ("endScreen");
		}
		
	}

	public void setCountText(){
		
		countText.text = totalCorrect.ToString ();
		PlayerPrefs.SetInt ("Score", totalCorrect);

		if (totalCorrect > PlayerPrefs.GetInt ("Highscore", 0)) {
			 
			PlayerPrefs.SetInt ("Highscore", totalCorrect);
			highScores.text = "Highscore: " + totalCorrect.ToString ();
		}
	}
		

		
}
