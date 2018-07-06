using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNewScene : MonoBehaviour {
    string sceneToLoad;
    
	// Use this for initialization
	void Start ()
    {
        Debug.Log("LoadNewScene Script started.");
       
        Application.LoadLevel(name: "PeriodicTable_Scene");
    }
	

}
