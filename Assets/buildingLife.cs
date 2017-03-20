using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingLife : MonoBehaviour {

	public int requiredfragmentToDestroy = 15;

	private int fragmentDestroyed = 0;
	
	public void fragmentDestroy() {
		fragmentDestroyed++;

		if(fragmentDestroyed == requiredfragmentToDestroy) {
			foreach(Transform e in transform) {
				if( e.CompareTag("destrutible") ) {
					e.GetComponent<MeshCollider>().isTrigger = false;
					e.gameObject.AddComponent<Rigidbody>();
				}
			}
		}
	}




		
}
