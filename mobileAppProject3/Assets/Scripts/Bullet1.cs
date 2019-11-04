using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour {
	public float speed = 15f;
	public Rigidbody2D RB;

	// Use this for initialization
	void Start () {
		RB.velocity = transform.right * speed;
	}

	void OnTriggerEnter2D(Collider2D hitInfo)
	{
		Debug.Log(hitInfo.name);
		Destroy(gameObject);
	}
}
