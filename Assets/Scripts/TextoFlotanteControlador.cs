using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoFlotanteControlador : MonoBehaviour {
	private static TextoFlotante textoFlotante;
	private static GameObject canvas;

	public static void Initialize(){
		canvas = GameObject.Find ("canvasTextos");
       
		if (textoFlotante==null) {
			textoFlotante = Resources.Load<TextoFlotante>("Efectotextos/PopupTextParent");
          
		}
	}
	public static void CrearTextoFlotante(string texto, Transform posicion ){
		
		TextoFlotante instancia = Instantiate(textoFlotante);
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(new Vector2(posicion.position.x + Random.Range(-.2f, .2f), posicion.position.y + Random.Range(-.2f, .2f)));

		instancia.transform.SetParent(canvas.transform, false);
		instancia.transform.position = screenPosition;
		instancia.SetText(texto);


	}
}
