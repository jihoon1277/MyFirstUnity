using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FirstScript : MonoBehaviour
{
    // ---------------- 유니티에서 많이 쓰는 데이터 타입 ---------------------
    // int thisYear;
    // float pi;
    // string myName;  // 문자열 타입의 변수
    // bool isGameOver = false;   // 논리형 데이터 타입  ( true,  false  )중에 1개의 값을 갖는다.

    //void Start()
    //{
    //    thisYear = 2026;
    //    Debug.Log("이번 연도는 : " + thisYear + " 입니다.");

    //    pi = 3.14f;
    //    Debug.Log("파이 값은 " + pi + " 입니다.");

    //    myName = "페이커";
    //    Debug.Log("나의 이름은 " + myName + " 입니다.");

    //    Debug.Log("현재 게임 오버가 되었는지 확인하려면 " + isGameOver + "상태를 보면 됩니다.");
    //}


    //int hp = 90;
    //private void Start()
    //{
    //    hp = hp - 100;

    //    if(hp <= 0 )
    //    {
    //        hp = 0;
    //        Debug.Log("현재 체력 : " + hp + " 게임 오버");
    //    }
    //}

    //private void Start()
    //{
    //    Debug.Log(2 != 4 || 6 != 6);
    //    Debug.Log(3 != 3 && 6 != 6);
    //    Debug.Log(5 != 6 && 7 != 8);
    //    Debug.Log(false == false);
    //    Debug.Log(true == false);
    //    Debug.Log(true == true);
    //    Debug.Log(true != true);
    //    Debug.Log(false != true);
    //    Debug.Log(2 != 4);
    //    Debug.Log(3 != 4);
    //    Debug.Log(1 != 1);
    //    Debug.Log(6 != 7);
    //    Debug.Log(!true);
    //    Debug.Log(!false);
    //}


    //int hp = 100;
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        hp = hp - 20;

    //        //-------------------- if - else 문 예제 --------------------------------
    //        //if (hp <= 0)
    //        //{
    //        //    Debug.Log("게임 오버!");
    //        //}
    //        //else if (hp <= 40)
    //        //{
    //        //    Debug.Log("현재 체력은 : " + hp + " 입니다.");
    //        //    Debug.Log("비상!!!");
    //        //}
    //        //else if (hp <= 60)
    //        //{
    //        //    Debug.Log("현재 체력은 : " + hp + " 입니다.");
    //        //    Debug.Log("조심하세요!!");
    //        //}
    //        //else
    //        //{
    //        //    Debug.Log("현재 체력은 : " + hp + " 입니다.");
    //        //}

    //        switch (hp)
    //        {
    //            case 0:
    //                Debug.Log("게임 오버!");
    //                break;
    //            case 40:
    //                Debug.Log("현재 체력은 : " + hp + " 입니다.");
    //                Debug.Log("비상!!!");
    //                break;
    //            case 60:
    //                Debug.Log("현재 체력은 : " + hp + " 입니다.");
    //                Debug.Log("조심하세요!!");
    //                break;
    //            default:
    //                Debug.Log("기본 메시지 입니다.");
    //                break;
    //        }

    //    }
    //}

    // ---------------------------- 상수 알아보기 ---------------------------

    //const int DANGER_HP = 40;
    //const int WARNING_HP = 60;
    //const int DEAD_HP = 0;

    //int hp = 100;
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        hp = hp - 20;

    //        switch (hp)
    //        {
    //            case DEAD_HP:
    //                Debug.Log("게임 오버!");
    //                break;
    //            case DANGER_HP:
    //                Debug.Log("현재 체력은 : " + hp + " 입니다.");
    //                Debug.Log("비상!!!");
    //                break;
    //            case WARNING_HP:
    //                Debug.Log("현재 체력은 : " + hp + " 입니다.");
    //                Debug.Log("조심하세요!!");
    //                break;
    //            default:
    //                Debug.Log("기본 메시지 입니다.");
    //                break;
    //        }
    //    }
    //}

    //public enum Fruit
    //{
    //    APPLE, BANANA, PEACH, ORANGE
    //}

    //public Fruit myFruit;

    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        switch (myFruit)
    //        {
    //            case Fruit.APPLE:
    //                Debug.Log("사과는 맛있어!");
    //                break;
    //            case Fruit.BANANA:
    //                Debug.Log("바나나는 맛있어!");
    //                break;
    //            case Fruit.PEACH:
    //                Debug.Log("복숭아는 맛있어!");
    //                break;
    //            case Fruit.ORANGE:
    //                Debug.Log("오렌지는 맛있어!!");
    //                break;
    //        }
    //    }
    //}


    //private void Start()
    //{
    //    EnemyAttact();

    //    EnemyAttact();

    //    EnemyAttact();
    //}

    //private static void EnemyAttact()
    //{
    //    Debug.Log("Enemy Attack");
    //    Debug.Log("Enemy Damage");
    //    Debug.Log("Enemy HP UI Update");
    //}


    //void Start()
    //{
    //    Debug.Log(NextYear(2026));
    //}

    //int NextYear(int thisYear)
    //{
    //    int nextYear = thisYear + 1;
    //    return nextYear;
    //}

    //void Start()
    //{
    //    Debug.Log(PlusNumber(3, 9, 2));
    //    Debug.Log(MinusNumber(30, 10));.
    //    Debug.Log(TimesNumber(3, 9));
    //    Debug.Log(DivideNumber(30, 10));
    //    Debug.Log(RemainNumber(122, 3));
    //}


    //int PlusNumber(int a, int b)
    //{
    //    int sum = a + b;
    //    return sum;
    //}

    //float PlusNumber(float a, float b)
    //{
    //    float sum = a + b;
    //    return sum;
    //}
    //int PlusNumber(int a, int b, int c)
    //{
    //    int sum = a + b + c;
    //    return sum;
    //}

    //int MinusNumber(int a, int b)
    //{
    //    int sum = a - b;
    //    return sum;
    //}

    //int TimesNumber(int a, int b)
    //{
    //    int sum = a * b;
    //    return sum;
    //}

    //int DivideNumber(int a, int b)
    //{
    //    int sum = a / b;
    //    return sum;
    //}
    //int RemainNumber(int a, int b)
    //{
    //    int sum = a % b;
    //    return sum;
    //}

//    int[] myArray = new int[3];

//    int[] myArray2 = { 3, 6, 9 };

//    private void Start()
//    {
//        myArray[0] = 8;
//        myArray[1] = 16;
//        myArray[2] = 32;

//        Debug.Log(myArray[1]);
//    }

    //public List<int> myList = new List<int>();

    //public List<int> myList2 = new List<int>() { 4, 6, 9 };

    //private void Start()
    //{
    //    Debug.Log(myList2[1]);
    //}

    public List<int>myList = new List<int>();

    private void Start()
    {
        myList.Add(5);
        myList.Add(10);

        myList.Insert(1,7);

        myList.Add(15);

        myList.Remove(5);
        myList.RemoveAt(1);


    }
}
