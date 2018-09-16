using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {
        //Debug.Log("LoadScene ");
    }

    public void LoadScene(string scenename)
    {
        Debug.Log("Loading \"" + scenename + "\"");
        SceneManager.LoadScene(scenename);
    }
}
