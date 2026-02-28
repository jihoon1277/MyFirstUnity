using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Player: MonoBehaviour
{
    //public int Score;
    //public int bonus;

    //public int TotalScore
    //{
    //    get { return Score + bonus; }
    //}

    // -- 자동 구현 프로퍼티 예제
    //public int Health { get; set; }

    //public int attack;
    //public int addAttack;

    //public int criticalAttack
    //{
    //    get { return attack + addAttack; }
    //}

//    public int health;
//    public int score;

//    void Awake()
//    {
//        health = 100;
//        score = 0;
//    }

//    void Start()
//    {
//        Debug.Log("Player initalized with health:" + health + "and score:" + score);
//    }

    public Weapon weapon;

    public Player()
    {
        weapon = new Weapon();
    }

    public Player(string weaponName, int weaponDamage)
    {
        weapon = new Weapon(weaponName, weaponDamage);
    }

    void Start()
    {
        Debug.Log("Player's weapon: " + weapon.name + "  damage: " + weapon.damage);
    }
}