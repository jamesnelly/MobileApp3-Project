using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet2 : MonoBehaviour {
    public float speed;
	public int damage;
	Rigidbody2D rb;
	PlayerLvl2 target;
	Vector2 direction;
    
		void Start () {
			rb = GetComponent<Rigidbody2D> ();
			target = GameObject.FindObjectOfType<PlayerLvl2>();
			direction = (target.transform.position - transform.position).normalized * speed;
			rb.velocity = new Vector2(direction.x, direction.y);
			Destroy(gameObject, 5f);
	}
	void OnTriggerEnter2D(Collider2D info)
	{
		PlayerLvl2 player = info.GetComponent<PlayerLvl2>();
		if(player != null){
			//Debug.Log("HIT!!!");
			player.GettingHit(damage);
			DestroyBullet();
		}
	}
	void DestroyBullet()
	{
		Destroy(gameObject);
	}
}
