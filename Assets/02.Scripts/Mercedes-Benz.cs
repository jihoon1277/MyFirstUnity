using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercedesBenz : Car
{
    // Start is called before the first frame update
    void Start()
    {
        Company = "Mercedes-Benz";
        ModelName = "S-Class";
        Debug.Log("Company: " + Company);
        Debug.Log("Model Name: " + ModelName);
        GasPedal();
        BreakePadal(); 
        AI_DriveMode();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
