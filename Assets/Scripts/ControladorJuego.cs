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
    public int Numerobolas = 2;
    private Image imgPausa;

    private bool gameover, restar;
    private ElementoInteractivo btn_resert;

    public float tiempoAparicionBola = 5;

    // Use this for initialization

    private void Awake()
    {
        textoPuntos = GameObject.FindWithTag("text_puntos").GetComponent<Text>();
        textoGameOver = GameObject.FindWithTag("text_game_over").GetComponent<Text>();
     
        imgPausa = GameObject.FindWithTag("imagenPausa").GetComponent<Image>();
        btn_resert = GameObject.FindWithTag("btn_reset").GetComponent<ElementoInteractivo>();
    }
    void Start() {
        gameover = restar = false;

        textoGameOver.gameObject.SetActive(false);
        btn_resert.gameObject.SetActive(false);
        imgPausa.gameObject.SetActive(false);
        StartCoroutine(InstaciarAsteroide());
       
         ActualizarTextoPuntos();
    }

    // Update is called once per frame
    void Update() {
        if (restar && (Input.GetKeyDown(KeyCode.R) || btn_resert.pulsado)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        } ;
    }

    IEnumerator InstaciarAsteroide(){
        while (true){ 

        for (int i = 0; i < Numerobolas; i++)
        {
            Vector3 posicionAparcion = new Vector3(Random.Range(-aparecerLimiteX.x, aparecerLimiteX.x), aparecerLimiteX.y, aparecerLimiteX.z);
            Instantiate(enemigo, posicionAparcion, Quaternion.Euler(0,0,255));
        }
        yield return new WaitForSeconds(tiempoAparicionBola);
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
        btn_resert.gameObject.SetActive(true);
        imgPausa.gameObject.SetActive(true);
        gameover = restar = true;
        
    }
}
