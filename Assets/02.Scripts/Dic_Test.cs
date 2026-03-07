using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dic_Test : MonoBehaviour
{
    //Dictionary<int, string> Dictionary = new Dictionary<int, string>();
    //void Start()
    //{
    //    Dictionary.Add(1, "사과");
    //    Dictionary.Add(2, "바나나");
    //    Dictionary.Add(3, "체리");

    //    string value = Dictionary[2];
    //    Debug.Log(value);

    //    if (Dictionary.ContainsKey(2))
    //    { 
    //        Debug.Log("키 2가 존재합니다.");
    //    }

    //    if (Dictionary.ContainsValue("체리"))
    //    { 
    //        Debug.Log("값 체리가 존재합니다.");
    //    }

    //    Dictionary[1] = "아보카도";

    //    Dictionary.Remove(3);

    //    foreach (KeyValuePair<int, string> pair in Dictionary)
    //    {
    //        Debug.Log("Key:" + pair.Key + "Value" + pair.Value);
    //    }
    //}

    private Dictionary<string, int> items = new Dictionary<string, int>();

    void Start()
    {
        AddItem("포션", 1);
        AddItem("알릭서",1);
        
        UseItem("포션");

        PrintInventory();
    }

       void AddItem(string itemName, int quantity)
    {
        if (items.ContainsKey(itemName))
        {
            items[itemName]++;
        }
        else
        {
            items.Add(itemName, quantity);
        }
        Debug.Log("추가" + quantity + " " + itemName + "(을) 인벤토리로");
    }

    void UseItem(string itemName)
    {
        if (items.ContainsKey(itemName))
        {
            items[itemName]--;
            if (items[itemName] <= 0)
            {
                items.Remove(itemName);
            }
            Debug.Log("사용한 아이템" + itemName);
        }
        else
        {
            Debug.Log("아이템" + itemName +"을 찾을수 없음");
        }
    }

    void PrintInventory()
    {
        foreach (KeyValuePair<string, int> item in items)
        {
            Debug.Log("아이템:" + item.Key + "수량:" + item.Value);
        }
    }
}
