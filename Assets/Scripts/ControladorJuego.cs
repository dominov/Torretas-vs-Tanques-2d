using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControladorJuego : MonoBehaviour {

    public GameObject enemigo;
    public Vector3 aparecerLimiteX;
    private int puntos =0;
    private Text textoPuntos;
    public Text textoGameOver;
    public Text textoReset;
    private Image imgPausa;

    private bool gameover, restar;

    // Use this for initialization

    private void Awake()
    {
        textoPuntos = GameObject.FindWithTag("text_puntos").GetComponent<Text>();
        textoGameOver = GameObject.FindWithTag("text_game_over").GetComponent<Text>();
        textoReset = GameObject.FindWithTag("text_reset").GetComponent<Text>();
        imgPausa = GameObject.FindWithTag("imagenPausa").GetComponent<Image>();

    }
    void Start() {
        gameover = restar = false;

        textoGameOver.gameObject.SetActive(false);
        textoReset.gameObject.SetActive(false);
        imgPausa.gameObject.SetActive(false);
        InstaciarAsteroide(1);
       
        ActualizarTextoPuntos();
    }

    // Update is called once per frame
    void Update() {
        if (restar && Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        } ;
    }

    public void InstaciarAsteroide(int numero){
        
        for (int i = 0; i < numero; i++)
        {
            Vector3 posicionAparcion = new Vector3(Random.Range(-aparecerLimiteX.x, aparecerLimiteX.x), aparecerLimiteX.y, aparecerLimiteX.z);
            Instantiate(enemigo, posicionAparcion, Quaternion.Euler(0,0,255));
        }
    }

    public void SubirPuntos(int numero)
    {
        puntos = puntos + numero;
        ActualizarTextoPuntos();
    }
    private void ActualizarTextoPuntos() {
        textoPuntos.text = "PUNTOS: " + puntos;

    }


    public void GAMEOVER()
    {
        textoGameOver.gameObject.SetActive(true);
        textoReset.gameObject.SetActive(true);
        imgPausa.gameObject.SetActive(true);
        gameover = restar = true;
        
    }
}
