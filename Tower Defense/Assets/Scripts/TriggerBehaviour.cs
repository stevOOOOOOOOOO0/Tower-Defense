using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerBehaviour : MonoBehaviour
{

	public UnityEvent<Collider> EventWithCollider;
	
	public UnityEvent TriggerEvent;
	private void OnTriggerStay(Collider other)
	{
		EventWithCollider.Invoke(other);
	}
}
