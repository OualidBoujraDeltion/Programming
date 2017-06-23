using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    #region Variables
    public GameObject playerPrefab;

    public Vector3 spawnPoint;

    public bool playerDead;
    #endregion
	
	void Update () {
        Respawning();
	}

    void Respawning() {
        if (playerDead == true) {
            Instantiate(playerPrefab, spawnPoint, Quaternion.identity);
            playerDead = false;
        }
    }

    void OnCollisionEnter(Collision death) {
        if (death.collider.CompareTag("Player")) {
            playerDead = true;
        }
    }
}