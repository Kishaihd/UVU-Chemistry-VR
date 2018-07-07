using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load_BigPencil_Scene : MonoBehaviour {

	// Use this for initialization
	//void Start () {

	//}

    void LoadLevel(string levelName)
    {
        Application.LoadLevel(name: levelName);
    }
	
}
