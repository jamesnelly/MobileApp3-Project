using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SniperButton : MonoBehaviour {

	public GameObject AR; 
	public GameObject shotgun;
	public GameObject Sniper;
	//public int selectedWeapon = 0;

	public void Snippy()
	{ 
			AR.SetActive(false);
			shotgun.SetActive(false);
			Sniper.SetActive(true);
	}
}
