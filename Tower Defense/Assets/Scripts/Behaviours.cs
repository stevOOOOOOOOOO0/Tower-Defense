using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class Behaviours : MonoBehaviour
{

	public float WaitTime;
	public bool Runner = false;
	public List<Transform> Targets;
	public GameObject newObject;
	//public Quaternion lookDirection;

	private void OnTriggerEnter(Collider other)
	{
		Targets.Add(other.transform);
	}

	public void RemoveTarget()
	{
		Targets.Remove(Targets[0]);
		if (Targets.Count == 0)
		{
			Runner = false;
		}
	}

	public void RunCoroutines()
	{
		if (!Runner)
		{
			Runner = true;
			StartCoroutine(FaceTowards());
			//StartCoroutine(BulletCreation());
		}
	}

	public void StopCoroutine()
	{
		Runner = false;
	}
	
	public IEnumerator BulletCreation ()
	{
		Debug.Log("starting the bullet Coroutine");
		while (Runner)
		{
			Instantiate(newObject);
			yield return new WaitForSeconds(WaitTime);
		}
	}
	
	public IEnumerator FaceTowards() {
		yield return new WaitForSeconds(.1f);
		while (Runner)
		{
			transform.LookAt(Targets[0], Vector3.up);
			yield return new WaitForSeconds(0);
		}
	}
}