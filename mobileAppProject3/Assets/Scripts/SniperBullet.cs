using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperBullet : MonoBehaviour {

	public float speed = 50f;
	public int Damage = 100;
	public float range = 10f;
	public Rigidbody2D RB;

	// Use this for initialization
	void Start () {
		RB.velocity = transform.right * speed;
		Destroy(gameObject, range);
	}

	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		Enemy enemy = hitInfo.GetComponent<Enemy>();
		if(enemy != null)
		{
			enemy.GettingHit(Damage);
		} 
			Destroy(gameObject);
		//Debug.Log(hitInfo.name);
	
	}
}
