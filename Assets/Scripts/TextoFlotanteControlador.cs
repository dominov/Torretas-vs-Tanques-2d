using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoFlotanteControlador : MonoBehaviour {
	private static TextoFlotante textoFlotante;
	private static GameObject canvas;

	public static void Initialize(){
		canvas = GameObject.Find ("canvas");
		if (!textoFlotante) {
			textoFlotante = Resources.Load<TextoFlotante>("Prefabs/Efectotextos/TextoPuntaje");
		}
	}
	public static void CrearTextoFlotante(string texto, Transform posicion ){
		TextoFlotante instancia = Instantiate (textoFlotante);
		instancia.transform.SetParent (canvas.transform, false);
		instancia.SetText (texto);
	}
}
