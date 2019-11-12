using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

	public float speed;

	Rigidbody2D rb;
	Player target;
	Vector2 direction;


		void Start () {
			rb = GetComponent<Rigidbody2D> ();
			target = GameObject.FindObjectOfType<Player>();
			direction = (target.transform.position - transform.position).normalized * speed;
			rb.velocity = new Vector2(direction.x, direction.y);
			Destroy(gameObject, 5f);
	}
	void OnTriggerEnter2D(Collider2D info)
	{
		if(info.gameObject.name.Equals ("Player")){
			Debug.Log("HIT!!!");
			DestroyBullet();
		}
	}
	void DestroyBullet()
	{
		Destroy(gameObject);
	}
}
