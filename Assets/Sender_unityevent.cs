using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]   //顯示在unity editor
public class SendEvent : UnityEvent<string>
{

}

public class Sender_unityevent : MonoBehaviour
{
    public SendEvent sendEvent;

    private void Start()
    {
        if(sendEvent == null)
        {
            sendEvent = new SendEvent();
        }
        sendEvent.Invoke("This is a message from sender");
    }
}
