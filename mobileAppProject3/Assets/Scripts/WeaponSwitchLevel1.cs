using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSwitchLevel1 : MonoBehaviour {

	public GameObject AR; 
	public GameObject shotgun;
	public GameObject Sniper;
	public void shotty()
	{
			AR.SetActive(false);
			shotgun.SetActive(true);
			Sniper.SetActive(false);
	}
	public void ar()
	{
			AR.SetActive(true);
			shotgun.SetActive(false);
			Sniper.SetActive(false);
	}
	public void snippy()
	{
			AR.SetActive(false);
			shotgun.SetActive(false);
			Sniper.SetActive(true);
	}
}
