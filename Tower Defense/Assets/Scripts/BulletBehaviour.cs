using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
	
	
	public bool Runner = false;
	
	// Use this for initialization
	public IEnumerator OnStart () {
		while (!Runner)
		{
			
			yield return new WaitForSeconds(2);
		}
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision other)
	{
		Runner = false;
	}
}
