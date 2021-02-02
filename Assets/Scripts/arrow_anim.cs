using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow_anim : MonoBehaviour 
{
	public static bool canshoot = false;
	void OnTriggerEnter2D(Collider2D obj)
	{
	//	Debug.Log("Trigger() working");
		if(obj.gameObject.tag == "Player")
		{
			canshoot = true;
			Destroy(gameObject);
		}
	}
}
