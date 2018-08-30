using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SceneSetUp : MonoBehaviour
{
    [SerializeField]
    private GameObject centerLightPrefab;
    [SerializeField]
    private GameObject playerPrefab;
    [SerializeField]
    private GameObject[] perimeterLightPrefab;
    [SerializeField]
    private GameObject[] sceneryPrefab;
    [SerializeField]
    private GameObject[] labEquipmentPrefab;
    [SerializeField]
    private GameObject[] screenPrefab;

    private GameObject centerLight;
    private GameObject player;
    private GameObject[] perimeterLight;
    private GameObject[] scenery;
    private GameObject[] labEquipment;
    private GameObject[] screen;

    public int buildindex { get; private set; }

    // Use this for initialization
    void Start ()
    {
        if (centerLight == null)
        {
            CenterLight();
        }

        if (labEquipment[0] == null)
        {
            LabEquipment();
        }

        if (player == null)
        {
            Player();
        }

        if (buildindex == 0)
        {
            PerimeterLight();
        }
        else
        {
            Screen();
        }

	}

    private void CenterLight()
    {
        centerLight = GameObject.FindWithTag(tag: "Center_Light");
        Instantiate(centerLightPrefab, centerLight.transform.position, centerLight.transform.rotation);
    }
        
    private void PerimeterLight()
    {
        int x = 0;
        if (x < 8)
        perimeterLight[x] = GameObject.FindWithTag(tag: "Perimeter_Light");
        Instantiate(perimeterLightPrefab[x], perimeterLight[x].transform.position, perimeterLight[x].transform.rotation);
        x++;
    }

    private void LabEquipment()
    {
        int y = 0;
        if (y < 40)
        {
            labEquipment[y] = GameObject.FindWithTag(tag: "Lab_Equipment");
            Instantiate(labEquipmentPrefab[y], labEquipment[y].transform.position, labEquipment[y].transform.rotation);
            y++;
        }
    }

    private void Player()
    {
        player = GameObject.FindWithTag(tag: "Player");
        Instantiate(playerPrefab, player.transform.position, player.transform.rotation);
    }

    private void Screen()
    {
        int z = 0;
        if (z < 4)
        {
            screen[z] = GameObject.FindWithTag(tag: "Interior_Screen");
            Instantiate(screenPrefab[z], labEquipment[z].transform.position, labEquipment[z].transform.rotation);
            z++;
        }
    }
}
