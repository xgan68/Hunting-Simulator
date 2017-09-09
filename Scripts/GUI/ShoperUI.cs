using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoperUI : MonoBehaviour {
	public delegate void OnShopper();
	public static event OnShopper OnSpeak;
	public static event OnShopper OnBye;

	[SerializeField]GameObject conversationUI;

	// Use this for initialization
	void Start () {
		conversationUI.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		

	public void Speak(){
		conversationUI.SetActive(true);
		Controller.disableWalk = true;

		if (OnSpeak != null)
			OnSpeak ();
	}

	public void Bye(){
		conversationUI.SetActive(false);
		Controller.disableWalk = false;

		if (OnBye != null)
			OnBye ();
	}

}
