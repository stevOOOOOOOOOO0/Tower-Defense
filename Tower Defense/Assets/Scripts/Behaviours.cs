using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Behaviours : MonoBehaviour
{

	public float Smooth = 1f;
	public List<Vector3> Targets;
	private Rigidbody Character;

	public void Start()
	{
		Character = GetComponent<Rigidbody>();
	}
	
	public void FaceTowards(Vector3 Target)
	{
		Character.MoveRotation(Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(Target), Smooth));
	}

	private void OnTriggerEnter(Collider other)
	{
		Targets.Add(other.transform.position);
	}
	
	private void OnTriggerStay(Collider other)
	{
		FaceTowards(Targets[0]);
	}

	private void OnTriggerExit(Collider other)
	{
		Targets.Remove(other.transform.position);
	}
}
