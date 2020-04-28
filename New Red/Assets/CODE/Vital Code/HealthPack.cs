using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{

    public float HealthPower = -50f;

    private void OnTriggerEnter(Collider other)
    {
        var health = other.gameObject.GetComponent<HealthScript>();
        if (health != null)
            health.TakeDamage(HealthPower);
        gameObject.active = false;
    }

    public float Speed = 20f;

    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * Speed);
    }
}