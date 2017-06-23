using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour {

    #region Variables
    public float score, bumperScore, flipperScore;

    public bool bumper;
    #endregion
	
	void Update () {
        CalcScore();
	}

    void CalcScore() {
        if (bumper == true) {
            score = bumperScore;
        }
        else {
            score = flipperScore;
        }
    }

    void OnTriggerEnter() {
        ScoreBoard.scoreValue = ScoreBoard.scoreValue + score;
    }
}