using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class JugadorMover : MonoBehaviour {

	
    [Header("Vida")]
    public int salud = 3;
    public GameObject explosion;

    private  Text textoVida;

    [Header("Movimiento")]
	public float velocidaMovimiento = 10.0f;
	public bool mirandoDerecha = true;
    public Transform cuerpo;
    public float minX;
    public float maxY;


    private  ControladorJuego controlador;

    private ElementoInteractivo der, Izq;
    private void Awake()
    {
        textoVida = GameObject.FindWithTag("text_salud").GetComponent<Text>();
        GameObject ga = GameObject.FindWithTag("GameController");
        controlador = ga.GetComponent<ControladorJuego>();


        der = GameObject.FindWithTag("Flecha_derecha").GetComponent<ElementoInteractivo>();
        Izq = GameObject.FindWithTag("Flecha_izquierda").GetComponent<ElementoInteractivo>();
    }

    private void Start()
    {
        ActualizarTextoSalud();
    }
    void FixedUpdate(){



        //float direccion = Izq.pulsado ? -1 : (der.pulsado ? 1 : Input.GetAxisRaw("Horizontal"));
        float direccion = Izq.pulsado ? -1 : (der.pulsado ? 1 : 0);
        float posX = Mathf.Clamp( transform.position.x + (direccion * velocidaMovimiento * Time.deltaTime),minX,maxY);
        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
		
      
    }

	void Voltear(){
		mirandoDerecha = !mirandoDerecha;
		transform.Rotate (Vector3.up * 180);
	}


    public void BajarVida(int v)
    {

        salud = salud - v;
        ActualizarTextoSalud();
        if (salud == 0)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            controlador.GAMEOVER();
            Destroy(gameObject);
        }
    }


    private void ActualizarTextoSalud()
    {
        textoVida.text = "SALUD: " + salud;

    }
}
