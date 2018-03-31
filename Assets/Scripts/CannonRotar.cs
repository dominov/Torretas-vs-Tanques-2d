using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class CannonRotar : MonoBehaviour {

    

    public float rotacionSpeed = 30.0f;
    public Transform puntoRotacion;
    private void FixedUpdate()
    {
       

        Vector3 targetdir = transform.forward;
       


            if (CrossPlatformInputManager.GetAxis("Horizontal") != 0 )
        {
            float rotationX = CrossPlatformInputManager.GetAxis("Horizontal") * -rotacionSpeed;
            transform.RotateAround(puntoRotacion.position, Vector3.forward, rotationX);
        }
        else {
           // transform.rotation = Quaternion.identity;
        }

        
    }
}
