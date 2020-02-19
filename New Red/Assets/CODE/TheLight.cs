using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class TheLight : MonoBehaviour
{
    private Light lightObj;
    void Start()
    {
        lightObj = GetComponent<Light>();
        lightObj.intensity = 10f;
    }
    
    void Update()
    {
        
    }
}
