using UnityEngine;
using System.Collections;

public class activarAnimacionFantasma : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		Animator a = GetComponent<Animator> ();
		if (other.gameObject.tag == "LaMuerte") {
			Debug.Log ("Hubo colision");
			a.SetBool ("colision", true);
	 	}

	}	

	float amplitudeX = -25.0f;
	float amplitudeY = 5.0f;
	float omegaX = 0.5f;
	float omegaY = 4.0f;
	float index;
	
	void Update () {
		index += Time.deltaTime;
		float x = amplitudeX*Mathf.Cos (omegaX*index);      
		//float y = Mathf.Abs (amplitudeY*Mathf.Sin (omegaY*index));
		transform.localPosition= new Vector3(x,transform.localPosition.y,0);
	}
}



