using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArBullet : MonoBehaviour {

	public float speed = 15f;
	public int Damage = 15;
	public float range = 5f;
	public Rigidbody2D RB;

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
