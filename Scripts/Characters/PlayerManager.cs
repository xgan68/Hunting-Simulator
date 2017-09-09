using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	public static Character player;

	// Use this for initialization
	void Start () {
		player = new Character (100, 3f, 0, 0, 20, "Bullet");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
