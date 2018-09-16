using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneSetUp : MonoBehaviour
{
    public GameObject eventSystemPrefab;
    //public GameObject sceneLoader;
    //public GameObject highlightScript;

    public GameObject centerLightPrefab;

    public GameObject playerPrefab;

    public GameObject objectivesMenuPrefab;
    public GameObject periodicTablePrefab;

    public GameObject giantPencilPrefab;
    public GameObject giantPencilLightPrefab;

    public GameObject[] perimeterLightPrefabs;
    public GameObject[] perimeterLights;

    public GameObject[] sceneryPrefabs;
    public GameObject[] scenery;

    public GameObject[] labEquipmentPrefabs;
    public GameObject[] labEquipments;

    public GameObject[] screenPrefabs;
    public GameObject[] screens;

    public GameObject[] carbonLatticePrefabs;
    public GameObject[] carbons;

    private int sceneID;
    //private AssetBundle scenes;
    //public int buildindex { get; private set; }


    // Use this for initialization
    void Start()
    {
        sceneID = SceneManager.GetActiveScene().buildIndex;

        EventSystem();

        //HighlightSystem();

        CenterLight();

        LabEquipment();

        Objectives();

        Player();

        Scenery();

        Screen();
        Debug.Log("Scene ID: ");
        Debug.Log(sceneID);
        
        if (sceneID == 0)
        {
            Debug.Log("Scene ID: 0");
            PerimeterLight();
            PeriodicTable();
        }

        if (sceneID == 1)
        {
            GiantPencil();
        }

        if (sceneID == 2)
        {
            CarbonLattice();
        }



    }

    private void EventSystem()
    {
        Instantiate(eventSystemPrefab);
    }

    //private void HighlightSystem()
    //{
    //    Instantiate(highlightScript);
    //}

    private void CenterLight()
    {
        Instantiate(centerLightPrefab, centerLightPrefab.transform.position, centerLightPrefab.transform.rotation);
        //Debug.Log("CenterLight on!");
    }

    private void PerimeterLight()
    {
        perimeterLights = new GameObject[perimeterLightPrefabs.Length];
        for (int i = 0; i < perimeterLightPrefabs.Length; i++)
        {
            perimeterLights[i] = Instantiate(perimeterLightPrefabs[i]) as GameObject;
            //Debug.Log("perimeter light:" + i);
        }
    }

    private void PeriodicTable()
    {
        Instantiate(periodicTablePrefab); 
    }

    private void Objectives()
    {
        Instantiate(objectivesMenuPrefab);
    }

    private void LabEquipment()
    {
        labEquipments = new GameObject[labEquipmentPrefabs.Length];
        for (int i = 0; i < labEquipmentPrefabs.Length; i++)
        {
            labEquipments[i] = Instantiate(labEquipmentPrefabs[i]) as GameObject;
            //Debug.Log("lab equipment #:" + i);
        }
    }

    private void Player()
    {
        Instantiate(playerPrefab, playerPrefab.transform.position, playerPrefab.transform.rotation);
        //Debug.Log("player");
    }

    private void Screen()
    {
        screens = new GameObject[screenPrefabs.Length];
        for (int i = 0; i < screenPrefabs.Length; i++)
        {
            screens[i] = Instantiate(screenPrefabs[i]) as GameObject;
            //Debug.Log("screen:" + i);
        }
    }

    private void Scenery()
    {
        scenery = new GameObject[sceneryPrefabs.Length];
        for (int i = 0; i < sceneryPrefabs.Length; i++)
        {
            scenery[i] = Instantiate(sceneryPrefabs[i]) as GameObject;
            //Debug.Log("scenery:" + i);
        }
    }

    private void GiantPencil()
    {
        Instantiate(giantPencilPrefab, giantPencilPrefab.transform.position, giantPencilPrefab.transform.rotation);
        Instantiate(giantPencilLightPrefab, giantPencilLightPrefab.transform.position, giantPencilLightPrefab.transform.rotation);
        //Debug.Log("pencil");
    }

    private void CarbonLattice()
    {
        carbons = new GameObject[carbonLatticePrefabs.Length];
        for (int i = 0; i < carbonLatticePrefabs.Length; i++)
        {
            carbons[i] = Instantiate(carbonLatticePrefabs[i]) as GameObject;
            //Debug.Log("carbon lattice object:" + i);
        }
    }
}
