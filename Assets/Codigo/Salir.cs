using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// llamamos a una funcion que nos dice si se ha pulsado una tecla concreta.
		// configuramos para que al pulsar escape salga del juego
		if (Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit (); // solo funcionara cuando hallamos exportado el juego
		}
	}
}
