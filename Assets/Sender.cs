using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender : MonoBehaviour
{
    public delegate void SenderDelegate(string str);
    public static event SenderDelegate sendHandler; //建立Event

    void Start()
    {
        if(sendHandler != null)
        {
            sendHandler("A message from sender ");
        }
    }
}
