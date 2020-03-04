using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // libreria para usar la interfaz grafica de usuario.Cuando escribamos el tipo text unity lo va  a reconocer

public class ControladorDelJugador : MonoBehaviour {
	// cuando queramos aplicarle una fuerza al Rigidbody simplemente lo llamamos usando la variable rb.	
	// importante agregar public para que aparezca en el inspector de unity.
	Rigidbody rb;
	public Text puntuacion; // luego de declararlo hay que asignar la referencia al objeto arrastrando el mismo
				//hacia la variable que aparece en la pestaña del inspector en jugador.
	public float velocidad;
	int contador;
	public Text ganar;

	/* 	void Update(){
	  Aqui iria el codigo que queremos que se ejecute en cada fotograma.
	}*/


	public void OnTriggerEnter(Collider other){
		// Metodo para las colisiones entre objetos, aqui es cuando el jugador colisiona con otro.
		// En el caso de los items en Inspector->BoxCollider-> isTrigger, si lo activamos el objeto no colisionara.
		Destroy(other.gameObject); // Destruimos el gameObject que colisiona con el jugador.
		// de esta forma destruimos el objeto que colisiona la pelota y esta marcado con Is Trigger

		// Las variables se actualizan cada vez que hay una colision 
		contador++;
		actualizarMarcador ();
		if (contador >= 6) {
			ganar.gameObject.SetActive (true);
		}
	}

	public void Awake(){
		// Aqui iria el codigo de inicializacion que usaremos para obtener 
		// referencias a otros componentes.

		// Cuando creamos objetos para que aparescan en nuestro mundo 3d y queremos que
		// se ejecuten, apareceran aqui.

		rb = GetComponent<Rigidbody>();
		// GetComponet<TipoDeComp>() sirve para obtener una referencia a otro 
		// componente del mismo objeto en el que esta colocado este script

		contador = 0;
		actualizarMarcador ();
		ganar.gameObject.SetActive (false);

	}

	private void actualizarMarcador(){
		puntuacion.text = "Puntuacion: " + contador;
	}

	public void FixedUpdate(){
		//Aqui iria el codigo que queremos que se ejecute en cada paso del 
		// motor de fisicas.
		
		float movimentoHorizontal = Input.GetAxis("Horizontal");
		float movimentoVertical = Input.GetAxis("Vertical");

		// creamos un vector que le pasaremos al rb.addForce con los movimientos
		// Vector3 pide 3 tipos de direcciones, pero solo queremos mover al jugador
		// adelante y atras, no hacia arriba y abajo, por ello el 2do parametro es cero, ademas el 
		// metodo AddForce requiere de un tipo Vector3
		Vector3 movimiento = new Vector3 (movimentoHorizontal,0,movimentoVertical);

		// aplicamos la fuerza al Rigidbody
		rb.AddForce(movimiento*velocidad);
	}




}
