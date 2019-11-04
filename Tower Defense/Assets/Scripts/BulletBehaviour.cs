using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class BulletBehaviour : MonoBehaviour
{

	public UnityEvent TriggerEnterAction;
	public bool Runner;
	public float BulletSpeed;

	public void Start()
	{
		StartCoroutine(OnStart());
	}

	// Use this for initialization
	public IEnumerator OnStart ()
	{
		while (Runner)
		{
			MoveForward();
			yield return new WaitForSeconds(0);
		}
	}
	
	// Update is called once per frame
	private void OnTriggerEnter (Collider other)
	{
		Runner = false;
	}

	public void MoveForward()
	{
		transform.position = Vector3.Lerp(transform.position, transform.forward * BulletSpeed, 1 * Time.deltaTime);
	}
}
