using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteQuest : MonoBehaviour {

    #region Variables
    public string[] answerButtons, questions;

    public bool dialogActive;
    #endregion

    public void OnGUI(){
        GUILayout.BeginArea(new Rect(500, 400, 400, 400));

        if (dialogActive && DialogTest.questActive){
            GUILayout.Label(questions[0]);
            GUILayout.Label(questions[1]);

            if (GUILayout.Button(answerButtons[0])){
                DialogTest.questActive = false;
            }

            if (GUILayout.Button(answerButtons[1])){
                dialogActive = false;
            }
        }

        if (dialogActive && !DailogTest.questActive){
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
