using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuChange : MonoBehaviour {
    public List<GameObject> sceneObjectives;
    public Dropdown dropdown;
    public GameObject lessonObjectives;

	// Use this for initialization
	void Start ()
    {
        SelectLesson();
	}

    void SelectLesson()
    {
        sceneObjectives.AddRange(GameObject.FindGameObjectsWithTag("lessonObjective"));
    }

    public void Dropdown_IndexChanged(int index)
    {
        foreach (GameObject item in sceneObjectives)
        {
            item.SetActive(false);
        }
        sceneObjectives[index].SetActive(true);
    }

	
}
