﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoBehaviors : MonoBehaviour
{
    public UnityEvent StartEvent;
    void Start()
    {
        StartEvent.Invoke();
    }
    
}