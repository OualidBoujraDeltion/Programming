using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour {

    #region Variables
    static public float scoreValue;
    static public float livesMatter;

    public float lives;
    #endregion

    void Start() {
        livesMatter = lives;
    }

    void OnGUI() {
        GUILayout.BeginArea(new Rect(10, 10, 200, 200));
        GUILayout.Label("Score: " + scoreValue);
        GUILayout.Label("Lives: " + livesMatter);
    }
}