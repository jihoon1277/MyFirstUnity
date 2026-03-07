using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    //public string name;
    //public int damage;

    //public Weapon()
    //{
    //    name = "Unknown";
    //    damage = 10;
    //}

    //public Weapon(string name, int damage)
    //{
    //    this.name = name;
    //    this.damage = damage;
    //}   

    public string name { get; set; }

    //가상 함수

    public virtual void Attack()
    {
        Debug.Log("무기가 공격합니다.");
    }
}
