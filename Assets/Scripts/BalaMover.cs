using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaMover : MonoBehaviour {

    private Rigidbody2D rig;

    public float velocidad = 10.0f;
     void Awake()
    {
        rig = GetComponent<Rigidbody2D>();    
    }
    void Start()
    {
        
        rig.velocity = transform.up * velocidad;
    }

}
