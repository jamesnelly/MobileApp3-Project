using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArShoot : MonoBehaviour {
	//mouse Position
public GameObject crosshairs;
private Vector3 Target;
/// Shotgun variables////
public GameObject Ar;
public GameObject ARBullet;
public Transform FirePoint;
public Camera cam;

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
	}
	// Update is called once per frame
	void Update () {
		Target = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
		crosshairs.transform.position = new Vector2(Target.x, Target.y);
		
		Vector3 diff = Target - Ar.transform.position;
		float angleZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
		Ar.transform.rotation = Quaternion.Euler(0, 0, angleZ);

		if(Input.GetMouseButtonDown(0)){
			float distance = diff.magnitude;
			Vector2 direction = diff / distance;
			direction.Normalize();
			Arshooting(direction, angleZ);
		}
	}
		void Arshooting(Vector2 direction, float angleZ)
	{
		GameObject Bullet2 = Instantiate(ARBullet) as GameObject;
		Bullet2.transform.position = Ar.transform.position;
		Bullet2.transform.rotation = Quaternion.Euler(0f, 0f, angleZ);
	}
}
