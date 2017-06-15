using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    #region Variables
    public Vector3 spawnPoint;

    public float playerSpeed;
    private float maxSpeed;
    private float minSpeed;

    public float jumpHeight;
    public bool mayIJump;

    public Rigidbody playerRigid;
    #endregion

    void Start(){
        PlayerSpawn();
        CalculateSpeed();
	}
	
	void Update(){
        Movement();
        CalculateSprint();
	}

    public void PlayerSpawn(){
        // Player spawn-point.
        transform.position = spawnPoint;
    }

    public void Movement(){
        // Horizontal movement.
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime);

        // Jumping.
        if (Input.GetButtonDown("Jump") && mayIJump == true){
            playerRigid.velocity = new Vector3(0, jumpHeight);
        }
    }

    public void CalculateSprint(){
        // Sprinting.
        if (Input.GetButton("Fire3")){
            playerSpeed = maxSpeed;
        }

        else{
            playerSpeed = minSpeed;
        }
    }

    public void CalculateSpeed(){
        // Setting up walking and sprinting speed.
        minSpeed = playerSpeed;
        maxSpeed = playerSpeed * 2;
    }

    public void OnTriggerEnter(Collider jumping){
        // On trigger with these tags, I should be able to jump.
        if (jumping.CompareTag("Grounded") | jumping.CompareTag("JumpReset")){
            mayIJump = true;
            print("You can jump now.");
        }
    }

    public void OnTriggerExit(Collider jumping){
        // Once you exit this collider, it should reset the bool.
        if (jumping.CompareTag("Grounded") | jumping.CompareTag("JumpReset")){
            mayIJump = false;
            print("You can not jump now.");
        }

    }
}