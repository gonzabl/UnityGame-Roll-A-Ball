﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeLaCamara : MonoBehaviour {

	// Usar Awake() para obtener referencias a las variables y usarlas en Start()
	// todos los objetos que aparecen en la pestaña herencia son de tipo GameObject
	public GameObject jugador;
	
	// Esta variable contendra la distancia de la camara a la pelota en cada una de las 3 coordenadas.
	private Vector3 posicionRelativa;

	// Use this for initialization 
	void Start () {
		//Start se ejecuta cuando el objeto se inicia y Awake siempre tanto si el objeto esta vacio o no.
		// la diferencia entre estos dos es que en Awake() se busca obtener referencias a los componentes y sus variables y 
		// en Start() inicializar esas variables
		
		// obtenemos la posicion relativa de la camara con respecto al jugador
		// restar la "x" de la pelota a la "x" de la camara, la "y" de una y otra y "z" de una y otra.
		// unity permite restar dos objetos de tipo vector, y se restaran los campos automaticamente.

		// queremos quitarle a la camara el valor de la pelota
		posicionRelativa = transform.position - jugador.transform.position;
		// esta es la posicion relativa de la camara con respecto al jugador
	}
	
	// Update() : is called once per frame
	// void LateUpdate(): igual que el Update() pero se ejecuta justo despues de todos los Updates.
	void LateUpdate () {
		transform.position = jugador.transform.position + posicionRelativa;
		// con esto en cada fotograma la camara estara movida. si no sumaramos la camara se pondria exactamente en el centro de la pelota.

	}


	// para finalizar debo arrastra desde la pestaña de herencia el objeto jugador para asignarlo a la variable jugador creada en este Script
}
