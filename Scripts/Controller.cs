using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	public static GameObject player;
	public static bool disableWalk = false;

	private bool walking = false;

	private Vector3 spawnPoint;
	// Use this for initialization
	void Start () {
		player = this.gameObject;
	}

	// Update is called once per frame
	void Update () {

		Vector3 walkingDir = Camera.main.transform.forward;
		walkingDir.y = 0;
		if (Input.GetMouseButtonDown (0)) {
			walking = true;
		}
		if (Input.GetMouseButtonUp (0)) {
			walking = false;
		}

		if (walking&&!disableWalk)
			transform.position = transform.position + walkingDir * 3f * Time.deltaTime;

	}

}
