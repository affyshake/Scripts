﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	public float speed = 1.0f;

	private new Rigidbody rigidbody;

	private GameManager manager;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody>();
		manager = GameObject.FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 newVelocity = Vector3.zero;

		newVelocity.x = Input.GetAxis("Horizontal") * speed;
		newVelocity.z = Input.GetAxis("Vertical") * speed;

		rigidbody.velocity = newVelocity;
	}

	public void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "Cube" || collision.gameObject.tag == "Follower"){
			manager.Reset();
		}
		else if(collision.gameObject.tag == "NextLevelCube"){
			
			int iScene = Application.loadedLevel;	

			if (iScene == 0) {
				Application.LoadLevel (1);
			}
			else if (iScene == 1) {
				Application.LoadLevel (2);
			}
			else if(iScene == 2) {
				Application.LoadLevel (0);
			}
		}
	}
}
