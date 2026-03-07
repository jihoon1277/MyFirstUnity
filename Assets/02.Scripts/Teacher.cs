using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : Enemy
{
    public override void Die()
    {
        Debug.Log("선생님이 소멸했습니다.");
    }
}
