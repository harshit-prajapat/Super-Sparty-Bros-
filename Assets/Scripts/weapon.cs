using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {

	public Transform firepoint;
	public GameObject projcetile;

	
	// Update is called once per frame
	void Update () 
	{
		if(arrow_anim.canshoot)
		{
			if ( Input.GetButtonDown("Fire1"))
			{
				Shoot();
			}
		}
		
	}

	void Shoot()
	{
		Instantiate(projcetile, firepoint.position, firepoint.rotation);
	}
}
