using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowKeys : MonoBehaviour {

    #region Variables
    public string[] tutorialRows;

    public bool tutorial;
    #endregion

    void Start(){
        tutorial = true;
	}
	
	void Update(){
		
	}

    public void OnTriggerExit(){
        tutorial = false;
    }

    public void OnGUI(){
        GUILayout.BeginArea(new Rect(10, 500, 140, 200));
        if (tutorial == true){
            GUILayout.Label(tutorialRows[0]);
            GUILayout.Label(tutorialRows[1]);
            GUILayout.Label(tutorialRows[2]);
        }
        GUILayout.EndArea();
    }
}