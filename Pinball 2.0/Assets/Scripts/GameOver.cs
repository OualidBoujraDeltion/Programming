using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	void Update () {
        NoGameNoLife();
	}

    void NoGameNoLife() {
        if (ScoreBoard.livesMatter == 0) {
            Application.Quit();
        }
    }
}
