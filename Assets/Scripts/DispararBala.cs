using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararBala : MonoBehaviour {

	public GameObject bala;
	public Transform puntoDisparo;
	public float fireRate;
	private float nextFire;


	void FixedUpdate(){
		if (Input.GetButton("Fire1") && Time.time > nextFire) 
		{
			nextFire = Time.time + fireRate;
			Instantiate(bala, puntoDisparo.position, puntoDisparo.rotation);
			//GetComponent<AudioSource>().Play ();
		}
	}
}
