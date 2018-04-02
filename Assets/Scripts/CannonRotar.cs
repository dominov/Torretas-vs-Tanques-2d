using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class CannonRotar : MonoBehaviour {

    public GameObject puntoMira;


    private Transform objetivo=null;

   
    public void SetObjetivo(Transform obj)
    {
        objetivo = obj;
    }

    public void ReiniciarObjetivo()
    {
        objetivo = null;
    }

    public bool TieneObjetivo()
    {
        return (objetivo != null);
    }
    private void Update()
    {
        Vector2 p1, p2;


        if (objetivo != null)
        {
           
                
             p1 = new Vector2(transform.position.x, transform.position.y);
             p2 = new Vector2(objetivo.transform.position.x, objetivo.transform.position.y);
               
        }
        else
        {
			if (CrossPlatformInputManager.GetAxis ("Horizontal2")!=0 || CrossPlatformInputManager.GetAxis ("Vertical2")!=0) {
				p1 = new Vector2 (0, 0);
				p2 = new Vector2 (CrossPlatformInputManager.GetAxis ("Horizontal2"), CrossPlatformInputManager.GetAxis ("Vertical2"));
			} else {
				p1  = new Vector2 (0, 0);
				p2 = new Vector2 (0, 1);
			}

        }
        
        float angle = Mathf.Atan2(p2.y - p1.y, p2.x - p1.x) * 180 / Mathf.PI;
	
        angle = Mathf.Clamp(Mathf.Abs(angle), 0, 180);
        transform.eulerAngles = new Vector3(0, 0, angle);

       
    }
    private void FixedUpdate()
    {
        if (objetivo != null && puntoMira != null)
        {
            //puntoMira.SetActive(true);
            puntoMira.transform.position = objetivo.transform.position;

        }
    }

}
