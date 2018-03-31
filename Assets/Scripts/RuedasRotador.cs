using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuedasRotador : MonoBehaviour {

    public float rotacionSpeed = 10.0f;
    private void FixedUpdate()
    {
        
        if (Input.GetAxis("Horizontal") > 0) {
            transform.Rotate(Vector3.forward * -rotacionSpeed);
        }else if  (Input.GetAxis("Horizontal") < 0)
        {
                transform.Rotate(Vector3.forward * rotacionSpeed);

        }

    }
}
