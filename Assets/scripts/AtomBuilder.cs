using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtomBuilder : MonoBehaviour {
    const int MAX_NUM_ELECTRONS = 6;
    const int MAX_NUM_PROTONS   = 6;
    const int MAX_NUM_NEUTRONS  = 6;
    // Do we want to be able to add/remove electrons, neutrons, AND protons?

    GameObject _1s_Orbital;
    GameObject _1s2_Orbital;
    GameObject _2px_Orbital;
    GameObject _2py_Orbital;
    GameObject _2s2_Orbital;
    GameObject _2s_Orbital;
    GameObject ProtonGroup;
    GameObject NeutronGroup;
    public Text OrbitalDescription;
    
    List<string> orbitalDescriptions = new List<string>();
    // On every addElectron() click, check the number, and adjust the shells accordingly.
    public GameObject electronController = null;
    //public GameObject protonController = null;
    //public GameObject neutronController = null;

    public int numElectrons = 0;
    public int numProtons   = 0;
    public int numNeutrons  = 0;

    // On every addElectron
    // Use this for initialization
    void Start () {
        // Move 6 protons and 6 neutrons to the staging area.
        // Disable the [+]/[-] buttons for neutrons and protons.
        _1s_Orbital = GameObject.Find("1S_Orbital_1");
        _1s2_Orbital = GameObject.Find("1S2_Orbital_1");
        _2px_Orbital = GameObject.Find("2Px_Orbital_1");
        _2py_Orbital = GameObject.Find("2Py_Orbital_1");
        _2s2_Orbital = GameObject.Find("2S2_Orbital_1");
        _2s_Orbital = GameObject.Find("2S_Orbital_1");
        ProtonGroup = GameObject.Find("Proton_Group_1");
        NeutronGroup = GameObject.Find("Neutron_Group_1");
        //OrbitalDescription = GameObject.Find("Text_OrbitalDescription");
        _1s_Orbital.SetActive(false);
        _1s2_Orbital.SetActive(false);
        _2px_Orbital.SetActive(false);
        _2py_Orbital.SetActive(false);
        _2s2_Orbital.SetActive(false);
        _2s_Orbital.SetActive(false);
        orbitalDescriptions.Add("None");
        orbitalDescriptions.Add("1S Orbital");
        orbitalDescriptions.Add("1S2 Orbital");
        orbitalDescriptions.Add("2S Orbital");
        orbitalDescriptions.Add("2S2 Orbital");
        orbitalDescriptions.Add("2Px Orbital");
        orbitalDescriptions.Add("2Py Orbital");
    }
	
    // Electrons =====================
    public void addElectron()
    {
        if (numElectrons < MAX_NUM_ELECTRONS)
        {
            numElectrons += 1;
        }
        handleElectronShells();
    }

    public void removeElectron()
    {
        if (numElectrons > 0)
        {
            numElectrons -= 1;
        }
        handleElectronShells();
    }

    void handleElectronShells()
    {
        OrbitalDescription.text = orbitalDescriptions[numElectrons];
        switch (numElectrons)
        {
            case 0:
                //OrbitalDescription. = orbitalDescriptions[0];
                _1s_Orbital.SetActive(false);
                _1s2_Orbital.SetActive(false);
                _2px_Orbital.SetActive(false);
                _2py_Orbital.SetActive(false);
                _2s2_Orbital.SetActive(false);
                _2s_Orbital.SetActive(false);
                
                break;
            case 1:
                ProtonGroup.SetActive(false);
                NeutronGroup.SetActive(false);
                _1s2_Orbital.SetActive(false);
                _1s_Orbital.SetActive(true);
                break;
            case 2:
                _1s_Orbital.SetActive(false);
                _2s_Orbital.SetActive(false);
                _1s2_Orbital.SetActive(true);
                break;
            case 3:
                _1s2_Orbital.SetActive(false);
                _2s2_Orbital.SetActive(false);
                _2s_Orbital.SetActive(true);
                break;
            case 4:
                _2py_Orbital.SetActive(false);
                _2px_Orbital.SetActive(false);
                _2s_Orbital.SetActive(false);
                _2s2_Orbital.SetActive(true);
                break;
            case 5:
                _2s2_Orbital.SetActive(false);
                _2px_Orbital.SetActive(true);
                break;
            case 6:
                _2py_Orbital.SetActive(true);
                break;
            default:
                break;
        }
    }


    // Neutrons =====================
    public void addNeutron()
    {
        if (numNeutrons < MAX_NUM_NEUTRONS)
        {
            numNeutrons += 1;
        }
    }

    public void removeNeutron()
    {
        if (numNeutrons > 0)
        {
            numNeutrons -= 1;
        }
    }


    // Protons =====================
    public void addProton()
    {
        if (numProtons < MAX_NUM_PROTONS)
        {
            numProtons += 1;
        }
    }

    public void removeProton()
    {
        if (numProtons > 0)
        {
            numProtons -= 1;
        }
    }
}
