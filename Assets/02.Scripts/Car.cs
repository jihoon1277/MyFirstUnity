using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public string Company;
    private int year;
    public string ModelName;
    private bool isAccident;

    public void GasPedal()
    {
        Debug.Log("가속페달 발진!!");
    }
    public void BreakePadal()
    {
        Debug.Log("멈춰!!");
    }
    public void AI_DriveMode()
    {
        Debug.Log("자비스 운전해!!");
    }
}
