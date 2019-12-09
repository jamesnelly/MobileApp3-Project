using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunBullet : MonoBehaviour {
	public float speed = 15f;
	public int Damage = 20;
	public float range = 10;
	public Rigidbody2D RB;

	// Use this for initialization
	void Start () {
		RB.velocity = transform.right * speed;
		Destroy(gameObject, range);
	}

	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
		if(enemy != null)
		{
			enemy.GettingHit(Damage);
		} 
			Destroy(gameObject);
		//Debug.Log(hitInfo.name);
	
	}
}
