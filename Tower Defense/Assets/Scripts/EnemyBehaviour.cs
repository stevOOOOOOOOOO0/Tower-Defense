
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{

	public Transform finalDestination;
	public UnityEngine.AI.NavMeshAgent agent;
	public FloatData PlaySpeed;
	
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
		agent.SetDestination(finalDestination.position);
		agent.speed = 3;
		ChangeSpeed();
	}

	public void ChangeSpeed()
	{
		Time.timeScale = PlaySpeed.Value;
	}
}
