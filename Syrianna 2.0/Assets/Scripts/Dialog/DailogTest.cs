using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTest : MonoBehaviour {

    #region Variables
    public string[] answerButtons, questions;

    public bool dialogActive;
    public static bool questActive;
    #endregion

    void Start(){
		
	}

	void Update(){
		
	}

    public void OnGUI(){
        GUILayout.BeginArea(new Rect(500, 400, 400, 400));

        if (dialogActive && !questActive){
            GUILayout.Label(questions[0]);
            GUILayout.Label(questions[1]);

            if (GUILayout.Button(answerButtons[0])){
                questActive = true;
            }

            if (GUILayout.Button(answerButtons[1])){
                dialogActive = false;
            }
        }

        if (dialogActive && questActive){
            GUILayout.Label(questions[2]);
            if (GUILayout.Button(answerButtons[2])){
                dialogActive = false;
            }
        }

        GUILayout.EndArea();
    }

    public void OnTriggerEnter(){
        dialogActive = true;
    }

    public void OnTriggerExit(){
        dialogActive = false;
    }
}
