using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cast : MonoBehaviour {

	GameObject bullet;

	// Use this for initialization
	void Start () {
		bullet = Resources.Load ("Prefabs/"+PlayerManager.player.Weapon) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnEnable(){
		MicInput.OnHeard += CastMagic;
	}

	void OnDisable(){
		MicInput.OnHeard -= CastMagic;
	}

	void CastMagic(){
		Instantiate (bullet, Camera.main.transform.position, Camera.main.transform.rotation);
	}
}
