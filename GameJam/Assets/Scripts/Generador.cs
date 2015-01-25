using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {

	public GameObject[] objetos;
	public float tiempoMin = 1f;
	public float tiempoMax = 2f;
	// Use this for initialization
	void Start () {
		generarObjetoRandom ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void generarObjetoRandom(){
		Instantiate (objetos[Random.Range(0,objetos.Length)],transform.position, Quaternion.identity);
		Invoke ("generarObjetoRandom", Random.Range (tiempoMin, tiempoMax));
	}
}
