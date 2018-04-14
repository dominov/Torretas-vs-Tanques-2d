using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BolaContacto : MonoBehaviour
{

    public GameObject explosion, explosionConBala;    
    private ControladorJuego controlador;

    public int vida = 10;
    public int nivelDanno=1;

	private int vidaInicial;

	public SpriteRenderer spriteRenderer;




	public Sprite[] img;
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

	public void BajarVida(int v, Transform bala)
    {
        vida = vida-v;
		/*int x = (100 * vida) / vidaInicial;
		Debug.Log (x);
		if (x<=25) {
			spriteRenderer.sprite = img[3];
		} else if(x<=50)  {
			spriteRenderer.sprite = img[2];
		} else if(x<=75)  {
			spriteRenderer.sprite = img[1];
		} */

        if (vida == 0)
        {
			controlador.SubirPuntos(vidaInicial*nivelDanno);
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
			TextoFlotanteControlador.CrearTextoFlotante ("+"+vidaInicial.ToString(), transform);
           // controlador.InstaciarAsteroide(UnityEngine.Random.Range(1,4));
		}else{
			Instantiate(explosionConBala, bala.position, Quaternion.identity);     
		}
    }
}
