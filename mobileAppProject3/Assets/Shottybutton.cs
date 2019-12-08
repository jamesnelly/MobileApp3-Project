using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shottybutton : MonoBehaviour {

	public GameObject AR; 
	public GameObject shotgun;
	public GameObject Sniper;
	//public int selectedWeapon = 0;

	public void shotty()
	{ 
			AR.SetActive(false);
			shotgun.SetActive(true);
			Sniper.SetActive(false);
	}
}
