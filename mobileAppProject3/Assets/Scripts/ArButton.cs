using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArButton : MonoBehaviour {

	public GameObject AR; 
	public GameObject shotgun;

	public GameObject Sniper;
	//public int selectedWeapon = 0;

	public void Ar()
	{ 
			AR.SetActive(true);
			shotgun.SetActive(false);
			Sniper.SetActive(false);
	}
}
