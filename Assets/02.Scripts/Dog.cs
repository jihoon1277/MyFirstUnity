using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    
    //가상 함수를 Dog에 맞게 재정의 를 합니다.

    public override void Speak()
    {
        Debug.Log("강아지가 멍멍 합니다.");
    }
}
