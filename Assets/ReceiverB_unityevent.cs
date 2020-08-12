using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiverB_unityevent : MonoBehaviour
{
    public Sender_unityevent sender;

    private void OnEnable() //腳本啟用時將Received函數訂閱至sendEvent
    {
        sender.sendEvent.AddListener(Received);
    }

    private void OnDisable()    //腳本禁用時將Received函數解除訂閱至sendEvent
    {
        sender.sendEvent.RemoveListener(Received);
    }

    public void Received(string str)
    {
        Debug.Log(str + "has been received by RecieverB");
    }
}
