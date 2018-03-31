using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaDisparar : MonoBehaviour {

	public GameObject bala;
	public Transform puntoDisparo;
	public float fireRate;
	private float nextFire;


	void Update(){
        if (/*Input.GetButton("Fire1") &&*/ Time.time > nextFire) 
       
        //if (Input.GetAxis("Vertical") != 0 && Time.time > nextFire)// dispara si se esta moviendo
        
            {
			nextFire = Time.time + fireRate;
			Instantiate(bala, puntoDisparo.position, puntoDisparo.rotation);
			//GetComponent<AudioSource>().Play ();
		}
	}
}
