using UnityEngine;
using System.Collections;

public class BackgroundScrollScript : MonoBehaviour {

	public float speed;
	public float x;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		x = Mathf.Repeat (Time.time*speed,1);
		renderer.sharedMaterial.SetTextureOffset ("_MainTex", new Vector2(0,x));
	}
}
