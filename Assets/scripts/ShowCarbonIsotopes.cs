using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCarbonIsotopes : MonoBehaviour {
    GameObject carbonMain = GameObject.FindWithTag("Btn_CarbonMain");
    GameObject carbonIso1 = GameObject.FindWithTag("Btn_CarbonIso1");
    GameObject carbonIso2 = GameObject.FindWithTag("Btn_CarbonIso2");


    // Use this for initialization
    void Start ()
    {
        double carbonEndingZAxis = -0.1;
        carbonMain.SetActive(true);
        carbonIso1.SetActive(true);
        carbonIso2.SetActive(true);

        Vector3 carbonPos = carbonMain.transform.position;
        Vector3 carbon1Pos = carbonIso1.transform.position;
        Vector3 carbon2Pos = carbonIso2.transform.position;

        while (carbon2Pos.z <= carbonEndingZAxis)
        {
            carbonPos.z -= (float)(Time.deltaTime * 0.01);
            carbon1Pos.z -= (float)(Time.deltaTime * 0.01);
            carbon2Pos.z -= (float)(Time.deltaTime * 0.01);

            carbonMain.transform.position = carbonPos;
            carbonIso1.transform.position = carbon1Pos;
            carbonIso2.transform.position = carbon2Pos;
        }

    }
	
}
