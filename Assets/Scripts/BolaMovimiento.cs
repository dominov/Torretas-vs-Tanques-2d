using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaMovimiento : MonoBehaviour {

    public float velocidadGiro = 10.0f, velocidadMovimiento = 300.0f;
    private Rigidbody2D rig;

     void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

     void Start()
    {
        ///rig.AddForce(new Vector2(velocidadMovimiento, velocidadMovimiento));
        rig.velocity = transform.up * velocidadMovimiento;
        rig.AddTorque(velocidadGiro);
    }
}
