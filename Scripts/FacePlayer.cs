using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour {

	bool enableLookAt;
	// Use this for initialization
	void Start () {
		enableLookAt = false;
		ShoperUI.OnSpeak += startLookAt;
		ShoperUI.OnBye += stopLookAt;
	}
	
	// Update is called once per frame
	void Update () {
		if(enableLookAt)
			transform.LookAt (Controller.player.transform.position);
	}



	void startLookAt(){
		enableLookAt = true;
	}
	void stopLookAt(){
		enableLookAt = false;
	}
}
