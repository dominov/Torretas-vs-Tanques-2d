using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPorTiempo : MonoBehaviour {

    public float tiempoVida =2;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, tiempoVida);	
	}
	
	
}
