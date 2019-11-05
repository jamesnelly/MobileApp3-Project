using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boudary : MonoBehaviour {

private Vector2 ScreenBoudary;
	// Use this for initialization
	void Start () {
		ScreenBoudary = Camera.main.ScreenToViewportPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
	}
	
	// Update is called once per frame
	void LateUpdate () {
		Vector3 viewPos = transform.position;
		viewPos.x = Mathf.Clamp(viewPos.x, ScreenBoudary.x, ScreenBoudary.x * -1);
		viewPos.y = Mathf.Clamp(viewPos.y, ScreenBoudary.y, ScreenBoudary.y * -1);
		transform.position = viewPos;

	}
}
