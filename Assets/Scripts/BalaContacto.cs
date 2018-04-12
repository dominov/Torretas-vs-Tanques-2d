using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaContacto : MonoBehaviour {

    public Transform bala;
    public float colissionRadius = 0.4f;
    public bool colided = false;
    public LayerMask WhatToColideWith;
    public GameObject explosion;
    void OnTriggerEnter2D(Collider2D collision)
    
    {

       
        if (collision.CompareTag("Bola"))
        {
			collision.gameObject.GetComponent<BolaContacto>().BajarVida(1, transform);
          
        }


        if (!collision.CompareTag("lazer_apuntar"))
        {
			Debug.Log(explosion);
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }



}
