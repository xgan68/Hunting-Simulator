using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float m_speed = 10f;
	public float m_liveTime = 1;
	public int m_power = 5;

	protected Transform m_transform;


	// Use this for initialization
	void Start () {

		m_transform = this.transform;
		Destroy (this.gameObject, m_liveTime);

	}

	// Update is called once per frame
	void Update () {

		m_transform.Translate (new Vector3(0, 0, m_speed * Time.deltaTime));

	}

	void OnTriggerEnter (Collider other) {

		if(other.tag.CompareTo("Enemy")==0) {
			other.GetComponent<Mobs> ().mob.TakeDamage (m_power);

		}
	//
			
	//		//when the bullet hits an enemy, the bullet is disappeared
	//							
		}


}
