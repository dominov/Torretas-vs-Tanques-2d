using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverTanque : MonoBehaviour {

	private Rigidbody2D rigi;
	public float velocidaMovimiento = 10.0f;
	public bool mirandoDerecha = true;
	void Awake(){
		rigi = GetComponent<Rigidbody2D> ();
	}
	void FixedUpdate(){

		float movimiento = Input.GetAxis ("Horizontal");

		if (movimiento != 0) {
			rigi.velocity = new Vector3 (movimiento * velocidaMovimiento, rigi.velocity.y);
			if ((movimiento < 0 && mirandoDerecha)|| (movimiento > 0 && !mirandoDerecha) ){
				voltear ();
			}
		}
	}

	void voltear(){
		mirandoDerecha = !mirandoDerecha;
		transform.Rotate (Vector3.up * 180);
	}
}
