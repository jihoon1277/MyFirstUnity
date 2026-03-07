using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public delegate void GameOverAction();
    public static event GameOverAction OnGameOver;

    void Start()
    {
        Debug.Log("PlayerController:g 버튼을 누르면 게임 오버");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            TiggerGameOver();
        }
    }

    void TiggerGameOver()
    {
        Debug.Log("게임 오버");
        if (OnGameOver != null)
        {
            OnGameOver();
        }
    }

}
