using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int Health = 100;

	[SerializeField]
	public GameObject EnemyBullet;
	private Transform player;
	private float TimeBtwShots;
	public float StartTimeBtwShots;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player").transform;
		TimeBtwShots = StartTimeBtwShots;
	}

	void Update(){
		if(TimeBtwShots <= 0)
		{
			Instantiate(EnemyBullet, transform.position, Quaternion.identity);
			TimeBtwShots = StartTimeBtwShots;
		} else {
			TimeBtwShots -= Time.deltaTime;
		}
	}
	
/*
	//float FireRate;
	//float NextShot;
	void start()
	{
		FireRate = 140f;
		NextShot = Time.time;
	}

	void Update()
	{
		CheckTimingFire();
	}
	void CheckTimingFire(){
		if(Time.time > NextShot){
			Instantiate(EnemyBullet, transform.position, Quaternion.identity);
			NextShot = Time.time + FireRate;
		}
	}
	*/
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
		//Instantiate (death.gameObject, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
}
