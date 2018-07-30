using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	private CharacterController _controller;
	[SerializeField] 
	private float _speed = 3.5f;

	private float _gravity = 9.81f;
	
	// Use this for initialization
	void Start ()
	{
		_controller = GetComponent<CharacterController>();
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;

	}
	
	// Update is called once per frame
	void Update ()
	{
		KeyEscape();
		
		CalculateMovement();

		LMBClick();

	}

	void CalculateMovement()
	{
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");
		Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
		Vector3 velocity = direction * _speed;
		velocity.y -= _gravity;
		velocity = transform.transform.TransformDirection(velocity);
		_controller.Move(velocity * Time.deltaTime);
	}

	void KeyEscape()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}
	}

	void LMBClick()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray rayOrigin = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
			RaycastHit hitInfo;

			if (Physics.Raycast(rayOrigin, out hitInfo))
			{
				Debug.Log("Hit:" + hitInfo.transform.name);
			}
		}
	}
}
