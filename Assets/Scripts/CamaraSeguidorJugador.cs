using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSeguidorJugador : MonoBehaviour {

    private Transform jugador;
    public float maxX, minX, smooth=1.125f;
    public Vector3 offset;

    private void Start()
    {
        jugador=  GameObject.FindWithTag("Player").transform;
    }
    private void LateUpdate()
    {

        //if(jugador.position.x > minX && jugador.position.x < maxX)
        if (jugador != null)
        {
            Vector3 desiredPosition = jugador.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smooth*Time.deltaTime);
            transform.position = smoothedPosition;
        }
    
    }
}
