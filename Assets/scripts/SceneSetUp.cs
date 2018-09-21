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

    public GameObject[] carbon12AtomGroupPrefabs;
    public GameObject[] carbon12s;

    public GameObject[] electronGroupPrefabs;
    public GameObject[] electrons;

    public GameObject[] protonGroupPrefabs;
    public GameObject[] protons;

    public GameObject[] neutronGroupPrefabs;
    public GameObject[] neutrons;

    public GameObject[] specialLightPrefabs;
    public GameObject[] specialLights;
      

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

        if (sceneID == 3)
        {
            Carbon12AtomGroup();
            ElectronGroup();
            ProtonGroup();
            NeutronGroup();
            SpecialLights();
        }

        if (sceneID == 4)
        {
            
        //carbon isotopes models - this section needs to be setup
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
        if (sceneID != 3)
        { 
            Instantiate(centerLightPrefab, centerLightPrefab.transform.position, centerLightPrefab.transform.rotation);
        //Debug.Log("CenterLight on!");
        }
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

    private void Carbon12AtomGroup()
    {
        carbon12s = new GameObject[carbon12AtomGroupPrefabs.Length];
        for (int i = 0; i < carbon12AtomGroupPrefabs.Length; i++)
        {
            carbon12s[i] = Instantiate(carbon12AtomGroupPrefabs[i]) as GameObject;
            //Debug.Log("carbon 12 atom object:" + i);
        }
    }

    private void ElectronGroup()
    {
        electrons = new GameObject[electronGroupPrefabs.Length];
        for (int i = 0; i < electronGroupPrefabs.Length; i++)
        {
            electrons[i] = Instantiate(electronGroupPrefabs[i]) as GameObject;
            //Debug.Log("electron object:" + i);
        }
    }

    private void ProtonGroup()
    {
            protons = new GameObject[protonGroupPrefabs.Length];
            for (int i = 0; i < protonGroupPrefabs.Length; i++)
            {
                protons[i] = Instantiate(protonGroupPrefabs[i]) as GameObject;
                //Debug.Log("carbon 12 atom object:" + i);
            }
    }

    private void NeutronGroup()
    {
                neutrons = new GameObject[neutronGroupPrefabs.Length];
                for (int i = 0; i < neutronGroupPrefabs.Length; i++)
                {
                    neutrons[i] = Instantiate(neutronGroupPrefabs[i]) as GameObject;
                    //Debug.Log("carbon 12 atom object:" + i);
                }
    }

    private void SpecialLights()
    {
                specialLights = new GameObject[specialLightPrefabs.Length];
                for (int i = 0; i < specialLightPrefabs.Length; i++)
                {
                    specialLights[i] = Instantiate(specialLightPrefabs[i]) as GameObject;
                    //Debug.Log("carbon 12 atom object:" + i);
                }
    }
}
