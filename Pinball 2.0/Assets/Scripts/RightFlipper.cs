using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlipper : MonoBehaviour {

    #region Variables
    [Header("Variables")]
    Transform flipperTransform;

    public GameObject flipper;

    [Tooltip("Insert rotation range.")]
    public float slashSpeed;

    [Tooltip("Insert InputKey you did like to use.")]
    public string slashKey;
    #endregion

    void Start() {
        flipperTransform = transform;
    }

    void Update() {
        Slash();
    }

    void Slash() {
        if (Input.GetButtonDown(slashKey)) {
            flipperTransform.RotateAround(transform.position, flipper.transform.up, slashSpeed * Time.deltaTime);
        }

        if (Input.GetButtonUp(slashKey)) {
            flipperTransform.RotateAround(transform.position, flipper.transform.up, -slashSpeed * Time.deltaTime);
        }
    }
}