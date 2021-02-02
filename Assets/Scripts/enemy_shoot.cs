using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_shoot : MonoBehaviour {

	
	public Transform firepoint;
	public GameObject projcetile;
	public float speed = 10.0f;
	public float WaitTime = 1.0f;
	// Update is called once per frame
	void Start() 
	{
		StartCoroutine(fire());
	}

	IEnumerator fire()
	{
		while (true)
		{
			if (this.GetComponent<Enemy>().isStunned == false)
			{
				Instantiate(projcetile, firepoint.position, firepoint.rotation);
				projcetile.GetComponent<Rigidbody2D>().velocity = transform.right*speed;
				yield return new WaitForSeconds(WaitTime);
			}	
		}
	}
}
