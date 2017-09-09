using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class RandomPatrol : MonoBehaviour {

	public Transform[] points;
	private int destPoint = 0;
	private NavMeshAgent agent;

	Animator animator;
	void Start () {

		animator = GetComponent<Animator> ();
		if(animator==null)
			animator = transform.GetChild(0).GetComponent<Animator> ();

		agent = GetComponent<NavMeshAgent>();

		agent.autoBraking = false;

		GotoNextPoint();
	}


	void GotoNextPoint() {
		// Returns if no points have been set up
		if (points.Length == 0)
			return;

		// Set the agent to go to the currently selected destination.
		agent.destination = points[destPoint].position;

		// Choose the next point in the array as the destination,
		// cycling to the start if necessary.
		//destPoint = (destPoint + 1) % points.Length;
		destPoint = Random.Range(0, points.Length);
		Debug.Log (destPoint);
	}

	float nextMoveTime = 0;
	float idleLength = 5;
	void Update () {
		// Choose the next destination point when the agent gets
		// close to the current one.
		if (agent.remainingDistance < 0.5f) {
			
			animator.SetInteger ("state",0);
			if (!agent.isStopped) {
				agent.isStopped = true;
				nextMoveTime = Time.time + Random.Range(2,8);
			}
			if (Time.time >= nextMoveTime) {
				animator.SetInteger ("state",1);
				GotoNextPoint ();
				agent.isStopped = false;
			}
		}
	}
}