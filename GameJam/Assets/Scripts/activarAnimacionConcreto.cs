using UnityEngine;
using System.Collections;

public class activarAnimacionConcreto : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		Animator a = GetComponent<Animator>();
		if (other.gameObject.tag == "LaMuerte") {
			Debug.Log("Hubo colision");
			a.SetBool("colision", false);
		}
	}
		
}
