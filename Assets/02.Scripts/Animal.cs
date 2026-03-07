using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWalkable
{
    void Walk();
}   

public class Animal 
{
    public string Name { get; set; }

    //가상 함수

    public virtual void Speak()
    {
        Debug.Log("동물은 짓는 소리를 낸다.");
    }

}
