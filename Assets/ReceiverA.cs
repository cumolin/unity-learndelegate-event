using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiverA : MonoBehaviour
{
    private void OnEnable() //腳本啟用時將Received函數訂閱至sendHandler
    {
        Sender.sendHandler += Received;
    }

    private void OnDisable()    //腳本禁用時將Received函數解除訂閱至sendHandler
    {
        Sender.sendHandler -= Received;
    }

    public void Received(string str)
    {
        Debug.Log(str + "has been received by RecieverA");
    }
}
