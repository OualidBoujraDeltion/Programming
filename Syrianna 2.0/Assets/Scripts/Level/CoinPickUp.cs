using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour {

    #region Variables

    #endregion

    public void OnTriggerEnter (Collider coin){
        // If an object with the tag "Player" gets into this collider, the score will go up by 10 and this object will disappear.
        if (coin.CompareTag("Player")){
            ScoreCounter.gameScore = ScoreCounter.gameScore + 10;
            Destroy(gameObject);
        }
    }
}
