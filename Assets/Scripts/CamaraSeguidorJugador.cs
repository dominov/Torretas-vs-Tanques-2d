using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSeguidorJugador : MonoBehaviour {

    private Transform jugador;
    public float maxX, minX;

    private void Start()
    {
        jugador=  GameObject.FindWithTag("Player").transform;
    }
    private void FixedUpdate()
    {
      
        //if(jugador.position.x > minX && jugador.position.x < maxX)
        if (jugador != null)
            transform.position = new Vector3(jugador.position.x, jugador.position.z, transform.position.z);
    }
}
