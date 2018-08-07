using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownMenu : MonoBehaviour {

    public List<GameObject> lessonObjectives;

	// Use this for initialization
	void Start () {
        lessonObjectives.AddRange(GameObject.FindGameObjectsWithTag("lessonObjectives"));
	}
	
    public void Dropdown_IndexChanged(int index)
    {
        foreach (GameObject item in lessonObjectives)
        {
            item.SetActive(false);
        }
        lessonObjectives[index].SetActive(true);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
