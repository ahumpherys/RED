using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
        Debug.Log("Entered Trigger.");
    }
    
//part of code is from triggers video in canvas modules 

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Within Trigger.");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited trigger.");
    }
}
