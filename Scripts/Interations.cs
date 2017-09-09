using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interations : MonoBehaviour {

	void Start(){
		SetGazedAt (false);
	}

	public void SetGazedAt(bool gazedAt){
		GetComponent<Renderer> ().material.color = gazedAt ? Color.red : Color.black;
	}

	public void OnOver(){
		Debug.Log ("Enter");
		SetGazedAt (true);
	}

	public void OnOut(){
		SetGazedAt (false);
	}

	public void OnClick(){
		MoveUp ();
	}

	public void MoveUp(){
		gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 10f, 0f);
		//transform.position += new Vector3 (0f, 1f, 0f);
	}
}
