using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerBehaviour : MonoBehaviour
{
	
	public List<Transform> Targets;
	
	public UnityEvent StayAction, TriggerEnterAction, TriggerExitAction;
	
	private void OnTriggerEnter()
	{
		TriggerEnterAction.Invoke();
	}
	
	private void OnTriggerStay()
	{
		StayAction.Invoke();
	}
	
	private void OnTriggerExit()
	{
		TriggerExitAction.Invoke();
	}
	
	public void AddTarget(Collider other)
	{
		Targets.Add(other.transform);
	}
}
