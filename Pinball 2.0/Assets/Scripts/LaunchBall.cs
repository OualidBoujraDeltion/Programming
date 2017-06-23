using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour {

    #region Variables
    [Header("Launch Variables")]
    [Tooltip("This is the duration of you charging the ball.")]
    public float chargeTime;

    [Tooltip("Charge Power is the amount of force there will be added to the launch.")]
    public float chargePower;

    [Tooltip("This will notify you whenever you're charging the ball.")]
    public bool charging;

    [Tooltip("If this bool is on true, you're good to go.")]
    public bool readyToLaunch;

    [Space]

    [Tooltip("Add Rigidbody of the pinball, to make use of velocity.")]
    public Rigidbody PinballRigid;
    #endregion

    void Update() {
        LaunchCharge();
        FireBall();
    }

    void LaunchCharge() {
        if (Input.GetButton("Jump")) {
            charging = true;
            chargeTime = chargeTime + chargePower * Time.deltaTime;
        }
    }

    void FireBall() {
        if (Input.GetButtonUp("Jump") && ReadyForLaunch.readyToFire == true) {
            PinballRigid.velocity = new Vector3(0, 0, chargeTime);
            chargeTime -= chargeTime;
            charging = false;
        }
    }
}