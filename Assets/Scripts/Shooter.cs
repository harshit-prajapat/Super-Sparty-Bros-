using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	// Reference to projectile prefab to shoot
	public Transform firepoint;
	public GameObject projectile;
	public float power = 10.0f;
	
	// Update is called once per frame
	void Update () {
		// Detect if fire button is pressed
		if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2"))
		{
			shoot();
		}
	}

	void shoot()
	{
		//Instantiante(projectile, firepoint.position, firepoint.rotation);
	}	
			
}	
			
			
			
			
			/*
				
			// if projectile is specified
			if (projectile)
			{
				// Instantiante projectile at the camera + 1 meter forward with camera rotation
				GameObject newProjectile = Instantiate(projectile, transform.position + transform.forward, transform.rotation) as GameObject;

				// if the projectile does not have a rigidbody component, add one
				if (!newProjectile.GetComponent<Rigidbody2D>()) 
				{
					newProjectile.AddComponent<Rigidbody2D>();
				}
				// Apply force to the newProjectile's Rigidbody component if it has one
				newProjectile.GetComponent<Rigidbody2D>().AddForce(transform.right*power);
				//newProjectile.GetComponent<Rigidbody2D>().velocity = transform.right*power;
				
				void OnTriggerEnter2D (Collider2D hitInfo)
				{
					//checking if bullet hit an enemy via Enemy Object
					Enemy enemy  = hitInfo.GetComponent<Enemy>();
					if (enemy != null)
					{
						enemy. // spawn enemy stun animation 
					}
					//destroy the bullet object 
					Destroy(gameObject);
				}
				*/