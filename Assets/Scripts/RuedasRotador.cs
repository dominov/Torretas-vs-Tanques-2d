using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class RuedasRotador : MonoBehaviour {

    public float rotacionSpeed = 10.0f;
    private void FixedUpdate()
    {
        
		if (CrossPlatformInputManager.GetAxis("Horizontal") > 0) {
            transform.Rotate(Vector3.forward * -rotacionSpeed);
		}else if  (CrossPlatformInputManager.GetAxis("Horizontal") < 0)
        {
                transform.Rotate(Vector3.forward * rotacionSpeed);

        }

    }
}
