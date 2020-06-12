using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomEnemy : MonoBehaviour {

	public GameObject[] randomChoice;
	int index;
	public int val;
	public GameObject instantiatedObj1, instantiatedObj2, instantiatedObj3;


	// Use this for initialization
	void Start () {

	
		Invoke ("Spawn", 0f);


		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	public void Spawn(){

		index = Random.Range (0, randomChoice.Length);

		if (index == 0) {
			
			instantiatedObj1 = (GameObject)Instantiate (randomChoice [0], new Vector3 (0f, .75f, 0), Quaternion.identity);
			val = 1;
		} else if (index == 1) {
			
			instantiatedObj2 = (GameObject)Instantiate (randomChoice [1], new Vector3 (0f, .75f, 0), Quaternion.identity);
			val = 2;
		}else {
			
			instantiatedObj3 = (GameObject)Instantiate (randomChoice [2], new Vector3 (0f, .75f, 0), Quaternion.identity);
			val = 3;

	}

}
}
