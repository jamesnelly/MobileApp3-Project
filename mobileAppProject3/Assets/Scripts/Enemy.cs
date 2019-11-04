using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int Health = 100;
	public GameObject death;
	// Use this for initialization
	
	public void GettingHit(int Damage)
	{
		Health -= Damage;
		if(Health <= 0)
		{
			Killed();
		}
	}

	void Killed()
	{
		Instantiate (death, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
}
