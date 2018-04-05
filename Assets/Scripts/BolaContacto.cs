using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BolaContacto : MonoBehaviour
{

    public GameObject explosion;    
    private ControladorJuego controlador;

    public int vida = 10;
    public int nivelDanno=1;

	private int vidaInicial;

	public SpriteRenderer spriteRenderer;




	public Sprite img1,img2,img3,img4;
    private void Awake()
    {
        GameObject ga = GameObject.FindWithTag("GameController");
        controlador = ga.GetComponent<ControladorJuego>();
		vidaInicial = vida;

    }

    void OnCollisionEnter2D(Collision2D  collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.CompareTag("Player"))
        {

            Instantiate(explosion, transform.position, Quaternion.identity);            
            collision.gameObject.GetComponent<JugadorMover>().BajarVida(nivelDanno);
            Destroy(gameObject);
			controlador.EfectoDanno();
           // controlador.InstaciarAsteroide(UnityEngine.Random.Range(1, 4));
        }

    }

    public void BajarVida(int v)
    {
        vida = vida-v;

		if (vida == 1) {
			spriteRenderer.sprite = img4;
		} else if(vida==2)  {
			spriteRenderer.sprite = img3;
		} else if(vida==3)  {
			spriteRenderer.sprite = img2;
		} else if(vida==4)  {
			spriteRenderer.sprite = img1;
		}

        if (vida == 0)
        {
			controlador.SubirPuntos(vidaInicial*nivelDanno);
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
			TextoFlotanteControlador.CrearTextoFlotante ("+"+vidaInicial.ToString(), transform);
           // controlador.InstaciarAsteroide(UnityEngine.Random.Range(1,4));
        }
    }
}
