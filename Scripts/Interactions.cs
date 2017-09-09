using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SetGazedAt (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetGazedAt(bool gazedAt){
		GetComponent<Renderer> ().material.color = gazedAt ? Color.red : Color.black;
	}

	public void OnGazeEnter(){
		SetGazedAt (true);
	}

	public void OnGazeExit(){
		SetGazedAt (false);
	}

	public void OnGazeTrigger(){
		MoveUp ();
	}

	public void MoveUp(){
		gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 10f, 0f);
		//transform.position += new Vector3 (0f, 1f, 0f);
	}
}
