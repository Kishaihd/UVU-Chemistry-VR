using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public struct ClickedEventArgs
{
    public uint controllerIndex;
    public uint flags;
    public float padX, padY;
}

public delegate void ClickedEventHandler(object sender, ClickedEventArgs e);


public class HandScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}



public class Movement : MonoBehaviour
{
    public GameObject player;

    SteamVR_Controller.Device device;
    SteamVR_TrackedObject controller;

    Vector2 touchpad;

    private float sensitivityX = 1.5f;
    private Vector3 playerPos;

    // Use this for initialization
    void Start()
    {
        controller = gameObject.GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update()
    {
        device = SteamVR_Controller.Input((int)controller.index);

        // Device agnostic input? :O
        if (device.GetTouch(SteamVR_Controller.ButtonMask.Axis2))
        {
            // Actually just analog stick.
            touchpad = device.GetAxis(EVRButtonId.k_EButton_Axis2);
            Debug.Log("Axis2 is being touched!\nX Value: " + touchpad.x + "\nY Value:" + touchpad.y);

            if (touchpad.y > 0.2f || touchpad.y < -0.2f)
            {
                // Move forward
                player.transform.position -= player.transform.forward * Time.deltaTime * (touchpad.y * 5f);

                // Adjust height to terrain height at the player's position.
                playerPos = player.transform.position;
                playerPos.y = Terrain.activeTerrain.SampleHeight(player.transform.position);
                player.transform.position = playerPos;
            }

            // Handle rotation via touchpad.
            if (touchpad.x > 0.3f || touchpad.x < -0.3f)
            {
                player.transform.Rotate(0, touchpad.x * sensitivityX, 0);
            }

            Debug.Log("Touchapd X = " + touchpad.x + " : touchpad Y =" + touchpad.y);

        }

        // If finger is on touchpad.
        if (device.GetTouch(SteamVR_Controller.ButtonMask.Touchpad))
        {
            touchpad = device.GetAxis(EVRButtonId.k_EButton_SteamVR_Touchpad);

            if (touchpad.y > 0.2f || touchpad.y < -0.2f)
            {
                // Move forward
                player.transform.position -= player.transform.forward * Time.deltaTime * (touchpad.y * 5f);

                // Adjust height to terrain height at the player's position.
                playerPos = player.transform.position;
                playerPos.y = Terrain.activeTerrain.SampleHeight(player.transform.position);
                player.transform.position = playerPos;
            }

            // Handle rotation via touchpad.
            if (touchpad.x > 0.3f || touchpad.x < -0.3f)
            {
                player.transform.Rotate(0, touchpad.x * sensitivityX, 0);
            }

            Debug.Log("Touchapd X = " + touchpad.x + " : touchpad Y =" + touchpad.y);
        }
    }
}
