using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	//Postions where the player will move to 
	public GameObject [] Directions;
	public GameObject [] Directions1;
	public GameObject [] Directions2;

	//Enemy Object
	public GameObject MyEnemy1;
	public GameObject MyEnemy2;
	public GameObject MyEnemy3;

	Enemy My_Enemy_Script1;
	Enemy My_Enemy_Script2;
	Enemy My_Enemy_Script3;

	//Currnt Postion
	int current = 0;
	int current1 = 0;
	int current2 = 0;
	//Speed of player movement
	public float speed;
	// distance between loacation's
	float radius = 0;
	float radius1 = 0;
	float radius2 = 0;

	 // All Enemies Health
	public int Health_Info1 = 100;
	public int Health_Info2 = 100;
	public int Health_Info3 = 100;

	 void Start(){

		 My_Enemy_Script1 = MyEnemy1.GetComponent<Enemy>();
		 My_Enemy_Script2 = MyEnemy2.GetComponent<Enemy>();
		 My_Enemy_Script3 = MyEnemy3.GetComponent<Enemy>();
	 }
	
	// Update is called once per frame
	void Update(){
		Health_Info1 = My_Enemy_Script1.Health;
		Health_Info2 = My_Enemy_Script2.Health;
		Health_Info3 = My_Enemy_Script3.Health;
		
		Move1();
		Move2();
		Move3();
		}

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
				transform.position = Vector3.MoveTowards(transform.position, Directions2[current2].transform.position, Time.smoothDeltaTime * speed + 0.30f);
			}
		}
	}
