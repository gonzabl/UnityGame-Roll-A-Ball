using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giro : MonoBehaviour {
	// inicializamos valores en los cuales queremos que rote. Es decir cuanto girara en x, y , z.

	Vector3 rotacion = new Vector3(15,30,45);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (rotacion*Time.deltaTime);
	}
}
