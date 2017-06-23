using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInventory : MonoBehaviour {

    #region Variables
    public GameObject inventory;
    #endregion

    void Start() {
        inventory.SetActive(false);
    }

    void Update() {
        ShowCanvas();
    }

    void ShowCanvas() {
        if (Input.GetButtonDown("Tab")) {
            inventory.SetActive(true);
        }

        if (Input.GetButtonUp("Tab")) {
            inventory.SetActive(false);
        }
    }
}
