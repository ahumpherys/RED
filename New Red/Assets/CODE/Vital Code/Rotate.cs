﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float Speed = 50f;
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * Speed);
    }
}
