using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    void OnEnable()
    {
        PlayerController.OnGameOver += RespondToGameOver;
    }

    void Disable()
    {
        PlayerController.OnGameOver -= RespondToGameOver;
    }

    void RespondToGameOver()
    {
        Debug.Log("勻煎切�ㄓ薑膜黎漱慾膜漱楔膜切h仄");
    }
}
