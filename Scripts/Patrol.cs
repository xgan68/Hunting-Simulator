using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {

	float turnTime = 5;
	Vector3 walkingDir;
	// Use this for initialization
	void Start () {
		walkingDir = transform.forward;
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time >= turnTime) {
			Debug.Log (turnTime);
			transform.eulerAngles = transform.eulerAngles + 180f * Vector3.up;
			turnTime = Time.time + 5;
		}
		transform.Translate (walkingDir * Time.deltaTime);

	}





}
