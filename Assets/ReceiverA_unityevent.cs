using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiverA_unityevent : MonoBehaviour
{
    public void Received(string str)
    {
        Debug.Log(str + "has been received by RecieverA");
    }
}
