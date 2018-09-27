using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneSetUp : MonoBehaviour
{
    private int SceneID;

    public GameObject eventSystemPrefab;
    //public GameObject sceneLoader;
    //public GameObject highlightScript;

    public GameObject centerLightPrefab;

    public GameObject playerPrefab;

    public GameObject objectivesMenuPrefab;
    public GameObject periodicTablePrefab;

    public GameObject giantPencilPrefab;
    public GameObject giantPencilLightPrefab;

    public GameObject C12atomcenterlightISOPrefab;

    public GameObject ones2OrbitalInnerPrefab;
    public GameObject ones2OrbitalAnimatedPrefab;
    public GameObject twos2OrbitalInnerPrefab;
    public GameObject twos2OrbitalAnimatedPrefab;
    public GameObject twopxOrbitalPrefab;
    public GameObject twopyOrbitalPrefab;

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

    public GameObject[] neutronIsotopePrefabs;
    public GameObject[] neutronIsotopes;
      

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

        //SceneUniqueItems();  ------Uncomment this once replacement section is debugged------

        //Debug.Log("Scene ID: ");
        Debug.Log(sceneID);    

        // I want to replace all of these if statements with the ienumerator section below but it is getting errors----------------------------------------
        //if (sceneID == 0)
        //{
        //    //Debug.Log("Scene ID: 0");
        //    PerimeterLight();
        //    PeriodicTable();
        //}

        //if (sceneID == 1)
        //{
        //    GiantPencil();
        //}

        //if (sceneID == 2)
        //{
        //    CarbonLattice();
        //}

        //if (sceneID == 3)
        //{
        //    Carbon12AtomGroup();
        //    ElectronGroup();
        //    ProtonGroup();
        //    NeutronGroup();
        //    SpecialLights();
        //}

        //if (sceneID == 4)
        //{
        //    SpecialLights();
        //    Instantiate(C12atomcenterlightISOPrefab, C12atomcenterlightISOPrefab.transform.position, C12atomcenterlightISOPrefab.transform.rotation);
        //    ProtonGroup();
        //    ElectronIsotopes();
        //    NeutronIsotopes();
            
        //}
        //-------------------end of if statements---- want to replace the above section with ienumerator or similar as shown below (SceneUniqueItems)------

    }

    ///* ---------- this section is the replacement for if statements above BUT it is getting c# errors that need to be fixed with ienumerator name and sceneid------
 void SceneUniqueItems()
    {
        switch (SceneID)
        {
            case 0:
                PerimeterLight();
                PeriodicTable();
                break;

            case 1:
                GiantPencil();
                break;

            case 2:
                CarbonLattice();
                break;

            case 3:
                Carbon12AtomGroup();
                ElectronGroup();
                ProtonGroup();
                NeutronGroup();
                SpecialLights();
                break;

            case 4:
                SpecialLights();
                Instantiate(C12atomcenterlightISOPrefab, C12atomcenterlightISOPrefab.transform.position, C12atomcenterlightISOPrefab.transform.rotation);
                ProtonGroup();
                ElectronIsotopes();
                NeutronIsotopes();
                break;

            default:
                Debug.Log(sceneID);
                break;
        }
    }
    //-----------end of replacement section that needs debugging help ------------*/

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
        if (sceneID != 3 || sceneID != 5)
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

    private void NeutronIsotopes()
    {
        neutronIsotopes = new GameObject[neutronIsotopePrefabs.Length];
        for (int i = 0; i < neutronIsotopePrefabs.Length; i++)
        {
            neutronIsotopes[i] = Instantiate(neutronIsotopePrefabs[i]) as GameObject;
            //Debug.Log("neutron isotope:" + i);
        }
    }

   private void ElectronIsotopes()
    {
        electrons = new GameObject[electronGroupPrefabs.Length];
        for (int i = 0; i < electronGroupPrefabs.Length; i++)
        {
            Debug.Log(i);
             switch (i)
             {
                    case 0:
                        electrons[i] = Instantiate(electronGroupPrefabs[i]) as GameObject;
                        Debug.Log(i);
                        break;

                    case 1:
                        electrons[i] = Instantiate(electronGroupPrefabs[i]) as GameObject;
                        Instantiate(ones2OrbitalInnerPrefab, ones2OrbitalInnerPrefab.transform.position, ones2OrbitalInnerPrefab.transform.rotation);
                        Instantiate(ones2OrbitalAnimatedPrefab, ones2OrbitalAnimatedPrefab.transform.position, ones2OrbitalAnimatedPrefab.transform.rotation);
                        WaitForSeconds(2);
                        Debug.Log(i);
                    break;

                    case 2:
                        electrons[i] = Instantiate(electronGroupPrefabs[i]) as GameObject;
                        Debug.Log(i);
                    break;
                                               
                    case 3:
                        electrons[i] = Instantiate(electronGroupPrefabs[i]) as GameObject;
                        Instantiate(twos2OrbitalInnerPrefab, twos2OrbitalInnerPrefab.transform.position, twos2OrbitalInnerPrefab.transform.rotation);
                        Instantiate(twos2OrbitalAnimatedPrefab, twos2OrbitalAnimatedPrefab.transform.position, twos2OrbitalAnimatedPrefab.transform.rotation);
                        WaitForSeconds(2);
                        Debug.Log(i);
                    break;

                    case 4:
                        electrons[i] = Instantiate(electronGroupPrefabs[i]) as GameObject;
                        Instantiate(twopxOrbitalPrefab, twopxOrbitalPrefab.transform.position, twopxOrbitalPrefab.transform.rotation);
                         WaitForSeconds(2);
                        Debug.Log(i);
                    break;

                    case 5:
                        electrons[i] = Instantiate(electronGroupPrefabs[i]) as GameObject;
                        Instantiate(twopyOrbitalPrefab, twopyOrbitalPrefab.transform.position, twopyOrbitalPrefab.transform.rotation);
                        WaitForSeconds(2);
                        Debug.Log(i);
                    break;

                    default:
                        Debug.Log(i);
                    break;
  
             }
        }
    }

    private IEnumerator WaitForSeconds(int n)
    {
        yield return new WaitForSecondsRealtime(n);
    }
}
