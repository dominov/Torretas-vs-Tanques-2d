using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

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

    public Rigidbody2D rb;

    public int impulso = 3;

    private void Awake()
    {
        textoVida = GameObject.FindWithTag("text_salud").GetComponent<Text>();
        GameObject ga = GameObject.FindWithTag("GameController");
        controlador = ga.GetComponent<ControladorJuego>();

        
            rb = GetComponent<Rigidbody2D>();
        
    }

    private void Start()
    {
        ActualizarTextoSalud();
    }
    void FixedUpdate(){



        if (CrossPlatformInputManager.GetButton("izquierda"))
        {
            float posX = Mathf.Clamp(transform.position.x + (-impulso * velocidaMovimiento * Time.deltaTime), minX, maxY);
            transform.position = new Vector3(posX, transform.position.y, transform.position.z);
        }

        else if (CrossPlatformInputManager.GetButton("derecha"))
        {
            float posX = Mathf.Clamp(transform.position.x + (impulso * velocidaMovimiento * Time.deltaTime), minX, maxY);
            transform.position = new Vector3(posX, transform.position.y, transform.position.z);
        }
        else
        {
            float direccion = CrossPlatformInputManager.GetAxis("Horizontal");  //Izq.pulsado ? -1 : (der.pulsado ? 1 : 0);

            float posX = Mathf.Clamp(transform.position.x + (direccion * velocidaMovimiento * Time.deltaTime), minX, maxY);
            transform.position = new Vector3(posX, transform.position.y, transform.position.z);

        }
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
