using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    // 가상 함수를 cat에 맞게 재정의 를 합니다.

    public override void Speak()
    {
        Debug.Log("고양이가 야옹 야옹 합니다.");
    }

    public void Walk()
    {
        Debug.Log("고양이가 꽁꽁 얼어붙은 한강위를 지나갑니다.");
    }
}
