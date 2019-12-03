using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArButton : MonoBehaviour {

	public GameObject AR; 
	public int selectedWeapon = 1;
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetText(string Text)
	{ 
		Text txt = transform.Find("Text").GetComponent<Text>();
		txt.text = Text;
		Debug.Log("new = "+Text);
	}
}
