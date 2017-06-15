using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour {

    #region Variables
    static public float gameScore;
    #endregion

    public void OnGUI(){
        // This GUI will show the score you have at all time.
        GUILayout.BeginArea(new Rect(10, 10, 50, 50));
        GUILayout.Label("Score; " + gameScore);
    }
}
