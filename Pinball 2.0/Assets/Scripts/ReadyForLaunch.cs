using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyForLaunch : MonoBehaviour {

    #region Variables
    static public bool readyToFire;
    #endregion

    void OnTriggerEnter() {
        readyToFire = true;
    }

    void OnTriggerExit() {
        readyToFire = false;
    }
}