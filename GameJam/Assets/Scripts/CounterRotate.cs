using UnityEngine;
using System.Collections;

public class CounterRotate : MonoBehaviour {
	
	public float vel;
	
	// Use this for initialization
	void Start () {
		vel = 3.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
			transform.Rotate(Vector3.forward * vel);
		}
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
			transform.Rotate(Vector3.back * vel);
		}
	}
}
