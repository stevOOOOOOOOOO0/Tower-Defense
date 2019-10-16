using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class BulletBehaviour : MonoBehaviour
{

	public UnityEvent TriggerEnterAction;
	public bool Runner;
	public Transform StartLocation;
	public float BulletSpeed;

	public void Start()
	{
		StartCoroutine(OnStart());
	}

	// Use this for initialization
	public IEnumerator OnStart ()
	{
		StartLocation = transform;
		while (Runner)
		{
			MoveForward();
			yield return new WaitForSeconds(0);
		}
		TriggerEnterAction.Invoke();
	}
	
	// Update is called once per frame
	private void OnTriggerEnter ()
	{
		//Runner = false;
	}

	public void MoveForward()
	{
		
		transform.position = Vector3.Lerp(StartLocation.position, StartLocation.forward * BulletSpeed, 1 * Time.deltaTime);
	}
}
