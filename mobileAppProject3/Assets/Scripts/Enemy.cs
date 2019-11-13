using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int Health = 100;
	public int ScoreValue = 100;

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
		ScoreManager.score += ScoreValue;
		Debug.Log("Score = " + ScoreValue);
		Destroy(gameObject);
	}
}
