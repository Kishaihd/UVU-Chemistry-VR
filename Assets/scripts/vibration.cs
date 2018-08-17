using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vibration : MonoBehaviour {

    Vector3 particlePosition;

	// Use this for initialization
	void Start () {
        Debug.Log("BEGIN THE VIBRATIONS!");
        particlePosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        particlePosition.x *= -1;
        transform.position = particlePosition;
	}
}
