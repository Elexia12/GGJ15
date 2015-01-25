using UnityEngine;
using System.Collections;

public class activarAnimacionFantasma : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		Animator a = GetComponent<Animator>();
		if (other.gameObject.tag == "Fantasma") {
			Debug.Log("Hubo colision");
			a.SetBool("colision", false);
		}
	}
	
}

