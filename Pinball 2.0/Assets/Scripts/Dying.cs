using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dying : MonoBehaviour {

    void OnCollisionEnter(Collision death) {
        if (death.collider.CompareTag("Death")) {
            Destroy(gameObject);
            ScoreBoard.livesMatter = ScoreBoard.livesMatter - 1;
        }
    }
}