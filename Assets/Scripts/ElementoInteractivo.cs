using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ElementoInteractivo : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool pulsado;
    public void OnPointerUp(PointerEventData eventData)
    {
        pulsado = false;
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        pulsado = true;
    }
}
