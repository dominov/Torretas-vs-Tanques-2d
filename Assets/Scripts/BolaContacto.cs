using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaContacto : MonoBehaviour
{

    public GameObject explosion;
    
    public ControladorJuego controlador;

    public int vida = 10;
    public int nivelDanno=1;

    private void Awake()
    {
        GameObject ga = GameObject.FindWithTag("GameController");
        controlador = ga.GetComponent<ControladorJuego>();
    }

    void OnCollisionEnter2D(Collision2D  collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.CompareTag("Player"))
        {

            Instantiate(explosion, transform.position, Quaternion.identity);            
            collision.gameObject.GetComponent<JugadorMover>().BajarVida(nivelDanno);
            Destroy(gameObject);
            controlador.InstaciarAsteroide(UnityEngine.Random.Range(1, 4));
        }

    }

    public void BajarVida(int v)
    {
        
        vida = vida-v;
       
        if (vida == 0)
        {
            controlador.SubirPuntos(nivelDanno);
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
            controlador.InstaciarAsteroide(UnityEngine.Random.Range(1,4));
        }
    }
}
