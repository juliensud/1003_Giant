using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosedOnTouch : MonoBehaviour {

	public GameObject explosiveEffect;


	void OnTriggerEnter(Collider other ) {
		if(other.CompareTag("destrutible")) {
			Instantiate(explosiveEffect, transform.position, Quaternion.identity);
			foreach (Collider e in  Physics.OverlapSphere(transform.position, 0.45f) ) {
				if(e.CompareTag("destrutible"))
					e.gameObject.SetActive(false);
					other.transform.parent.GetComponent<buildingLife>().fragmentDestroy();
			}
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter(Collision other ) {
		if(other.transform.CompareTag("destrutible")) {
			Instantiate(explosiveEffect, transform.position, Quaternion.identity);
			foreach (Collider e in  Physics.OverlapSphere(transform.position, 0.45f) ) {
				if(e.CompareTag("destrutible"))
					e.gameObject.SetActive(false);
				other.transform.parent.GetComponent<buildingLife>().fragmentDestroy();
			}
			Destroy(gameObject);
		}
	}


	
}
