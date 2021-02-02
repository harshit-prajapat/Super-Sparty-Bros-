using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {

	// Use this for initialization
	public float speed = 10.0f;
	public Rigidbody2D rb;

	void Start () 
	{
		rb.velocity = transform.right*speed;
	}

	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		CharacterController2D cc = hitInfo.GetComponent<CharacterController2D>();
		Debug.Log(hitInfo.tag);

		Enemy enemy = hitInfo.GetComponent<Enemy>();
		if ( enemy!=null)
		{
			enemy.Stunned();
		}

		else if(cc!=null)
		{
			cc.FallDeath();
		}

		Destroy(gameObject);
	}
}
