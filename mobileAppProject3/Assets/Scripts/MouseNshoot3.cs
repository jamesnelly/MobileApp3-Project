using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseNshoot3 : MonoBehaviour {
public GameObject crosshairs;
private Vector3 Target;
/// Shotgun variables////
public GameObject Sniper;
public GameObject SniperBullet;
public float SniperSpeed;
	// Use this for initialization
	void Start () {
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		Target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
		crosshairs.transform.position = new Vector2(Target.x, Target.y);
		
		Vector3 diff = Target - Sniper.transform.position;
		float angleZZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
		Sniper.transform.rotation = Quaternion.Euler(0, 0, angleZZ);

		if(Input.GetMouseButtonDown(0)){
			float distance = diff.magnitude;
			Vector2 direction = diff / distance;
			direction.Normalize();
			Snipershooting(direction, angleZZ);
	}
}
     void Snipershooting(Vector2 direction, float angleZZ)
    {
      GameObject Bullet2 = Instantiate(SniperBullet) as GameObject;
		Bullet2.transform.position = Sniper.transform.position;
		Bullet2.transform.rotation = Quaternion.Euler(0f, 0f, angleZZ);
		Bullet2.GetComponent<Rigidbody2D>().velocity = direction * SniperSpeed;
    }
}
