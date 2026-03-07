using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    //1.델리게이트 선언하기
    public delegate void MyDelegate(string message);

    void printMessage(string message)
    {
        Debug.Log("printMessege" + message);
    }
    void LogMessage(string message)
    {
        Debug.Log("printMessege" + message);
    }

    void Start()
    {

        MyDelegate myDelegate = null;


        myDelegate += printMessage;
        myDelegate += LogMessage;

        myDelegate("Hdkssud epfflzptmzxm");

        myDelegate -= LogMessage;
        myDelegate("LogMEssage를 지우고 호출했어");
    }
}