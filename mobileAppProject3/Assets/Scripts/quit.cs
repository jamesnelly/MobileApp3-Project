using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour {

    public void quitGame(){
        Cursor.visible = true;
        Debug.Log("quit");
        Application.Quit();
    }

}