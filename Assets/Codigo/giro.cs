using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giro : MonoBehaviour {
	// inicializamos valores en los cuales queremos que rote, es decir, cuanto girara en x, y , z en cada frame. 
	// (Una especie de animacion o movimiento)

	Vector3 rotacion = new Vector3(15,30,45);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	/*
	Que pasaría si rotamos 15 grados en x en cada fotograma, si cada fotograma se ejecuta 30 veces por segundo, estaríamos rotando 30 
	veces 15 en un segundo. Unity tiene una variable que cuenta el tiempo que ha pasado de fotograma en fotograma. De modo que, si
	definimos velocidades por segundo, si la multiplicamos por ese tiempo, nos va a dar la cantidad que debe moverse en un fotograma 
	en concreto. Time.deltaTime tendrá el valor del tiempo en segundo (que será muy pequeño) que ha pasado del ultimo fotograma y el
	actual.
	*/
	void Update () {
		transform.Rotate (rotacion*Time.deltaTime);
	}
}
