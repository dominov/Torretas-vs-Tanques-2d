using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class CannonRotar : MonoBehaviour {

    

    public float rotacionSpeed = 90.0f;
    public Transform puntoRotacion;
    private void Update()
    {
       
		//rotacionSpeed += CrossPlatformInputManager.GetAxis("Horizontal2");
		transform.eulerAngles = new Vector3(0, 0, CrossPlatformInputManager.GetAxis("Horizontal2")*-rotacionSpeed);

	
      //  Vector3 targetdir = transform.forward;
       

		/*
            if (CrossPlatformInputManager.GetAxis("Horizontal2") != 0 )
        {
            float rotationX = CrossPlatformInputManager.GetAxis("Horizontal2") * -rotacionSpeed;
            transform.RotateAround(puntoRotacion.position, Vector3.forward, rotationX);
        }
        else {
           // transform.rotation = Quaternion.identity;
        }*/

        
    }
}
