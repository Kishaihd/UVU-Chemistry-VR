using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuChange : MonoBehaviour {
    public List<GameObject> sceneObjectives;
    public Dropdown dropdown;

	// Use this for initialization
	void Start () {
        List<string> options = new List<string>();
        sceneObjectives.AddRange(GameObject.FindGameObjectsWithTag("lessonObjective"));

        foreach (var option in sceneObjectives)
        {
            options.Add(option.name);
        }
        options.Reverse();
        sceneObjectives.Reverse();
        dropdown.ClearOptions();
        dropdown.AddOptions(options);
        dropdown.value = sceneObjectives.IndexOf(GameObject.Find("Select Lesson"));
        Dropdown_IndexChanged(sceneObjectives.IndexOf(GameObject.Find("Select Lesson")));
	}
	
	public void Dropdown_IndexChanged(int index)
    {
        foreach (GameObject item in sceneObjectives)
        {
            item.SetActive(false);
            Debug.Log(item.gameObject.name);
        }
        sceneObjectives[index].SetActive(true);
    }
}
