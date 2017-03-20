using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrinking : MonoBehaviour {



	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A)) {
			print("reduce size");
			reduceSize(0.25f);
		}
	}


	void reduceSize(float amount) {
		transform.localScale -= new Vector3(amount, amount, amount);

		if(transform.localScale.x <= 0.05f) {
			transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
		}
	}

	void IncrementSize(float amount) {
		transform.localScale += new Vector3(amount, amount, amount);
	}


}
