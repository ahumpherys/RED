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
    }
}