using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour {

	// Update is called once per frame
	void Update () 
	{
	}

	void OnTriggerEnter2D(Collider2D obj)
	{
		if (obj.tag == "Player")
		{
			GameManager.gm.lives+=1;
			Destroy(gameObject);
		}
	}
}
