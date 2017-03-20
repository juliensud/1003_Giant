using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionSystem : MonoBehaviour {

	public GameObject explosion; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if(other.CompareTag("destrutible") ){
			other.gameObject.SetActive(false);
			//Instantiate(explosion, other.transform.position, Quaternion.identity);
			other.transform.parent.GetComponent<buildingLife>().fragmentDestroy();
			GetComponent<VRTK.VRTK_ControllerActions>().TriggerHapticPulse(0.75f);
		}
	}
}
