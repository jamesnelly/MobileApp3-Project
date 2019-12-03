using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// adapted from https://www.youtube.com/watch?v=SOmBhbVz5yQ
public class ScoreManager : MonoBehaviour {
	public static int score;

	Text text;

	void Awake()
	{
		text = GetComponent <Text> ();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: " + score;
	}
}
