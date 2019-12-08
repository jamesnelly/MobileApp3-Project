using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    private bool pauseGame = false;
    void Update(){

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(pauseGame)
                Time.timeScale = 1;
            else 
                Time.timeScale = 0;
                 
             pauseGame = !pauseGame;
        }
    }

}