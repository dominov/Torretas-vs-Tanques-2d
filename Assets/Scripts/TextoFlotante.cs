using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TextoFlotante : MonoBehaviour {

	public Animator animador;
	private Text damageText;
	// Use this for initialization
	void OnEnable () {
		AnimatorClipInfo[] clipInfo = animador.GetCurrentAnimatorClipInfo(0);
		Destroy(gameObject, clipInfo[0].clip.length);
		damageText = animador.GetComponent<Text>();
	}


	public void SetText(string texto){
		damageText.text = texto;
	}

}
