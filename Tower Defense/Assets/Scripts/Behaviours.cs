using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class Behaviours : MonoBehaviour
{

	public float WaitTime;
	public bool Runner = true;
	public float Smooth = 1f;
	public List<Transform> Targets;
	private Rigidbody Character;
	public UnityEvent StayAction, TriggerEnterAction, TriggerExitAction;
	public GameObject newObject;

	public void Start()
	{
		Character = GetComponent<Rigidbody>();
	}
	
	public void FaceTowards(Transform Target)
	{
		Character.MoveRotation(Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(Target.position), Smooth));
	}

	private void OnTriggerEnter(Collider other)
	{
		Targets.Add(other.transform);
		TriggerEnterAction.Invoke();
	}
	
	/*private void OnTriggerStay(Collider other)
	{
		FaceTowards(Targets[0]);
		StayAction.Invoke();
	}*/

	private void OnTriggerExit(Collider other)
	{
		Targets.Remove(other.transform);
		TriggerExitAction.Invoke();
	}

	public void RunCoroutine()
	{
		StartCoroutine(BulletCreation());
	}

	public void StopCoroutine()
	{
		Runner = false;
	}
	
	public IEnumerator BulletCreation () {
		while (Runner)
		{
			Instantiate(newObject);
			yield return new WaitForSeconds(WaitTime);
		}
	}
}