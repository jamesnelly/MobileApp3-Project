using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed;
	public float lifetime;

	private void Start(){

	}

	private void Update()
	{
		transform.Translate(transform.up * speed * Time.deltaTime);
	}
}
