using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobs : MonoBehaviour {
	public Character mob;
	// Use this for initialization
	void Start () {
		mob = new Character (20, 2f, 5, 3); 
	}
	
	// Update is called once per frame
	void Update () {
		IsDead ();
	}

	void IsDead(){
		if (mob.CurrentHitpoint <= 0)
			Destroy (gameObject);
		
	}
}
