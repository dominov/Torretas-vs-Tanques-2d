using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazaerElegirObjetivo : MonoBehaviour {

    public CannonRotar cannonRotar;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Bola") && !cannonRotar.TieneObjetivo() )
        {

            cannonRotar.SetObjetivo( collision.transform);



        }


    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        cannonRotar.ReiniciarObjetivo();
    }
}
