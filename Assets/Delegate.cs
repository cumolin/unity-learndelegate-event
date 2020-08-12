using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate : MonoBehaviour
{
    public delegate void SayDelegate(string str);   //宣告一個Delegate型別

    private void Start()
    {
        Say("Hello I'm ", Bill);    
        Say("Hello I'm ", Alice);
    }

    void Say(string str, SayDelegate func)  //我們可以以傳值的方式傳入其他函數給func存放該函數
    {
        func(str);  //執行傳入函數 
    }
    
    void Bill(string str)
    {
        Debug.Log(str + "Bill");
    }

    void Alice(string str)
    {
        Debug.Log(str + "Alice");
    }
}
