using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementTester : MonoBehaviour {

    private CharacterController controller;
    private Vector3 newPosition;
    public float Speed = 10f;
    public float Gravity = 9.81f;
    public float JumpSpeed = 10f;
    public bool CanRun = true;



	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            newPosition.y = JumpSpeed;
        }

        newPosition.y -= Gravity;

        if (CanRun)
        {
            newPosition.x = Speed * Input.GetAxis("Horizontal");
            newPosition.z = Speed * Input.GetAxis("Vertical");
        }
        controller.Move(newPosition * Time.deltaTime);
	}
}
