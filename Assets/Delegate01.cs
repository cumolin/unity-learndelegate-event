using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate01 : MonoBehaviour
{
    public delegate void SayDelegate(string str);   //宣告一個Delegate型別

    public SayDelegate sayDelegate; //SayDelegate宣告sayDelegate來存放函數

    private void Start()
    {
        sayDelegate = Bill; //指定Bill函數給sayDelegate
        sayDelegate("Hi "); 
        sayDelegate = Alice; //指定Alice函數給sayDelegate
        sayDelegate("Hi ");

        sayDelegate = null; //清空sayDelegate裡面存放的函數
        sayDelegate += Bill;    //新增Bill到sayDelegate
        sayDelegate += Alice;   //再新增Alice到sayDelegate
        sayDelegate("Hello");
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
