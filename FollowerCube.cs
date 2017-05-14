using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowerCube : MonoBehaviour {

//	public float speed = 1.0f;

	private Rigidbody target;
//	private new Rigidbody rigidbody;

	private NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		
		target = GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody>();

//		rigidbody = GetComponent<Rigidbody>();

		agent = GetComponent<NavMeshAgent> ();

		agent.speed = 2.0f;

	}

	void Update(){
		
		if(target == null){
			GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody>();
		}

		agent.SetDestination (target.transform.position);

//		Vector3 newVelocity = (target.position - transform.position).normalized * speed;
//
//		rigidbody.velocity = newVelocity;

	}
}
