using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLvl2 : MonoBehaviour {

#region Postions where the player will move to 
	public GameObject [] Directions;
	public GameObject [] Directions1;
	public GameObject [] Directions2;
	public GameObject [] Directions3;
	public GameObject [] Directions4;
	public GameObject [] Directions5;
	public GameObject [] Directions6;
	public GameObject [] Directions7;
	public int Health = 100;
#endregion
	
#region referencing single enemy's gameobject
	public GameObject MyEnemy1;
	public GameObject MyEnemy2;
	public GameObject MyEnemy3;
	public GameObject MyEnemy4;
	public GameObject MyEnemy5;
	public GameObject MyEnemy6;
	//public GameObject MyEnemy7;
	//public GameObject MyEnemy8;
#endregion

#region referencing single enemy's from the enemy script
	Enemy My_Enemy_Script1;
	Enemy My_Enemy_Script2;
	Enemy My_Enemy_Script3;
	Enemy My_Enemy_Script4;
	Enemy My_Enemy_Script5;
	Enemy My_Enemy_Script6;
//	Enemy My_Enemy_Script7;
//	Enemy My_Enemy_Script8;
	#endregion

#region Current Postion
	int current = 0;
	int current1 = 0;
	int current2 = 0;
	int current3 = 0;
	int current4 = 0;
	int current5 = 0;
	//int current6 = 0;
	//int current7 = 0;
	#endregion
public float speed;

#region distance between loacation's
	float radius = 0;
	float radius1 = 0;
	float radius2 = 0;
	float radius3 = 0;
	float radius4 = 0;
	float radius5 = 0;
	//float radius6 = 0;
	//float radius7 = 0;
	#endregion
	
#region Refencing enemys health in player class
	public int Health_Info1 = 100;
	public int Health_Info2 = 100;
	public int Health_Info3 = 100;
	public int Health_Info4 = 100;
	public int Health_Info5 = 100;
	public int Health_Info6 = 100;
	//public int Health_Info7 = 100;
	//public int Health_Info8 = 100;
	#endregion
	 
#region START METHOD getting enemy scripts to = there gameobjets
	 void Start(){
		 My_Enemy_Script1 = MyEnemy1.GetComponent<Enemy>();
		 My_Enemy_Script2 = MyEnemy2.GetComponent<Enemy>();
		 My_Enemy_Script3 = MyEnemy3.GetComponent<Enemy>();
		 My_Enemy_Script4 = MyEnemy4.GetComponent<Enemy>();
		 My_Enemy_Script5 = MyEnemy5.GetComponent<Enemy>();
		 My_Enemy_Script6 = MyEnemy6.GetComponent<Enemy>();
		// My_Enemy_Script7 = MyEnemy7.GetComponent<Enemy>();
		 //My_Enemy_Script8 = MyEnemy8.GetComponent<Enemy>();
	 }
	 #endregion
	
#region UPDATE METHOD getting enemy health to = there script health
	void Update(){
		Health_Info1 = My_Enemy_Script1.Health;
		Health_Info2 = My_Enemy_Script2.Health;
		Health_Info3 = My_Enemy_Script3.Health;
		Health_Info4 = My_Enemy_Script4.Health;
		Health_Info5 = My_Enemy_Script5.Health;
		Health_Info6 = My_Enemy_Script6.Health;
		//Health_Info7 = My_Enemy_Script7.Health;
		//Health_Info8 = My_Enemy_Script8.Health;
		
		Move1();
		Move2();
		Move3();
		Move4();
		Move5();
		Move6();
		//Move7();
		//Move8();
		}
		#endregion
		
#region MOVE MEHODS FOR PLAYER
		public void Move1(){
			Debug.Log("Enemy 1 Health = "+Health_Info1);
				if(My_Enemy_Script1.Health == 0 ){
					if(Vector3.Distance(Directions[current].transform.position, transform.position) < radius){
					current++;
					if(current >= Directions.Length)
					{
						current = 1;
					}
				}
				transform.position = Vector3.MoveTowards(transform.position, Directions[current].transform.position, Time.smoothDeltaTime * speed);
			}
		}
		public void Move2(){
			Debug.Log("Enemy 2 Health = "+Health_Info2);
				if(My_Enemy_Script2.Health == 0 ){
					if(Vector3.Distance(Directions1[current1].transform.position, transform.position) < radius1){
					current1++;
					if(current1 >= Directions1.Length)
					{
						current1 = 1;
					}
				}
				transform.position = Vector3.MoveTowards(transform.position, Directions1[current1].transform.position, Time.smoothDeltaTime * speed + 0.15f);
			}
		}
		public void Move3(){
			Debug.Log("Enemy 3 Health = "+Health_Info3);
				if(My_Enemy_Script3.Health == 0 ){
					if(Vector3.Distance(Directions2[current2].transform.position, transform.position) < radius2){
					current2++;
					if(current2 >= Directions2.Length)
					{
						current2 = 1;
					}
				}
				transform.position = Vector3.MoveTowards(transform.position, Directions2[current2].transform.position, Time.smoothDeltaTime * speed + 0.40f);
			}
		}

		public void Move4(){
			Debug.Log("Enemy 4 Health = "+Health_Info4);
				if(My_Enemy_Script4.Health == 0 ){
					if(Vector3.Distance(Directions3[current3].transform.position, transform.position) < radius3){
					current3++;
					if(current3 >= Directions3.Length)
					{
						current3 = 1;
					}
				}
				transform.position = Vector3.MoveTowards(transform.position, Directions3[current3].transform.position, Time.smoothDeltaTime * speed + 0.80f);
			}
		}

		 void Move5(){
			Debug.Log("Enemy 5 Health = "+Health_Info5);
				if(My_Enemy_Script5.Health == 0 ){
					if(Vector3.Distance(Directions4[current4].transform.position, transform.position) < radius4){
					current4++;
					if(current4 >= Directions4.Length)
					{
						current4 = 1;
					}
				}
				transform.position = Vector3.Lerp(transform.position, Directions4[current4].transform.position, Time.smoothDeltaTime * speed + 0.80f);
			}
		}

		public void Move6(){
			Debug.Log("Enemy 6 Health = "+Health_Info6);
				if(My_Enemy_Script6.Health == 0 ){
					if(Vector3.Distance(Directions5[current5].transform.position, transform.position) < radius5){
					current5++;
					if(current5 >= Directions5.Length)
					{
						current5 = 1;
					}
				}
				transform.position = Vector3.Lerp(transform.position, Directions5[current5].transform.position, Time.smoothDeltaTime * speed + 0.80f);
			}
		}

/*
		public void Move7(){
			Debug.Log("Enemy 7 Health = "+Health_Info7);
				if(My_Enemy_Script7.Health == 0 ){
					if(Vector3.Distance(Directions6[current6].transform.position, transform.position) < radius6){
					current6++;
					if(current6 >= Directions6.Length)
					{
						current6 = 1;
					}
				}
				transform.position = Vector3.MoveTowards(transform.position, Directions6[current6].transform.position, Time.smoothDeltaTime * speed + 0.80f);
			}
		}
*/

/*
		public void Move8(){
			Debug.Log("Enemy 8 Health = "+Health_Info8);
				if(My_Enemy_Script8.Health == 0 ){
					if(Vector3.Distance(Directions7[current7].transform.position, transform.position) < radius7){
					current7++;
					if(current7 >= Directions7.Length)
					{
						current7 = 1;
					}
				}
				transform.position = Vector3.MoveTowards(transform.position, Directions7[current7].transform.position, Time.smoothDeltaTime * speed + 0.80f);
			}
		}
		*/
		#endregion
		public void GettingHit(int Damage)
	{
		Health -= Damage;
		Debug.Log("Player Health = "+Health);
		if(Health <= 0)
		{
			Destroy(gameObject);
		}
	}
	}