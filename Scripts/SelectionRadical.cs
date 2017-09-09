using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionRadical : MonoBehaviour {
	public float fillTime = 2f;

	[SerializeField] private Image mySlider;
	private float timer;
	private Coroutine fillBarRoutine;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PointerEnter(){
		Debug.Log ("Enter");
		fillBarRoutine = StartCoroutine (FillBar());

	}

	public void PointerExit(){
		if (fillBarRoutine != null) {
			StopCoroutine (fillBarRoutine);
		}
		timer = 0f;
		mySlider.fillAmount = 0f;
	}

	public void OnBarFilled (){
		Debug.Log ("Yeahhhhhhh");
	}

	private IEnumerator FillBar(){
		timer = 0f;

		while (timer < fillTime) {
			timer += Time.deltaTime;

			mySlider.fillAmount = timer / fillTime;

			yield return null;
		}
		OnBarFilled ();
	}
}
